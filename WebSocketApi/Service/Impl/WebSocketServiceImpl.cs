using Fleck;
using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Microsoft.AspNetCore.Hosting.Server;
using Newtonsoft.Json.Linq;
using System.Collections.Concurrent;
using System.Net.WebSockets;

namespace WebSocketApi.Service.Impl
{

    /// <summary>
    /// websocket实现类
    /// </summary>
    public class WebSocketServiceImpl : IWebSocketService
    {
        #region 单例
        private static object _objLock = new object();
        private static WebSocketServiceImpl _instance = null;

        public static WebSocketServiceImpl Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_objLock)
                    {
                        if (_instance == null)
                        {
                            _instance = new WebSocketServiceImpl();
                        }
                    }
                }
                return _instance;
            }
        }

        #endregion

        ConcurrentDictionary<Guid, IWebSocketConnection> allSockets = new ConcurrentDictionary<Guid, IWebSocketConnection>();

        ConcurrentDictionary<string, Guid> tokenDics = new ConcurrentDictionary<string, Guid>();

        WebSocketServer sokcetServer = null;
        
        static object _lock = new object();

        public void Start(string ip,int port)
        {
            sokcetServer = new WebSocketServer($"ws://{ip}:" + port);
            sokcetServer.RestartAfterListenError = true; //失败后重启
            sokcetServer.Start(socket =>
            {
                socket.OnOpen = () => DoOpen(socket);
                socket.OnClose = () => DoClose(socket);
                socket.OnMessage = (msg) => DoMessage(socket, msg);
                socket.OnBinary = (bs) => DoBinary(socket, bs);
                socket.OnError = (e) => DoError(socket, e);
            });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="socket"></param>
        private void DoOpen(IWebSocketConnection socket)
        {
            socket.ConnectionInfo.Headers.TryGetValue("Authorization", out string token);
            if (IsValidAuthToken(token))
            {
                var socketId = socket.ConnectionInfo.Id;
                allSockets.TryAdd(socketId, socket);
                tokenDics.TryAdd(token, socketId);
                Console.WriteLine("\n[连接] " + "clientId:" + socket.ConnectionInfo.Id);
                Console.WriteLine("\n 当前连接数：" + allSockets.Count);
                socket.Send("连接成功");
            }
            else
            {
                socket.Send("无权限访问");
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="socket"></param>
        private void DoClose(IWebSocketConnection socket)
        {
            IWebSocketConnection so = null;
            var socketId = socket.ConnectionInfo.Id;
            var token = tokenDics.FirstOrDefault(pair => pair.Value == socketId).Key;
            tokenDics.TryRemove(token, out socketId);
            allSockets.TryRemove(socket.ConnectionInfo.Id, out so);
            Console.WriteLine("\n[关闭] " + "clientId:" + socket.ConnectionInfo.Id);
            Console.WriteLine("\n 当前连接数：" + allSockets.Count);
            socket.Send("关闭连接");

        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="socket"></param>
        /// <param name="e"></param>
        private void DoError(IWebSocketConnection socket, Exception e)
        {
            Console.WriteLine(e.Message);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="socket"></param>
        /// <param name="bs"></param>
        private void DoBinary(IWebSocketConnection socket, byte[] bs)
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="socket"></param>
        /// <param name="msg"></param>
        private void DoMessage(IWebSocketConnection socket, string msg)
        {
            Console.WriteLine(msg);
        }



        /// <summary>
        /// 鉴权
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        private  bool IsValidAuthToken(string token)
        {
            if (string.IsNullOrEmpty(token)) return false;
            var flag = true;
            //加入鉴权逻辑


            return flag;
        }



        /// <summary>
        /// 推送数据
        /// </summary>
        /// <param name="token"></param>
        /// <param name="data"></param>
        public void PushData(string token,string data)
        {
            lock (_lock)
            {
                var socketId = tokenDics.Where(x => x.Key == token).FirstOrDefault().Value;
                var pushSocket = allSockets.Where(x => x.Key == socketId);
                foreach (var item in allSockets)
                {
                    item.Value.Send(data);
                }
            }
        }

        /// <summary>
        /// 推送数据
        /// </summary>
        /// <param name="data"></param>
        public void PushData(string data)
        {
            lock (_lock)
            {
                foreach (var item in allSockets)
                {
                    item.Value.Send(data);
                }
            }
        }


    }
}
