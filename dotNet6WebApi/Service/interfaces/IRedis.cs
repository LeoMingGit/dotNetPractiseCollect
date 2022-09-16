using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.interfaces
{
    public interface IRedis
    {
        T Get<T>(string key);
        void Add(string key, object data);
        void Remove(string key);
        bool Any(string key);

    }
}
