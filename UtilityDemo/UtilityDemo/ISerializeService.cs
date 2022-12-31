using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilityDemo
{
    public  interface ISerializeService
    {
        string SerializeObject(object value);
        T DeserializeObject<T>(string value);
    }
}
