using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Service.Config
{
    public class TokenOptions
    {
        public string SecurityKey { get; set; }

        public int ExpireSeconds { get; set; }

    }
}
