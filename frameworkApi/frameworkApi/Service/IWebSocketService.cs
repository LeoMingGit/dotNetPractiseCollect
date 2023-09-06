using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frameworkApi.Service
{

    public interface IWebSocketService
    {

        void Start(string ip, int port);

        void PushData(string data);
    }
}
