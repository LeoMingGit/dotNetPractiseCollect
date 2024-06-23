﻿using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.interfaces
{
    public interface ITaskRunService
    {

       Task<ConcurrentBag<string>> GetMonitorDataList();

    }
}