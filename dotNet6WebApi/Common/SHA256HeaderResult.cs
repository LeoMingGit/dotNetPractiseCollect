﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class SHA256HeaderResult
    {
        public string Timestamp { get; set; } = "";

        public string Signature { get; set; } = "";

        public string Nonce { get; set; } = "";

        public string ext_app_id { get; set; } = "";

        public bool IsNotEmpty()
        {
            if (string.IsNullOrEmpty(Timestamp)
                || string.IsNullOrEmpty(Signature) ||
                string.IsNullOrEmpty(Nonce) ||
                string.IsNullOrEmpty(ext_app_id)
                )
            {
                return false;
            }
            return true;
        }
    }
}
