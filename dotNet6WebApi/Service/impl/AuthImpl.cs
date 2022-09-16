using Model.DTOs;
using Service.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.impl
{
    public class AuthImpl : IAuth
    {
        public object getToken(GetTokenRequest dto)
        {
            throw new NotImplementedException();
        }

        public object refreshToken(RefreshTokenRequest dto)
        {
            throw new NotImplementedException();
        }
    }


}
