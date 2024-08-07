﻿using Model.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.interfaces
{
    public interface IAuth
    {
        object getToken(GetTokenRequest dto);

        object refreshToken(RefreshTokenRequest dto);
    }
}
