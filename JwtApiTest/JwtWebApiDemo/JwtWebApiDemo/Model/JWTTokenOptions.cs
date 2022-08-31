using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JwtWebApiDemo.Model
{
    public class JWTTokenOptions
    {
        public string SecurityKey
        {
            get;
            set;
        }
        public string Issuer
        {
            get;
            set;
        }
        public string Audience
        {
            get;
            set;
        }
     
   
        public int ExpireSeconds { get; set; }
    }
}
