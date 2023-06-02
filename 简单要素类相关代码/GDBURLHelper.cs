// Decompiled with JetBrains decompiler
// Type: MapGIS.GM.GISHelper.GDBURLHelper
// Assembly: MapGIS.GM.GISHelper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 7B3A3DC1-9621-4E4B-BEDA-BFDE9C8D79DC
// Assembly location: D:\MapGisWorkSpace\Program-Dev\Program\MapGIS.GM.GISHelper.dll
// XML documentation location: D:\MapGisWorkSpace\Program-Dev\Program\MapGIS.GM.GISHelper.xml

using MapGIS.GeoDataBase;
using MapGIS.GeoDataBase.GeoRaster;
using MapGIS.GeoDataBase.Net;
using MapGIS.GeoObjects;
using MapGIS.GeoObjects.Att;
using MapGIS.GM.DataStash.TmpStore;
using System;
using System.Collections.Generic;
using System.IO;

namespace MapGIS.GM.GISHelper
{
  /// <summary>
  /// 提供对地理数据URL操作的辅助类，URL格式均支持标准地理数据格式，大多数不支持file协议，具体详见函数说明
  /// GDBURL标准格式：GDBP://[user:password@]serverName/gdbName/[ds|fds/ds06/]ocls/ku6.wb
  /// 该类所有方法目前均不支持CAD类、三维简单要素类、元数据
  /// </summary>
  public class GDBURLHelper
  {
    /// <summary>地理数据库URL协议头</summary>
    public const string GDBPPro = "GDBP://";
    /// <summary>本地文件URL协议头</summary>
    public const string FilePro = "file:///";

    /// <summary>从file:///开头的url中解析文件的路径</summary>
    /// <param name="url"></param>
    /// <returns></returns>
    public static string GetPathFromUrl(string url) => !string.IsNullOrEmpty(url) && url.ToLower().StartsWith("file:///") ? url.Substring("file:///".Length) : url;

    /// <summary>获取要素数据集名称</summary>
    /// <param name="url"></param>
    /// <returns>成功返回名称；失败返回string.Empty</returns>
    public static string GetDsName(string url)
    {
      if (string.IsNullOrEmpty(url))
        return string.Empty;
      string server = "";
      string database = "";
      string ds = "";
      string name = "";
      string user = "";
      string psw = "";
      string type = "";
      GDBURLHelper.GetURLInfo(url, out user, out psw, out server, out database, out ds, out type, out name);
      return ds;
    }

    /// <summary>根据URL获取的该路径所包含的地理数据库部分</summary>
    /// <param name="url">数据库/要素数据集/栅格目录/类路径</param>
    /// <param name="serverName">数据源名称</param>
    /// <param name="dbName">数据库名称</param>
    /// <param name="dsName">要素数据集/栅格目录名称（url为数据库，为空字符串)</param>
    /// <param name="clsName">类名称（url为数据库/要素数据集/栅格目录，为空字符串)</param>
    public static void GetNames(
      string url,
      out string serverName,
      out string dbName,
      out string dsName,
      out string clsName)
    {
      serverName = "";
      dbName = "";
      dsName = "";
      clsName = "";
      if (string.IsNullOrEmpty(url))
        return;
      string user = "";
      string psw = "";
      string type = "";
      GDBURLHelper.GetURLInfo(url, out user, out psw, out serverName, out dbName, out dsName, out type, out clsName);
    }

    /// <summary>根据URL返回数据类型</summary>
    /// <param name="url"></param>
    /// <returns></returns>
    public static XClsType GetXClsType(string url)
    {
      XClsType xclsType = XClsType.Unknown;
      if (!string.IsNullOrEmpty(url))
      {
        string ds = "";
        xclsType = GDBURLHelper.GetXClsType(url, out ds);
      }
      return xclsType;
    }

    /// <summary>根据URL返回数据类型，可以返回要素数据集名称（如果包含的话）</summary>
    /// <param name="url"></param>
    /// <param name="ds"></param>
    /// <returns></returns>
    public static XClsType GetXClsType(string url, out string ds)
    {
      ds = "";
      XClsType xclsType = XClsType.Unknown;
      if (!string.IsNullOrEmpty(url))
      {
        string typeUrl = "";
        string xclsName = "";
        xclsType = GDBURLHelper.GetXClsType(url, out ds, out typeUrl, out xclsName);
      }
      return xclsType;
    }

    /// <summary>根据URL返回数据类型，并且可以返回类型URL和类名称</summary>
    /// <param name="url"></param>
    /// <param name="typeUrl">末尾不带'/'</param>
    /// <param name="xclsName"></param>
    /// <returns></returns>
    public static XClsType GetXClsType(string url, out string typeUrl, out string xclsName)
    {
      typeUrl = "";
      xclsName = "";
      XClsType xclsType = XClsType.Unknown;
      if (!string.IsNullOrEmpty(url))
      {
        string ds = "";
        xclsType = GDBURLHelper.GetXClsType(url, out ds, out typeUrl, out xclsName);
      }
      return xclsType;
    }

    /// <summary>根据URL返回数据类型，并且可以返回类型URL和类名称</summary>
    /// <param name="url"></param>
    /// <param name="ds"></param>
    /// <param name="typeUrl">末尾不带'/'</param>
    /// <param name="xclsName"></param>
    /// <returns></returns>
    public static XClsType GetXClsType(
      string url,
      out string ds,
      out string typeUrl,
      out string xclsName)
    {
      ds = "";
      typeUrl = "";
      xclsName = "";
      XClsType xtype = XClsType.Unknown;
      if (!string.IsNullOrEmpty(url))
      {
        string user = "";
        string psw = "";
        string server = "";
        string database = "";
        string type = "";
        GDBURLHelper.GetURLInfo(url, out user, out psw, out server, out database, out ds, out type, out xclsName);
        xtype = GDBURLHelper.Str2XClsType(type);
        string str1 = GDBURLHelper.Combine2Server(user, psw, server);
        if (!string.IsNullOrEmpty(str1) && !string.IsNullOrEmpty(database) && xtype != XClsType.Unknown)
        {
          string str2 = str1 + "/" + database;
          if (!string.IsNullOrEmpty(ds) && xtype != XClsType.Fds && xtype != XClsType.Rcat)
            typeUrl = str2 + "/" + (xtype == XClsType.Rds ? GDBURLHelper.XClsType2Str(XClsType.Rcat) : GDBURLHelper.XClsType2Str(XClsType.Fds)) + "/" + ds + "/" + GDBURLHelper.XClsType2Str(xtype);
          else
            typeUrl = str2 + "/" + GDBURLHelper.XClsType2Str(xtype);
        }
      }
      return xtype;
    }

    /// <summary>根据URL获取的该路径所包含的地理数据源部分</summary>
    /// <param name="url"></param>
    /// <returns></returns>
    public static string GetServer(string url)
    {
      string server1 = "";
      if (!string.IsNullOrEmpty(url))
      {
        string user = "";
        string psw = "";
        string server2 = "";
        server1 = GDBURLHelper.GetServer(url, out user, out psw, out server2);
      }
      return server1;
    }

    /// <summary>根据URL获得用户名密码和服务器</summary>
    /// <param name="url"></param>
    /// <param name="user"></param>
    /// <param name="psw"></param>
    /// <param name="server">数据源名称</param>
    /// <returns>数据源路径</returns>
    public static string GetServer(string url, out string user, out string psw, out string server)
    {
      user = "";
      psw = "";
      server = "";
      string server1 = "";
      if (!string.IsNullOrEmpty(url))
      {
        string database = "";
        string ds = "";
        string type = "";
        string name = "";
        GDBURLHelper.GetURLInfo(url, out user, out psw, out server, out database, out ds, out type, out name);
        server1 = GDBURLHelper.Combine2Server(user, psw, server);
      }
      return server1;
    }

    /// <summary>根据URL获取的该路径所包含的地理数据库部分</summary>
    /// <param name="url"></param>
    /// <returns></returns>
    public static string GetDataBase(string url)
    {
      string dataBase = "";
      if (!string.IsNullOrEmpty(url))
      {
        string user = "";
        string psw = "";
        string server = "";
        string database = "";
        string ds = "";
        string type = "";
        string name = "";
        GDBURLHelper.GetURLInfo(url, out user, out psw, out server, out database, out ds, out type, out name);
        server = GDBURLHelper.Combine2Server(user, psw, server);
        if (!string.IsNullOrEmpty(server) && !string.IsNullOrEmpty(database))
          dataBase = server + "/" + database;
      }
      return dataBase;
    }

    /// <summary>根据数据类型标记返回数据类型</summary>
    /// <param name="type">例如：sfcls、acls等</param>
    /// <returns></returns>
    public static XClsType Str2XClsType(string type)
    {
      XClsType xclsType = XClsType.Unknown;
      if (!string.IsNullOrEmpty(type))
      {
        switch (type.ToLower())
        {
          case "acls":
            xclsType = XClsType.ACls;
            break;
          case "ds":
          case "fds":
            xclsType = XClsType.Fds;
            break;
          case "mapset":
            xclsType = XClsType.MapSet;
            break;
          case "ncls":
            xclsType = XClsType.GNet;
            break;
          case "ocls":
            xclsType = XClsType.OCls;
            break;
          case "ras":
            xclsType = XClsType.Rds;
            break;
          case "rcat":
            xclsType = XClsType.Rcat;
            break;
          case "rcls":
            xclsType = XClsType.RCls;
            break;
          case "sfcls":
            xclsType = XClsType.SFCls;
            break;
          default:
            xclsType = XClsType.Unknown;
            break;
        }
      }
      return xclsType;
    }

    /// <summary>根据数据类型返回数据类型标记</summary>
    /// <param name="xtype">数据类型</param>
    /// <returns>例如：sfcls、acls等</returns>
    public static string XClsType2Str(XClsType xtype)
    {
      string str = "";
      switch (xtype)
      {
        case XClsType.Fds:
          str = "ds";
          break;
        case XClsType.OCls:
          str = "ocls";
          break;
        case XClsType.ACls:
          str = "acls";
          break;
        case XClsType.RCls:
          str = "rcls";
          break;
        case XClsType.GNet:
          str = "ncls";
          break;
        case XClsType.Rcat:
          str = "rcat";
          break;
        case XClsType.Rds:
          str = "ras";
          break;
        case XClsType.SFCls:
          str = "sfcls";
          break;
        case XClsType.MapSet:
          str = "mapset";
          break;
      }
      return str;
    }

    /// <summary>根据用户名密码数据源将其拼接成标准的URL格式</summary>
    /// <param name="user"></param>
    /// <param name="psw"></param>
    /// <param name="server"></param>
    /// <returns></returns>
    public static string Combine2Server(string user, string psw, string server)
    {
      string str = "";
      if (!string.IsNullOrEmpty(server))
      {
        if (!string.IsNullOrEmpty(user) && !string.IsNullOrEmpty(psw))
          str = "GDBP://" + user + ":" + psw + "@" + server;
        else
          str = string.IsNullOrEmpty(user) ? (string.IsNullOrEmpty(psw) ? "GDBP://" + server : "GDBP://:" + psw + "@" + server) : "GDBP://" + user + "@" + server;
      }
      return str;
    }

    /// <summary>获取URL各个部分的信息</summary>
    /// <param name="url">对于有效的URL必定返回正确信息</param>
    /// <param name="user">用户名，有可能为空</param>
    /// <param name="psw">密码，有可能为空</param>
    /// <param name="server">地理数据源名称</param>
    /// <param name="database">地理数据库名称</param>
    /// <param name="ds">要素数据集名称（可以为空）</param>
    /// <param name="type">类型</param>
    /// <param name="name">类名称</param>
    /// <returns>小于等于0表示无效；大于0表示有效，1有效数据源，2有效数据库，3有效数据(要素数据集、栅格目录或者不带要素数据集数据)，4带要素数据集或栅格目录的有效数据</returns>
    private static int GetURLInfo(
      string url,
      out string user,
      out string psw,
      out string server,
      out string database,
      out string ds,
      out string type,
      out string name)
    {
      int urlInfo = 0;
      user = "";
      psw = "";
      server = "";
      database = "";
      ds = "";
      type = "";
      name = "";
      if (!string.IsNullOrEmpty(url))
      {
        string str1 = url.Trim();
        if (str1.StartsWith("GDBP://", StringComparison.CurrentCultureIgnoreCase))
        {
          string str2 = str1.Substring("GDBP://".Length);
          if (!string.IsNullOrEmpty(str2))
          {
            string[] strArray1 = str2.Split(new char[1]
            {
              '/'
            }, StringSplitOptions.RemoveEmptyEntries);
            string[] strArray2 = str2.Split('/');
            if (strArray1.Length != 0)
            {
              string str3 = strArray1[0];
              server = str3;
              int length1 = str3.LastIndexOf("@");
              if (length1 >= 0)
              {
                server = str3.Substring(length1 + 1);
                string str4 = str3.Substring(0, length1);
                int length2 = str4.IndexOf(":");
                if (length2 >= 0)
                {
                  user = str4.Substring(0, length2);
                  psw = str4.Substring(length2 + 1);
                }
                else
                {
                  user = str4;
                  psw = "";
                }
              }
            }
            if (strArray1.Length > 1)
              database = strArray1[1];
            if (strArray1.Length > 2)
            {
              type = strArray1[2];
              XClsType xclsType = GDBURLHelper.Str2XClsType(strArray1[2]);
              if (xclsType == XClsType.Fds || xclsType == XClsType.Rcat)
              {
                if (strArray1.Length > 3)
                {
                  if (xclsType == XClsType.Fds)
                    ds = strArray1[3];
                  name = strArray1[3];
                }
                if (strArray1.Length > 4)
                {
                  ds = strArray1[3];
                  type = strArray1[4];
                  if (strArray1.Length > 5)
                    name = strArray1[5];
                }
              }
              else if (strArray1.Length > 3)
                name = strArray1[3];
            }
            if (strArray1.Length == strArray2.Length)
            {
              if (strArray1.Length == 1)
              {
                if (!string.IsNullOrEmpty(GDBURLHelper.Combine2Server(user, psw, server)))
                  urlInfo = 1;
              }
              else if (strArray1.Length == 2)
              {
                if (!string.IsNullOrEmpty(GDBURLHelper.Combine2Server(user, psw, server)) && !string.IsNullOrEmpty(database))
                  urlInfo = 2;
              }
              else if (strArray1.Length == 4)
              {
                if (!string.IsNullOrEmpty(name) && GDBURLHelper.Str2XClsType(type) != XClsType.Unknown)
                  urlInfo = 3;
              }
              else if (strArray1.Length == 6 && !string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(ds) && GDBURLHelper.Str2XClsType(type) != XClsType.Unknown)
                urlInfo = 4;
            }
          }
        }
      }
      return urlInfo;
    }

    /// <summary>根据URL打开类，支持6x数据及栅格文件</summary>
    /// <param name="url"></param>
    /// <returns></returns>
    public static IBasCls OpenXCls(string url)
    {
      IBasCls basCls = (IBasCls) null;
      if (GDBURLHelper.Is6xURL(url))
      {
        GeomType geomType = GeomType.Unknown;
        string strA1 = url.Trim();
        int num = strA1.LastIndexOf(".");
        if (num > 0)
          strA1 = strA1.Substring(num + 1);
        string strA2 = "";
        int length = strA1.IndexOf("@");
        if (length > 0)
        {
          strA2 = strA1.Substring(length + 1);
          strA1 = strA1.Substring(0, length);
        }
        if (string.Compare(strA1, "wt", true) == 0)
          geomType = GeomType.Pnt;
        if (string.Compare(strA1, "wl", true) == 0)
          geomType = GeomType.Lin;
        if (string.Compare(strA1, "wp", true) == 0)
          geomType = GeomType.Reg;
        if (!url.StartsWith("file:///", StringComparison.OrdinalIgnoreCase))
          url = "file:///" + url;
        if (string.Compare(strA2, "ann", true) == 0)
        {
          AnnotationCls annotationCls = new AnnotationCls();
          if (annotationCls.Open(url))
            basCls = (IBasCls) annotationCls;
          else
            annotationCls.Dispose();
        }
        else if (string.Compare(strA1, "wb", true) == 0)
        {
          ObjectCls objectCls = new ObjectCls();
          if (objectCls.Open(url))
            basCls = (IBasCls) objectCls;
          else
            objectCls.Dispose();
        }
        else if (geomType != 0)
        {
          SFeatureCls sfeatureCls = new SFeatureCls();
          if (sfeatureCls.Open(url))
            basCls = (IBasCls) sfeatureCls;
          else
            sfeatureCls.Dispose();
        }
      }
      else if (GDBURLHelper.IsRasterURL(url))
      {
        RasterDataSet rasterDataSet = new RasterDataSet();
        if (rasterDataSet.Open(url, RasAccessType.RasAccessType_Update))
          basCls = (IBasCls) rasterDataSet;
      }
      else if (!string.IsNullOrEmpty(url))
      {
        string user = "";
        string psw = "";
        string server = "";
        string database = "";
        string type = "";
        string ds = "";
        string name = "";
        if (GDBURLHelper.GetURLInfo(url, out user, out psw, out server, out database, out ds, out type, out name) > 0)
        {
          switch (GDBURLHelper.Str2XClsType(type))
          {
            case XClsType.OCls:
              ObjectCls objectCls = new ObjectCls();
              if (objectCls.Open(url))
              {
                basCls = (IBasCls) objectCls;
                break;
              }
              objectCls.Dispose();
              break;
            case XClsType.ACls:
              AnnotationCls annotationCls = new AnnotationCls();
              if (annotationCls.Open(url))
              {
                basCls = (IBasCls) annotationCls;
                break;
              }
              annotationCls.Dispose();
              break;
            case XClsType.RCls:
              RelationCls relationCls = new RelationCls();
              if (relationCls.Open(url))
              {
                basCls = (IBasCls) relationCls;
                break;
              }
              relationCls.Dispose();
              break;
            case XClsType.GNet:
              NetCls netCls = new NetCls();
              if (netCls.Open(url))
              {
                basCls = (IBasCls) netCls;
                break;
              }
              netCls.Dispose();
              break;
            case XClsType.Rcat:
              RasterCatalog rasterCatalog = new RasterCatalog();
              if (rasterCatalog.OpenByURL(url))
              {
                basCls = (IBasCls) rasterCatalog;
                break;
              }
              break;
            case XClsType.Rds:
              RasterDataSet rasterDataSet = new RasterDataSet();
              if (rasterDataSet.Open(url, RasAccessType.RasAccessType_Update))
              {
                basCls = (IBasCls) rasterDataSet;
                break;
              }
              break;
            case XClsType.SFCls:
              SFeatureCls sfeatureCls = new SFeatureCls();
              if (sfeatureCls.Open(url))
              {
                basCls = (IBasCls) sfeatureCls;
                break;
              }
              sfeatureCls.Dispose();
              break;
            case XClsType.MapSet:
              MapSet mapSet = new MapSet(new DataBase());
              if (mapSet.Open(url))
              {
                basCls = (IBasCls) mapSet;
                break;
              }
              mapSet.Dispose();
              break;
          }
        }
      }
      return basCls;
    }

    /// <summary>
    /// 根据URL创建类（对于简单要素类则缺省以区创建，并且不支持栅格数据集创建），支持6x数据
    /// 6x注记数据点url后面加@ann
    /// </summary>
    /// <param name="url"></param>
    /// <returns>返回创建成功并已经打开的类</returns>
    public static IBasCls CreateXCls(string url) => GDBURLHelper.CreateXCls(url, GeomType.Reg);

    /// <summary>
    /// 根据URL创建类（不支持栅格数据集创建）
    /// 6x注记数据点url后面加@ann
    /// </summary>
    /// <param name="url"></param>
    /// <param name="geom">要素类型，在创建矢量类时有必要</param>
    /// <returns>返回创建成功并已经打开的类</returns>
    public static IBasCls CreateXCls(string url, GeomType geom)
    {
      Fields fields = (Fields) null;
      return GDBURLHelper.CreateXCls(url, geom, fields);
    }

    /// <summary>
    /// 根据URL创建类（不支持栅格数据集创建）
    /// 6x注记数据点url后面加@ann
    /// </summary>
    /// <param name="url"></param>
    /// <param name="geom">要素类型，在创建矢量类时有必要</param>
    /// <param name="srcVcls">源矢量类</param>
    /// <returns>返回创建成功并已经打开的类</returns>
    public static IBasCls CreateXCls(string url, GeomType geom, IVectorCls srcVcls)
    {
      Fields fields = srcVcls?.Fields?.Clone() ?? (Fields) null;
      return GDBURLHelper.CreateXCls(url, geom, fields);
    }

    /// <summary>
    /// 根据URL创建类（不支持栅格数据集创建）
    /// 6x注记数据点url后面加@ann
    /// </summary>
    /// <param name="url"></param>
    /// <param name="geom">要素类型，在创建矢量类时有必要</param>
    /// <param name="fields">属性字段字段</param>
    /// <returns>返回创建成功并已经打开的类</returns>
    public static IBasCls CreateXCls(string url, GeomType geom, Fields fields)
    {
      IBasCls xcls = (IBasCls) null;
      if (GDBURLHelper.Is6xURL(url))
      {
        if (!url.StartsWith("file:///", StringComparison.OrdinalIgnoreCase))
          url = "FILE:///" + url;
        GeomType type = GeomType.Unknown;
        string strA1 = url.Trim();
        int num = strA1.LastIndexOf(".");
        if (num > 0)
          strA1 = strA1.Substring(num + 1);
        string strA2 = "";
        int length = strA1.IndexOf("@");
        if (length > 0)
        {
          strA2 = strA1.Substring(length + 1);
          strA1 = strA1.Substring(0, length);
        }
        if (string.Compare(strA1, "wt", true) == 0)
          type = GeomType.Pnt;
        if (string.Compare(strA1, "wl", true) == 0)
          type = GeomType.Lin;
        if (string.Compare(strA1, "wp", true) == 0)
          type = GeomType.Reg;
        if (string.Compare(strA2, "ann", true) == 0)
        {
          AnnotationCls annotationCls = new AnnotationCls();
          if (annotationCls.Create(url) > 0)
          {
            if (fields != null)
              annotationCls.Fields = fields;
            xcls = (IBasCls) annotationCls;
          }
          else
            annotationCls.Dispose();
        }
        else if (string.Compare(strA1, "wb", true) == 0)
        {
          ObjectCls objectCls = new ObjectCls();
          if (objectCls.Create(url, fields) > 0)
            xcls = (IBasCls) objectCls;
          else
            objectCls.Dispose();
        }
        else if (type != 0)
        {
          SFeatureCls sfeatureCls = new SFeatureCls();
          if (sfeatureCls.Create(url, type) > 0)
          {
            if (fields != null)
              sfeatureCls.Fields = fields;
            xcls = (IBasCls) sfeatureCls;
          }
          else
            sfeatureCls.Dispose();
        }
      }
      else if (!string.IsNullOrEmpty(url))
      {
        string user = "";
        string psw = "";
        string server = "";
        string database = "";
        string type = "";
        string ds = "";
        string name = "";
        if (GDBURLHelper.GetURLInfo(url, out user, out psw, out server, out database, out ds, out type, out name) > 0)
        {
          switch (GDBURLHelper.Str2XClsType(type))
          {
            case XClsType.Fds:
              server = GDBURLHelper.Combine2Server(user, psw, server);
              if (!string.IsNullOrEmpty(server) && !string.IsNullOrEmpty(database))
              {
                DataBase.OpenByURL(server + "/" + database)?.CreateFds(ds, 0);
                break;
              }
              break;
            case XClsType.OCls:
              ObjectCls objectCls = new ObjectCls();
              if (objectCls.Create(url, fields) > 0)
              {
                xcls = (IBasCls) objectCls;
                break;
              }
              objectCls.Dispose();
              break;
            case XClsType.ACls:
              AnnotationCls annotationCls = new AnnotationCls();
              if (annotationCls.Create(url) > 0)
              {
                if (fields != null)
                  annotationCls.Fields = fields;
                xcls = (IBasCls) annotationCls;
                break;
              }
              annotationCls.Dispose();
              break;
            case XClsType.RCls:
              RelationCls relationCls = new RelationCls();
              if (relationCls.Create(url) > 0)
              {
                xcls = (IBasCls) relationCls;
                break;
              }
              relationCls.Dispose();
              break;
            case XClsType.GNet:
              NetCls netCls = new NetCls();
              if (netCls.Create(url) > 0)
              {
                xcls = (IBasCls) netCls;
                break;
              }
              netCls.Dispose();
              break;
            case XClsType.Rcat:
              server = GDBURLHelper.Combine2Server(user, psw, server);
              if (!string.IsNullOrEmpty(server) && !string.IsNullOrEmpty(database))
              {
                DataBase gdb = DataBase.OpenByURL(server + "/" + database);
                if (gdb != null)
                {
                  RasterCatalog rasterCatalog = new RasterCatalog(gdb);
                  if (rasterCatalog.CreateAndOpenRasterCatalog(name) > 0)
                    xcls = (IBasCls) rasterCatalog;
                }
                break;
              }
              break;
            case XClsType.SFCls:
              SFeatureCls sfeatureCls = new SFeatureCls();
              if (sfeatureCls.Create(url, geom) > 0)
              {
                if (fields != null)
                  sfeatureCls.Fields = fields;
                xcls = (IBasCls) sfeatureCls;
                break;
              }
              sfeatureCls.Dispose();
              break;
            case XClsType.MapSet:
              MapSet mapSet = new MapSet(new DataBase());
              if (mapSet.Create(url) > 0)
              {
                xcls = (IBasCls) mapSet;
                break;
              }
              mapSet.Dispose();
              break;
          }
        }
      }
      return xcls;
    }

    /// <summary>关闭类，支持6x数据</summary>
    /// <param name="xcls"></param>
    /// <returns></returns>
    public static bool CloseXCls(IBasCls xcls)
    {
      bool flag = false;
      if (xcls != null)
      {
        switch (xcls.ClsType)
        {
          case XClsType.Fds:
            flag = true;
            break;
          case XClsType.OCls:
            if (xcls is ObjectCls objectCls)
            {
              flag = objectCls.Close();
              break;
            }
            break;
          case XClsType.ACls:
            if (xcls is AnnotationCls annotationCls)
            {
              flag = annotationCls.Close();
              break;
            }
            break;
          case XClsType.RCls:
            if (xcls is RelationCls relationCls)
            {
              flag = relationCls.Close();
              break;
            }
            break;
          case XClsType.GNet:
            if (xcls is NetCls netCls)
            {
              flag = netCls.Close();
              break;
            }
            break;
          case XClsType.Rcat:
            if (xcls is RasterCatalog rasterCatalog)
            {
              flag = rasterCatalog.Close();
              break;
            }
            break;
          case XClsType.Rds:
            if (xcls is RasterDataSet rasterDataSet)
            {
              flag = rasterDataSet.Close();
              break;
            }
            break;
          case XClsType.SFCls:
            if (xcls is SFeatureCls sfeatureCls)
            {
              flag = sfeatureCls.Close();
              break;
            }
            break;
          case XClsType.MapSet:
            if (xcls is MapSet mapSet)
            {
              flag = mapSet.Close();
              break;
            }
            break;
        }
      }
      else
        flag = true;
      return flag;
    }

    /// <summary>根据URL删除类，支持6x数据及磁盘文件</summary>
    /// <param name="url"></param>
    /// <returns></returns>
    public static bool DeleteXCls(string url)
    {
      bool flag = false;
      if (GDBURLHelper.Is6xURL(url))
        flag = GDBURLHelper.DeleteFile(url);
      else if (File.Exists(url))
        flag |= GDBURLHelper.DeleteFile(url);
      else if (!string.IsNullOrEmpty(url))
      {
        int clsid = 0;
        int dsid = 0;
        XClsType type = XClsType.Unknown;
        string name = "";
        DataBase xclsInfo = GDBURLHelper.GetXClsInfo(url, out clsid, out dsid, out type, out name);
        if (xclsInfo != null && clsid > 0 && type != XClsType.Unknown)
          flag = GDBURLHelper.DeleteXCls(xclsInfo, type, clsid);
        xclsInfo?.Close();
      }
      return flag;
    }

    /// <summary>删除类，支持6x数据</summary>
    /// <param name="xcls"></param>
    /// <returns></returns>
    public static bool DeleteXCls(IBasCls xcls)
    {
      bool flag = false;
      if (xcls != null)
      {
        string url = xcls.URL;
        DataBase gdataBase = xcls.GDataBase;
        int clsId = xcls.ClsID;
        GDBURLHelper.CloseXCls(xcls);
        flag = GDBURLHelper.DeleteXCls(gdataBase, xcls.ClsType, clsId);
        if (GDBURLHelper.Is6xURL(url))
          flag |= GDBURLHelper.DeleteFile(url);
        else if (File.Exists(url))
          flag |= GDBURLHelper.DeleteFile(url);
      }
      return flag;
    }

    /// <summary>删除类</summary>
    /// <param name="db"></param>
    /// <param name="type"></param>
    /// <param name="clsid"></param>
    /// <returns></returns>
    public static bool DeleteXCls(DataBase db, XClsType type, int clsid)
    {
      bool flag = false;
      if (db != null && type != XClsType.Unknown && clsid > 0)
      {
        switch (type)
        {
          case XClsType.Fds:
            flag = db.RemoveFds(clsid);
            break;
          case XClsType.OCls:
            flag = ObjectCls.Remove(db, clsid);
            break;
          case XClsType.ACls:
            flag = AnnotationCls.Remove(db, clsid);
            break;
          case XClsType.RCls:
            flag = RelationCls.Remove(db, (object) clsid);
            break;
          case XClsType.GNet:
            flag = NetCls.Remove(db, clsid);
            break;
          case XClsType.Rcat:
            flag = RasterCatalog.DeleteCatalog(db, clsid);
            break;
          case XClsType.Rds:
            flag = RasterDataSet.DeleteFromGDB(db, clsid);
            break;
          case XClsType.SFCls:
            flag = SFeatureCls.Remove(db, clsid);
            break;
          case XClsType.MapSet:
            flag = MapSet.Remove(db, clsid);
            break;
        }
      }
      return flag;
    }

    /// <summary>删除类（不支持要素数据集、地图集、栅格目录、栅格数据集）</summary>
    /// <param name="db"></param>
    /// <param name="type"></param>
    /// <param name="name"></param>
    /// <returns></returns>
    public static bool DeleteXCls(DataBase db, XClsType type, string name)
    {
      bool flag = false;
      if (db != null && type != XClsType.Unknown && !string.IsNullOrEmpty(name))
      {
        switch (type)
        {
          case XClsType.OCls:
            flag = ObjectCls.Remove(db, name);
            break;
          case XClsType.ACls:
            flag = AnnotationCls.Remove(db, name);
            break;
          case XClsType.RCls:
            flag = RelationCls.Remove(db, (object) name);
            break;
          case XClsType.GNet:
            flag = NetCls.Remove(db, name);
            break;
          case XClsType.SFCls:
            flag = SFeatureCls.Remove(db, name);
            break;
        }
      }
      return flag;
    }

    /// <summary>判断URL是否已经存在，支持6x数据及磁盘文件</summary>
    /// <param name="url"></param>
    /// <returns>对于数据源和数据库验证有效性（会打开又关闭一次），对于数据集（要素数据集或栅格目录）及数据验证是否存在</returns>
    public static bool HasExisted(string url)
    {
      bool flag = false;
      if (File.Exists(url))
        flag = true;
      else if (GDBURLHelper.Is6xURL(url))
        flag = GDBURLHelper.IsFileExisted(url);
      else if (!string.IsNullOrEmpty(url))
      {
        string user = "";
        string psw = "";
        string server1 = "";
        string database = "";
        string type = "";
        string ds = "";
        string name = "";
        switch (GDBURLHelper.GetURLInfo(url, out user, out psw, out server1, out database, out ds, out type, out name))
        {
          case 1:
            Server server2 = new Server();
            if (server2.Connect(server1, user, psw))
            {
              flag = true;
              server2.DisConnect();
            }
            server2.Dispose();
            break;
          case 2:
            server1 = GDBURLHelper.Combine2Server(user, psw, server1);
            if (!string.IsNullOrEmpty(server1) && !string.IsNullOrEmpty(database))
            {
              database = server1 + "/" + database;
              DataBase dataBase = DataBase.OpenByURL(database);
              if (dataBase != null && dataBase.HasOpened)
              {
                flag = true;
                dataBase.Close();
                dataBase.Dispose();
              }
              break;
            }
            break;
          case 3:
          case 4:
            server1 = GDBURLHelper.Combine2Server(user, psw, server1);
            if (!string.IsNullOrEmpty(server1) && !string.IsNullOrEmpty(database))
            {
              database = server1 + "/" + database;
              DataBase dataBase = DataBase.OpenByURL(database);
              if (dataBase != null && dataBase.HasOpened)
              {
                if (dataBase.XClsIsExist(GDBURLHelper.Str2XClsType(type), name) > 0)
                  flag = true;
                dataBase.Close();
                dataBase.Dispose();
              }
              break;
            }
            break;
        }
      }
      return flag;
    }

    /// <summary>判断URL是否合法有效（不验证是否存在），支持6x数据及磁盘文件</summary>
    /// <param name="url"></param>
    /// <returns></returns>
    public static bool IsValid(string url)
    {
      bool flag = false;
      if (File.Exists(url))
        flag = true;
      else if (GDBURLHelper.Is6xURL(url))
        flag = GDBURLHelper.IsValidOfFileURL(url);
      else if (!string.IsNullOrEmpty(url))
      {
        string ds = "";
        string name = "";
        string user = "";
        string psw = "";
        string server = "";
        string database = "";
        string type = "";
        flag = GDBURLHelper.GetURLInfo(url, out user, out psw, out server, out database, out ds, out type, out name) > 0;
      }
      return flag;
    }

    /// <summary>根据URL打开数据源</summary>
    /// <param name="url"></param>
    /// <returns></returns>
    public static Server OpenServer(string url)
    {
      Server server1 = (Server) null;
      if (!string.IsNullOrEmpty(url))
      {
        string user = "";
        string psw = "";
        string server2 = "";
        string database = "";
        string type = "";
        string ds = "";
        string name = "";
        if (GDBURLHelper.GetURLInfo(url, out user, out psw, out server2, out database, out ds, out type, out name) > 0)
        {
          Server server3 = new Server();
          if (server3.Connect(server2, user, psw))
            server1 = server3;
          else
            server3.Dispose();
        }
      }
      return server1;
    }

    /// <summary>根据URL打开地理数据库</summary>
    /// <param name="url"></param>
    /// <returns></returns>
    public static DataBase OpenDataBase(string url)
    {
      DataBase dataBase = (DataBase) null;
      if (!string.IsNullOrEmpty(url))
      {
        string user = "";
        string psw = "";
        string server = "";
        string database = "";
        string type = "";
        string ds = "";
        string name = "";
        if (GDBURLHelper.GetURLInfo(url, out user, out psw, out server, out database, out ds, out type, out name) > 0)
        {
          server = GDBURLHelper.Combine2Server(user, psw, server);
          if (!string.IsNullOrEmpty(server) && !string.IsNullOrEmpty(database))
            dataBase = DataBase.OpenByURL(server + "/" + database);
        }
      }
      return dataBase;
    }

    /// <summary>打开临时数据库</summary>
    /// <returns>返回已经打开的临时数据库，该数据库不能直接调用Close，如果需要关闭则调用FreeTempDataBase即可</returns>
    public static DataBase OpenTempDataBase() => DataBase.OpenTempDB();

    /// <summary>释放临时数据库（用户一般无需调用，除非要重新打开一次临时数据库时需要）</summary>
    /// <param name="gdb"></param>
    /// <returns></returns>
    public static bool FreeTempDataBase(DataBase gdb) => DataBase.FreeTempDB(gdb);

    /// <summary>根据数据URL获取信息（此过程不会打开类，但会打开数据库）</summary>
    /// <param name="url"></param>
    /// <param name="clsid"></param>
    /// <param name="dsid"></param>
    /// <param name="type"></param>
    /// <param name="name"></param>
    /// <returns></returns>
    public static DataBase GetXClsInfo(
      string url,
      out int clsid,
      out int dsid,
      out XClsType type,
      out string name)
    {
      DataBase xclsInfo = (DataBase) null;
      clsid = 0;
      dsid = 0;
      type = XClsType.Unknown;
      name = "";
      if (!string.IsNullOrEmpty(url))
      {
        string user = "";
        string psw = "";
        string server = "";
        string database = "";
        string type1 = "";
        string ds = "";
        string name1 = "";
        if (GDBURLHelper.GetURLInfo(url, out user, out psw, out server, out database, out ds, out type1, out name1) > 0)
        {
          type = GDBURLHelper.Str2XClsType(type1);
          name = name1;
          string str = GDBURLHelper.Combine2Server(user, psw, server);
          if (!string.IsNullOrEmpty(str) && !string.IsNullOrEmpty(database))
          {
            database = str + "/" + database;
            xclsInfo = DataBase.OpenByURL(database);
            if (xclsInfo != null && type != XClsType.Unknown)
            {
              clsid = xclsInfo.XClsIsExist(type, name);
              if (!string.IsNullOrEmpty(ds))
                dsid = xclsInfo.XClsIsExist(XClsType.Fds, ds);
            }
          }
        }
      }
      return xclsInfo;
    }

    /// <summary>创建临时矢量类，使用MapGIS临时库</summary>
    /// <param name="name">为空时则自动创建名称</param>
    /// <param name="geom">为空时则缺省为区简简单要素类</param>
    /// <returns></returns>
    public static IBasCls CreateTempVectorCls(string name = "", GeomType geom = GeomType.Reg)
    {
      IBasCls tempVectorCls = (IBasCls) null;
      DataBase gdb = DataBase.OpenTempDB();
      if (gdb != null)
      {
        string name1 = name;
        if (string.IsNullOrEmpty(name1))
          name1 = Guid.NewGuid().ToString();
        switch (geom)
        {
          case GeomType.Pnt:
          case GeomType.Lin:
          case GeomType.Reg:
          case GeomType.Surface:
          case GeomType.Entity:
            SFeatureCls sfeatureCls = new SFeatureCls(gdb);
            if (sfeatureCls.Create(name1, geom, 0, 0, (Fields) null) > 0)
            {
              tempVectorCls = (IBasCls) sfeatureCls;
              break;
            }
            sfeatureCls.Dispose();
            break;
          case GeomType.Ann:
            AnnotationCls annotationCls = new AnnotationCls(gdb);
            if (annotationCls.Create(name1, AnnType.Text, 0, 0, (Fields) null) > 0)
            {
              tempVectorCls = (IBasCls) annotationCls;
              break;
            }
            annotationCls.Dispose();
            break;
        }
      }
      return tempVectorCls;
    }

    /// <summary>创建临时矢量类，使用地矿内置临时库</summary>
    /// <param name="name">为空时则自动创建名称</param>
    /// <param name="geom">为空时则缺省为区简简单要素类</param>
    /// <returns></returns>
    public static IBasCls CreateGMTempVectorCls(string name, GeomType geom)
    {
      IBasCls gmTempVectorCls = (IBasCls) null;
      DataBase gmSysTmpGdb = TmpGeoStoreServiceFactory.GetTGS().GetGmSysTmpGDB();
      if (gmSysTmpGdb != null)
      {
        string name1 = name;
        if (string.IsNullOrEmpty(name1))
          name1 = Guid.NewGuid().ToString();
        switch (geom)
        {
          case GeomType.Pnt:
          case GeomType.Lin:
          case GeomType.Reg:
          case GeomType.Surface:
          case GeomType.Entity:
            SFeatureCls sfeatureCls = new SFeatureCls(gmSysTmpGdb);
            if (sfeatureCls.Create(name1, geom, 0, 0, (Fields) null) > 0)
            {
              gmTempVectorCls = (IBasCls) sfeatureCls;
              break;
            }
            sfeatureCls.Dispose();
            break;
          case GeomType.Ann:
            AnnotationCls annotationCls = new AnnotationCls(gmSysTmpGdb);
            if (annotationCls.Create(name1, AnnType.Text, 0, 0, (Fields) null) > 0)
            {
              gmTempVectorCls = (IBasCls) annotationCls;
              break;
            }
            annotationCls.Dispose();
            break;
        }
      }
      return gmTempVectorCls;
    }

    /// <summary>创建临时栅格，使用地矿内置临时库</summary>
    /// <param name="name">为空时则自动创建名称</param>
    /// <param name="xSize">影像的列数</param>
    /// <param name="ySize">影像的行数</param>
    /// <param name="bandCount">影像的波段数</param>
    /// <param name="rasType">栅格像元值类型</param>
    /// <returns></returns>
    public static IBasCls CreateGMTempRas(
      string name,
      int xSize,
      int ySize,
      int bandCount,
      RasDataType rasType)
    {
      IBasCls gmTempRas = (IBasCls) null;
      DataBase gmSysTmpGdb = TmpGeoStoreServiceFactory.GetTGS().GetGmSysTmpGDB();
      if (gmSysTmpGdb != null)
      {
        string name1 = name;
        if (string.IsNullOrEmpty(name1))
          name1 = Guid.NewGuid().ToString();
        RasterDataSet rasterDataSet = new RasterDataSet(gmSysTmpGdb);
        if (rasterDataSet.Create(name1, xSize, ySize, bandCount, rasType))
          gmTempRas = (IBasCls) rasterDataSet;
      }
      return gmTempRas;
    }

    /// <summary>获取地矿内置临时库GDB的Url</summary>
    /// <returns></returns>
    public static string GetGMTempGDBUrl()
    {
      DataBase gmSysTmpGdb = TmpGeoStoreServiceFactory.GetTGS().GetGmSysTmpGDB();
      return gmSysTmpGdb != null ? gmSysTmpGdb.URL : string.Empty;
    }

    /// <summary>判断是否为6x路径</summary>
    /// <param name="url"></param>
    /// <returns></returns>
    private static bool Is6xURL(string url)
    {
      bool flag = false;
      if (!string.IsNullOrEmpty(url))
      {
        if (url.Trim().IndexOf("file:///", StringComparison.CurrentCultureIgnoreCase) == 0)
        {
          int num = url.LastIndexOf(".");
          if (num > 0)
          {
            string strA = url.Substring(num + 1);
            int length = strA.IndexOf("@");
            if (length > 0)
              strA = strA.Substring(0, length);
            if (string.Compare(strA, "wt", true) == 0 || string.Compare(strA, "wl", true) == 0 || string.Compare(strA, "wp", true) == 0 || string.Compare(strA, "wb", true) == 0)
              flag = true;
          }
        }
        else if (url.Trim().IndexOf("GDBP://", StringComparison.CurrentCultureIgnoreCase) < 0)
        {
          int num = url.LastIndexOf(".");
          if (num > 0)
          {
            string strA = url.Substring(num + 1);
            int length = strA.IndexOf("@");
            if (length > 0)
              strA = strA.Substring(0, length);
            if (string.Compare(strA, "wt", true) == 0 || string.Compare(strA, "wl", true) == 0 || string.Compare(strA, "wp", true) == 0 || string.Compare(strA, "wb", true) == 0)
              flag = true;
          }
        }
      }
      return flag;
    }

    /// <summary>判断是否为栅格文件路径</summary>
    /// <param name="url"></param>
    /// <returns></returns>
    private static bool IsRasterURL(string url)
    {
      bool flag = false;
      if (!string.IsNullOrEmpty(url) && File.Exists(url))
      {
        string extension = Path.GetExtension(url);
        if (!string.IsNullOrEmpty(extension))
        {
          string[] imgFilters = GDBURLHelper.GetImgFilters();
          if (imgFilters != null && imgFilters.Length != 0)
          {
            foreach (string strA in imgFilters)
            {
              if (string.Compare(strA, extension, true) == 0)
              {
                flag = true;
                break;
              }
            }
          }
        }
      }
      return flag;
    }

    /// <summary>获取带扩展名的所有影像文件过滤符(例如返回结果：*.msi;*.img;*.tif;*.grd)</summary>
    /// <returns></returns>
    private static string[] GetImgFilters()
    {
      List<string> stringList = new List<string>()
      {
        ".msi",
        ".img",
        ".tif",
        ".pix",
        ".jpg",
        ".bmp",
        ".gif",
        ".png",
        ".jp2",
        ".grd"
      };
      List<string> collection = new List<string>();
      RasFileExtInfo[] rasFileExtInfo1 = RasterDataSet.GetRasFileExtInfo(RasFileExtType.Input);
      if (rasFileExtInfo1 != null && rasFileExtInfo1.Length != 0)
      {
        foreach (RasFileExtInfo rasFileExtInfo2 in rasFileExtInfo1)
        {
          if (!rasFileExtInfo2.Descripe.Contains("*.*"))
          {
            if (rasFileExtInfo2.FileExt1 != null && rasFileExtInfo2.FileExt1.Trim().Length > 0)
              collection.Add("." + rasFileExtInfo2.FileExt1);
            if (rasFileExtInfo2.FileExt2 != null && rasFileExtInfo2.FileExt2.Trim().Length > 0)
              collection.Add("." + rasFileExtInfo2.FileExt2);
          }
        }
      }
      stringList.AddRange((IEnumerable<string>) collection);
      return stringList.ToArray();
    }

    /// <summary>文件路径是否有效</summary>
    /// <param name="url"></param>
    /// <returns></returns>
    private static bool IsValidOfFileURL(string url)
    {
      bool flag = false;
      if (!string.IsNullOrEmpty(url))
      {
        string str = url.Trim();
        if (str.IndexOfAny(Path.GetInvalidPathChars()) < 0 && (str.IndexOf("file:///", StringComparison.CurrentCultureIgnoreCase) == 0 || str.IndexOf("GDBP://", StringComparison.CurrentCultureIgnoreCase) < 0))
        {
          if (str.IndexOfAny(new char[1]{ ':' }) > 0)
            flag = true;
        }
      }
      return flag;
    }

    /// <summary>判断6x路径文件是否已经存在</summary>
    /// <param name="url"></param>
    /// <returns></returns>
    private static bool IsFileExisted(string url)
    {
      bool flag = false;
      if (!string.IsNullOrEmpty(url))
      {
        string path = url.Trim();
        if (path.StartsWith("file:///", StringComparison.CurrentCultureIgnoreCase))
          path = path.Substring("file:///".Length);
        int length = path.LastIndexOf("@");
        if (length > 0)
          path = path.Substring(0, length);
        try
        {
          flag = File.Exists(path);
        }
        catch
        {
        }
      }
      return flag;
    }

    /// <summary>删除文件</summary>
    /// <param name="url"></param>
    /// <returns></returns>
    private static bool DeleteFile(string url)
    {
      bool flag = false;
      if (!string.IsNullOrEmpty(url))
      {
        string path = url.Trim();
        if (path.StartsWith("file:///", StringComparison.CurrentCultureIgnoreCase))
          path = path.Substring("file:///".Length);
        int length = path.LastIndexOf("@");
        if (length > 0)
          path = path.Substring(0, length);
        try
        {
          File.Delete(path);
        }
        catch
        {
        }
        try
        {
          flag = !File.Exists(path);
        }
        catch
        {
        }
      }
      else
        flag = true;
      return flag;
    }
  }
}
