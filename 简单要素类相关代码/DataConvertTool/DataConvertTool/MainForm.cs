using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MapGIS.GeoDataBase;
using MapGIS.GeoDataBase.Convert;
using MapGIS.GeoObjects;
using System.IO;

namespace DataConvertTool
{
    public partial class MainForm : Form
    {
        //定义数据源，数据库
        Server Svr = new Server();
        DataBase GDB = new DataBase();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Svr = new Server();
            List<int> dbIDs = null;
            Svr.Connect("MapGisLocal", "", "");

            dbIDs = Svr.GDBIDs;
            int dbCount = dbIDs.Count;
            int i = 0;

            //获取数据库的ID和名称
            while (i < dbCount)
            {
                int id = dbIDs[i];
                string name = Svr.GetDBName(id);
                gdbList.Items.Add(name);
                i++;
            }
            return;
        }

        private void gdbList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //要素数据集的id列表
            List<int> dsIDs = null;

            xclsList.Items.Clear();

            GDB = Svr.OpenGDB(gdbList.SelectedItem.ToString());
            if (GDB == null) return;

            //获取要素数据集的ID
            dsIDs = GDB.GetXclses(XClsType.Fds, 0);
            if (dsIDs != null)
            {
                int cou = dsIDs.Count;

                //获取要素数据集中简单要素类的信息
                for (int i = 0; i < cou; i++)
                {
                    xsfcls(XClsType.SFCls, dsIDs[i]);
                }

                //获取要素数据集中对象类的信息
                for (int i = 0; i < cou; i++)
                {
                    xsfcls(XClsType.OCls, dsIDs[i]);
                }

                //获取要素数据集中注记类的信息
                for (int i = 0; i < cou; i++)
                {
                    xsfcls(XClsType.ACls, dsIDs[i]);
                }
            }

            //直接获取数据库中的简单要素类中的信息
            xsfcls(XClsType.SFCls, 0);

            //直接获取数据库中的对象类中的信息
            xsfcls(XClsType.OCls, 0);

            //直接获取数据库中的注记类中的信息
            xsfcls(XClsType.ACls, 0);
        }

        /// <summary>
        /// 获取矢量类的id和name
        /// </summary>
        /// <param name="type">要素类型</param>
        /// <param name="xfID">要素数据集的ID</param>
        public void xsfcls(XClsType type, int xfID)
        {
            List<int> xclsIDs = null;

            xclsIDs = GDB.GetXclses(type, xfID);
            if (xclsIDs == null) return;

            int cou = xclsIDs.Count;
            for (int i = 0; i < cou; i++)
            {
                string name = GDB.GetXclsName(type, xclsIDs[i]);
                ListViewItem items = xclsList.Items.Add(name);
                items.SubItems.Add(xclsIDs[i].ToString());

                string typeName = "";
                switch (type)
                {
                    case XClsType.ACls: typeName = "注记类"; break;
                    case XClsType.SFCls: typeName = "简单要素类"; break;
                    case XClsType.OCls: typeName = "对象类"; break;
                }
                items.SubItems.Add(typeName);
            }
        }

        /// <summary>
        /// 删除指定类型的要素
        /// </summary>
        /// <param name="vecls">矢量类</param>
        /// <param name="GDB">地理数据库</param>
        public void delete(IVectorCls vecls, DataBase GDB)
        {
            string name = vecls.ClsName;
            int cou = vecls.Count;
            XClsType type = vecls.ClsType;

            vecls.Close();
            if (cou == 0)
            {
                if (type == XClsType.SFCls)
                {
                    SFeatureCls.Remove(GDB, name);
                }
                else if (type == XClsType.ACls)
                {
                    AnnotationCls.Remove(GDB, name);
                }
                else if (type == XClsType.OCls)
                {
                    ObjectCls.Remove(GDB, name);
                }
            }
        }

        private void btnDxfTo7x_Click(object sender, EventArgs e)
        {
            if (gdbList.SelectedItems.Count <= 0)
            {
                MessageBox.Show("请选择数据库");
                return;
            }

            DataBase GDB = new DataBase();
            OpenFileDialog OFD = new OpenFileDialog();
            string[] Str = null;

            GDB = Svr.OpenGDB(gdbList.SelectedItem.ToString());

            //打开DXF文件
            OFD.Multiselect = true;
            OFD.Filter = "dxf文件(*.dxf)|*.dxf";
            if (OFD.ShowDialog() != DialogResult.OK)
                return;

            Str = OFD.FileNames;

            //获得选中的导入数据
            for (int i = 0; i < Str.Length; i++)
            {
                //设置转换后要素类的名称
                SetClassName info = new SetClassName();
                if (info.ShowDialog() != DialogResult.OK)
                    return;

                SFeatureCls pntsfcls = new SFeatureCls(GDB);
                SFeatureCls linsfcls = new SFeatureCls(GDB);
                SFeatureCls regsfcls = new SFeatureCls(GDB);
                AnnotationCls Anncls = new AnnotationCls(GDB);
                string pntName = info.m_SFclsName + "_pnt";
                string linName = info.m_SFclsName + "_lin";
                string regName = info.m_SFclsName + "_reg";
                string annName = info.m_SFclsName + "_ann";

                //创建转换后的要素类
                pntsfcls.Create(pntName, GeomType.Pnt, 0, 0, null);
                linsfcls.Create(linName, GeomType.Lin, 0, 0, null);
                regsfcls.Create(regName, GeomType.Reg, 0, 0, null);
                Anncls.Create(annName, AnnType.Text, 0, 0, null);

                if (pntsfcls == null || linsfcls == null || Anncls == null || regsfcls == null)
                {
                    MessageBox.Show("创建失败！");
                    return;
                }

                //设置转换类型
                DataConvert DataCvr = new DataConvert();
                DataCvr.SetOption(ConvertOptionType.OPT_DXF_BLKPROC, true);

                //打开源数据和目的数据
                int src = DataCvr.OpenSource(System.IO.Path.GetFullPath(Str[i]));
                int des = DataCvr.OpenDestination(pntsfcls, linsfcls, regsfcls, Anncls);
                bool rtn = false;  //控制是否转换成功
                if (src <= 0)
                {
                    MessageBox.Show("打开数据源失败");
                    return;
                }
                if(des<=0)
                {
                    MessageBox.Show("打开目的数据失败");
                    return;
                }
                if (src > 0 && des > 0)
                {
                    rtn = DataCvr.Convert() > 0;//转换数据
                    if (rtn)
                        MessageBox.Show("数据迁移成功");
                

                   //转换失败删除
                   else
                    MessageBox.Show("数据转换失败");
                }

                //对目的数据为空的进行删除,因为有些数据转换成功后没有注记类或者区简单要素类，需要删除掉
                delete(pntsfcls, GDB);
                delete(linsfcls, GDB);
                delete(regsfcls, GDB);
                delete(Anncls, GDB);

                //刷新信息，重新加载GDB中的所有简单要素类
                gdbList_SelectedIndexChanged(sender, e);           
            }
            return;
        }

        private void btnE00To7x_Click(object sender, EventArgs e)
        {
            if (gdbList.SelectedItems.Count <= 0)
            {
                MessageBox.Show("请选择数据库");
                return;
            }

            DataBase GDB = new DataBase();
            OpenFileDialog OFD = new OpenFileDialog();
            string[] Str = null;

            GDB = Svr.OpenGDB(gdbList.SelectedItem.ToString());

            //打开E00文件
            OFD.Multiselect = true;
            OFD.Filter = "e00文件(*.e00)|*.e00";
            if (OFD.ShowDialog() != DialogResult.OK)
                return;

            Str = OFD.FileNames;

            //获得选中的导入数据
            for (int i = 0; i < Str.Length; i++)
            {
                //设置转换后简单要素类的名称
                SetClassName info = new SetClassName();
                if (info.ShowDialog() != DialogResult.OK)
                    return;

                SFeatureCls pntsfcls = new SFeatureCls(GDB);
                SFeatureCls linsfcls = new SFeatureCls(GDB);
                SFeatureCls regsfcls = new SFeatureCls(GDB);
                AnnotationCls Anncls = new AnnotationCls(GDB);
                string pntName = info.m_SFclsName + "_pnt";
                string linName = info.m_SFclsName + "_lin";
                string regName = info.m_SFclsName + "_reg";
                string annName = info.m_SFclsName + "_ann";

                //创建转换后的要素类
                pntsfcls.Create(pntName, GeomType.Pnt, 0, 0, null);
                linsfcls.Create(linName, GeomType.Lin, 0, 0, null);
                regsfcls.Create(regName, GeomType.Reg, 0, 0, null);
                Anncls.Create(annName, AnnType.Text, 0, 0, null);
                if (pntsfcls == null || linsfcls == null || Anncls == null || regsfcls == null)
                    return;

                //设置转换类型
                DataConvert DataCvr = new DataConvert();
                DataCvr.SetOption(ConvertOptionType.OPT_ARCGEO, true);

                //打开源数据和目的数据
                int src = DataCvr.OpenSource(System.IO.Path.GetFullPath(Str[i]));
                int des = DataCvr.OpenDestination(pntsfcls, linsfcls, regsfcls, Anncls);
                bool rtn = false;
                if (src > 0 && des > 0)
                {
                    rtn = DataCvr.Convert() > 0;//转换数据
                    if (rtn)
                        MessageBox.Show("数据迁移成功");
                }

                //转换失败删除
                if (!rtn)
                    MessageBox.Show("数据转换失败");

                //对目的数据为空的进行删除,因为有些数据转换成功后没有注记类或者区简单要素类，需要删除掉
                delete(pntsfcls, GDB);
                delete(linsfcls, GDB);
                delete(regsfcls, GDB);
                delete(Anncls, GDB);

                //刷新信息，重新加载GDB中的所有简单要素类
                gdbList_SelectedIndexChanged(sender, e);
            }
            return;
        }

        private void btnMifTo7x_Click(object sender, EventArgs e)
        {
            if (gdbList.SelectedItems.Count <= 0)
            {
                MessageBox.Show("请选择数据库");
                return;
            }

            DataBase GDB = new DataBase();
            OpenFileDialog OFD = new OpenFileDialog();
            string[] Str = null;

            GDB = Svr.OpenGDB(gdbList.SelectedItem.ToString());

            //打开MIF文件
            OFD.Multiselect = true;
            OFD.Filter = "MIF文件(*.MIF)|*.MIF";
            if (OFD.ShowDialog() != DialogResult.OK)
                return;

            Str = OFD.FileNames;
            //获得选中的导入数据
            for (int i = 0; i < Str.Length; i++)
            {
                //设置转换后简单要素类的名称
                SetClassName info = new SetClassName();
                if (info.ShowDialog() != DialogResult.OK)
                    return;

                SFeatureCls pntsfcls = new SFeatureCls(GDB);
                SFeatureCls linsfcls = new SFeatureCls(GDB);
                SFeatureCls regsfcls = new SFeatureCls(GDB);
                AnnotationCls Anncls = new AnnotationCls(GDB);
                string pntName = info.m_SFclsName + "_pnt";
                string linName = info.m_SFclsName + "_lin";
                string regName = info.m_SFclsName + "_reg";
                string annName = info.m_SFclsName + "_ann";

                //创建转换后的要素类
                pntsfcls.Create(pntName, GeomType.Pnt, 0, 0, null);
                linsfcls.Create(linName, GeomType.Lin, 0, 0, null);
                regsfcls.Create(regName, GeomType.Reg, 0, 0, null);
                Anncls.Create(annName, AnnType.Text, 0, 0, null);
                if (pntsfcls == null || linsfcls == null || Anncls == null || regsfcls == null)
                    return;

                //设置转换类型
                DataConvert DataCvr = new DataConvert();
                DataCvr.SetOption(ConvertOptionType.OPT_MIF_MAPFILE, System.IO.Path.GetFullPath(Str[i]));

                //打开源数据和目的数据
                int src = DataCvr.OpenSource(System.IO.Path.GetFullPath(Str[i]));
                int des = DataCvr.OpenDestination(pntsfcls, linsfcls, regsfcls, Anncls);

                bool rtn = false;
                if (src > 0 && des > 0)
                {
                    rtn = DataCvr.Convert() > 0;//转换数据
                    if (rtn)
                        MessageBox.Show("数据迁移成功");
                }

                //转换失败删除
                if (!rtn)
                    MessageBox.Show("数据转换失败");

                //对目的数据为空的进行删除,因为有些数据转换成功后没有注记类或者区简单要素类，需要删除掉
                delete(pntsfcls, GDB);
                delete(linsfcls, GDB);
                delete(regsfcls, GDB);
                delete(Anncls, GDB);

                //刷新信息，重新加载GDB中的所有简单要素类
                gdbList_SelectedIndexChanged(sender, e);
            }
            return;
        }

        private void btnShpTo7x_Click(object sender, EventArgs e)
        {
            if (gdbList.SelectedItems.Count <= 0)
            {
                MessageBox.Show("请选择数据库");
                return;
            }

            DataBase GDB = new DataBase();
            OpenFileDialog OFD = new OpenFileDialog();
            string[] Str = null;

            GDB = Svr.OpenGDB(gdbList.SelectedItem.ToString());

            //打开Shp文件
            OFD.Multiselect = true;
            OFD.Filter = "Shp文件(*.Shp)|*.Shp";
            if (OFD.ShowDialog() != DialogResult.OK)
                return;

            Str = OFD.FileNames;
            //获得选中的导入数据
            for (int i = 0; i < Str.Length; i++)
            {
                //设置转换后简单要素类的名称
                SetClassName info = new SetClassName();
                if (info.ShowDialog() != DialogResult.OK)
                    return;

                SFeatureCls pntsfcls = new SFeatureCls(GDB);
                SFeatureCls linsfcls = new SFeatureCls(GDB);
                SFeatureCls regsfcls = new SFeatureCls(GDB);
                AnnotationCls Anncls = new AnnotationCls(GDB);

                string pntName = info.m_SFclsName + "_pnt";
                string linName = info.m_SFclsName + "_lin";
                string regName = info.m_SFclsName + "_reg";
                string annName = info.m_SFclsName + "_ann";

                //创建转换后的要素类
                pntsfcls.Create(pntName, GeomType.Pnt, 0, 0, null);
                linsfcls.Create(linName, GeomType.Lin, 0, 0, null);
                regsfcls.Create(regName, GeomType.Reg, 0, 0, null);
                Anncls.Create(annName, AnnType.Text, 0, 0, null);
                if (pntsfcls == null || linsfcls == null || Anncls == null || regsfcls == null)
                    return;

                //设置转换类型
                DataConvert DataCvr = new DataConvert();
                DataCvr.SetOption(ConvertOptionType.OPT_SHPDB, false);

                //打开源数据和目的数据
                int src = DataCvr.OpenSource(System.IO.Path.GetFullPath(Str[i]));
                int des = DataCvr.OpenDestination(pntsfcls, linsfcls, regsfcls, Anncls);

                bool rtn = false;
                if (src > 0 && des > 0)
                {
                    rtn = DataCvr.Convert() > 0;//转换数据
                    if (rtn)
                        MessageBox.Show("数据迁移成功");
                }

                //转换失败删除
                if (!rtn)
                    MessageBox.Show("数据转换失败");

                //对目的数据为空的进行删除,因为有些数据转换成功后没有注记类或者区简单要素类，需要删除掉
                delete(pntsfcls, GDB);
                delete(linsfcls, GDB);
                delete(regsfcls, GDB);
                delete(Anncls, GDB);

                //刷新信息，重新加载GDB中的所有简单要素类
                gdbList_SelectedIndexChanged(sender, e);
            }
            return;
        }

        private void btnVctTo7x_Click(object sender, EventArgs e)
        {
            if (gdbList.SelectedItems.Count <= 0)
            {
                MessageBox.Show("请选择数据库");
                return;
            }

            DataBase GDB = new DataBase();
            OpenFileDialog OFD = new OpenFileDialog();
            string[] Str = null;

            GDB = Svr.OpenGDB(gdbList.SelectedItem.ToString());

            //打开VCT文件
            OFD.Multiselect = true;
            OFD.Filter = "vct文件(*.vct)|*.vct";
            if (OFD.ShowDialog() != DialogResult.OK)
                return;

            Str = OFD.FileNames;

            //获得选中的导入数据
            for (int i = 0; i < Str.Length; i++)
            {
                //设置转换后简单要素类的名称
                SetClassName info = new SetClassName();
                if (info.ShowDialog() != DialogResult.OK)
                    return;

                SFeatureCls pntsfcls = new SFeatureCls(GDB);
                SFeatureCls linsfcls = new SFeatureCls(GDB);
                SFeatureCls regsfcls = new SFeatureCls(GDB);
                AnnotationCls Anncls = new AnnotationCls(GDB);
                string pntName = info.m_SFclsName + "_pnt";
                string linName = info.m_SFclsName + "_lin";
                string regName = info.m_SFclsName + "_reg";
                string annName = info.m_SFclsName + "_ann";

                //创建转换后的要素类
                pntsfcls.Create(pntName, GeomType.Pnt, 0, 0, null);
                linsfcls.Create(linName, GeomType.Lin, 0, 0, null);
                regsfcls.Create(regName, GeomType.Reg, 0, 0, null);
                Anncls.Create(annName, AnnType.Text, 0, 0, null);
                if (pntsfcls == null || linsfcls == null || Anncls == null || regsfcls == null)
                    return;

                //设置转换类型
                DataConvert DataCvr = new DataConvert();
                DataCvr.SetOption(ConvertOptionType.OPT_SHPDB, false);

                //打开源数据和目的数据
                int src = DataCvr.OpenSource(System.IO.Path.GetFullPath(Str[i]));
                int des = DataCvr.OpenDestination(pntsfcls, linsfcls, regsfcls, Anncls);

                bool rtn = false;
                if (src > 0 && des > 0)
                {
                    rtn = DataCvr.Convert() > 0;//转换数据
                    if (rtn)
                        MessageBox.Show("数据迁移成功");
                }

                //转换失败删除
                if (!rtn)
                    MessageBox.Show("数据转换失败");

                //对目的数据为空的进行删除,因为有些数据转换成功后没有注记类或者区简单要素类，需要删除掉
                delete(pntsfcls, GDB);
                delete(linsfcls, GDB);
                delete(regsfcls, GDB);
                delete(Anncls, GDB);

                //刷新信息，重新加载GDB中的所有简单要素类
                gdbList_SelectedIndexChanged(sender, e);
            }
            return;
        }

        private void btn_67to7x_Click(object sender, EventArgs e)
        {          
            //导入的6X数据的路径列表
            string[] Str = null;
            //记录导入成功的6X数据的个数
            int cou = 0;
            //转换参数
            DataConvert DataCvr = null;
            //目的类
            SFeatureCls desSFCls = null;
            //简单要素类几何类型
            GeomType geomType = new GeomType();

            //初始化变量
            DataBase GDB = new DataBase();
            OpenFileDialog open6xDlg = new OpenFileDialog();

            if (gdbList.SelectedItems.Count <= 0)
            {
                MessageBox.Show("请选择一个数据库");
                return;
            }

            GDB = Svr.OpenGDB(gdbList.SelectedItem.ToString());

            open6xDlg.Multiselect = true;
            open6xDlg.Filter = ".wt|*.wt|.wl|*.wl|.wp|*.wp";
            if (open6xDlg.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            //获取选定文件的路径
            Str = open6xDlg.FileNames;
            //获得选中的导入数据
            for (int i = 0; i < Str.Length; i++)
            {
                DataCvr = new DataConvert();
                desSFCls = new SFeatureCls(GDB);

                //6x数据的类型
                string type = System.IO.Path.GetExtension(Str[i]);
                geomType = new GeomType();
                switch (type)
                {
                    case ".wt":
                    case ".WT": geomType = GeomType.Pnt; break;
                    case ".wl":
                    case ".WL": geomType = GeomType.Lin; break;
                    case ".wp":
                    case ".WP": geomType = GeomType.Reg; break;
                }

                //设置转换后简单要素类的名称
                SetClassName info = new SetClassName();
                if (info.ShowDialog() != DialogResult.OK)
                    return;

                //目的类的名称
                string desClsName = info.m_SFclsName;

                //创建目的类
                bool rtn = desSFCls.Create(desClsName, geomType, 0, 0, null) > 0;

                //判断目的类是否创建成功
                if (!rtn)
                {
                    MessageBox.Show("创建失败，重名，请重新操作");
                    return;
                }

                //6x数据的绝对路径
                string SurPath = System.IO.Path.GetFullPath(Str[i]);
                //转换类型6xTO7x
                DataCvr.SetOption(ConvertOptionType.OPT_6TO7, 0);

                if (DataCvr.OpenSource(SurPath) > 0 && DataCvr.OpenDestination(desSFCls) > 0)
                {
                    //转换数据
                    rtn = DataCvr.Convert() > 0;
                    if (rtn)
                    {
                        MessageBox.Show(Path.GetFileNameWithoutExtension(Str[i]) + "数据迁移成功");
                        cou++;
                    }
                    else
                    {
                        desSFCls.Close();
                        SFeatureCls.Remove(GDB, desClsName);
                        MessageBox.Show(Path.GetFileNameWithoutExtension(Str[i]) + "转换失败");
                    }
                }

                desSFCls.Close();
                DataCvr.Close();
            }

            MessageBox.Show("一共成功导入了" + cou.ToString() + "个简单要素类");
            //刷新信息，重新加载GDB中的所有简单要素类
            gdbList_SelectedIndexChanged(sender, e);

            return;
        }

        private void butExcelTo7x_Click(object sender, EventArgs e)
        {
            if (gdbList.SelectedItems.Count <= 0)
            {
                MessageBox.Show("请选择数据库");
                return;
            }

            DataBase GDB = new DataBase();
            OpenFileDialog OFD = new OpenFileDialog();
            string[] Str = null;

            GDB = Svr.OpenGDB(gdbList.SelectedItem.ToString());

            //打开表格数据
            OFD.Multiselect = true;
            OFD.Filter = "表格数据(*.xls)|*.xls";
            if (OFD.ShowDialog() != DialogResult.OK)
                return;

            Str = OFD.FileNames;

            //获得选中的导入数据
            for (int i = 0; i < Str.Length; i++)
            {
                //设置转换后对象类的名称
                SetClassName info = new SetClassName();
                if (info.ShowDialog() != DialogResult.OK)
                    return;

                ObjectCls objCls = new ObjectCls(GDB);              
                string objName = info.m_SFclsName + "_obj";

                //创建转换后的对象                
                objCls.Create(objName, 0, 0, null);

                if (objCls == null)
                    return;

                //设置转换类型
                DataConvert DataCvr = new DataConvert();
                TableInfo tableInfo = new TableInfo();
                DataCvr.SetOption(ConvertOptionType.OPT_CONVTABLE, tableInfo);
                DataCvr.GetDestInfo(DestInfoType.CONVERT_MPDOPT_CONVTABLE, tableInfo);

                //打开源数据和目的数据
                int src = DataCvr.OpenSource("DBMS://" + System.IO.Path.GetFullPath(Str[i]) + "/" + System.IO.Path.GetFileNameWithoutExtension(Str[i]) + "?Driver=Excel");
                int des = DataCvr.OpenDestination(objCls);

                bool rtn = false;
                if (src > 0 && des > 0)
                {
                    rtn = DataCvr.Convert() > 0;//转换数据
                    if (rtn)
                        MessageBox.Show("数据转换成功");
                }

                //转换失败删除
                if (!rtn)
                {
                    MessageBox.Show("数据转换失败");
                    ObjectCls.Remove(GDB,objCls.ClsID);
                }
                              
                //刷新信息，重新加载GDB中的所有简单要素类
                gdbList_SelectedIndexChanged(sender, e);
            }

            GDB.Close();
            return;
        }

        private void Btn_7Xto6X_Click(object sender, EventArgs e)
        {
            if (xclsList.SelectedItems.Count <= 0)
            {
                MessageBox.Show("请选择待转换的数据！！！");
                return;
            }

            //打开数据库
            DataBase GDB = new DataBase();
            GDB = Svr.OpenGDB(gdbList.SelectedItem.ToString());
            //打开简单要素类
            SFeatureCls sfcls = new SFeatureCls(GDB);
            sfcls.Open(xclsList.SelectedItems[0].SubItems[0].Text, 0);

            //设置转换后67数据的名称
            SaveFileDialog saveDlg = new SaveFileDialog();
            saveDlg.Filter = "点文件、注记文件|*.wt|线文件|*.wl|区文件|*.wp";
            if (saveDlg.ShowDialog() != DialogResult.OK)
                return;
            string fileName = saveDlg.FileName;

            //设置转换类型
            DataConvert DataCvr = new DataConvert();
            DataCvr.SetOption(ConvertOptionType.OPT_7XTO6XSRSID, false);

            //打开源数据和目的数据
            int src = DataCvr.OpenSource(sfcls);
            int des = DataCvr.OpenDestination(fileName);

            bool rtn = false;
            if (src > 0 && des > 0)
            {
                rtn = DataCvr.Convert() > 0;//转换数据              
            }

            if (rtn)
                MessageBox.Show("数据转换成功");
            else
                MessageBox.Show("数据转换失败,注意源数据的类型！！！");

            //关闭数据
            sfcls.Close();
            GDB.Close();

            return;
        }

        private void btn_7xToSHP_Click(object sender, EventArgs e)
        {
            if (xclsList.SelectedItems.Count <= 0)
            {
                MessageBox.Show("请选择待转换的数据！！！");
                return;
            }

            //打开数据库
            DataBase GDB = new DataBase();
            GDB = Svr.OpenGDB(gdbList.SelectedItem.ToString());
            //打开简单要素类
            SFeatureCls sfcls = new SFeatureCls(GDB);
            sfcls.Open(xclsList.SelectedItems[0].SubItems[0].Text, 0);

            //设置转换后shp数据的名称
            SaveFileDialog saveDlg = new SaveFileDialog();
            saveDlg.Filter = "shp数据|*.shp";
            if (saveDlg.ShowDialog() != DialogResult.OK)
                return;
            string fileName = saveDlg.FileName;

            //设置转换类型
            DataConvert DataCvr = new DataConvert();
            DataCvr.SetOption(ConvertOptionType.OPT_SHPDB, 1);

            //打开源数据和目的数据
            int src = DataCvr.OpenSource(sfcls);
            int des = DataCvr.OpenDestination(fileName);

            bool rtn = false;
            if (src > 0 && des > 0)
            {
                rtn = DataCvr.Convert() > 0;//转换数据              
            }

            if (rtn)
                MessageBox.Show("数据转换成功");
            else
                MessageBox.Show("数据转换失败,注意源数据的类型！！！");

            //关闭数据
            sfcls.Close();
            GDB.Close();

            return;
        }

      

      
     

    }
}