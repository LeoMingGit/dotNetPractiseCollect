using Common;
using NPOI.SS.Formula.Functions;
using Service.interfaces;
using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.impl
{

    /// <summary>
    /// Task demo
    /// </summary>
    public class TaskRunImplService : ITaskRunService
    {


        private static readonly object lockObj = new object();



        /// <summary>
        ///获取监控数据
        /// </summary>
        /// <returns></returns>
        public async Task<ConcurrentBag<string>> GetMonitorDataList()
        {

            var mockList = new List<string>() { "1","2","3","4" };

            var tasks = new List<Task>();

            var processedIds = new ConcurrentDictionary<string, bool>();

            var  targetList = new ConcurrentBag<string>();

            foreach (var itemId in mockList)
            {
                lock (lockObj)
                {
                    if (!processedIds.ContainsKey(itemId))
                    {
                        tasks.Add(Task.Run(() =>
                        {
                            try
                            {
                                targetList.Add(itemId);
                                processedIds.TryAdd(itemId, true);

                            }
                            catch (Exception ex)
                            {
                               
                            }

                        }));

                    }
                }
            }

            await Task.WhenAll(tasks);

            return targetList;
        }

    }
}
