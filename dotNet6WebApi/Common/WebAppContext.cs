using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class WebAppContext
    {
        public static IServiceCollection Services;
        public static HttpContext Current
        {
            get
            {
                var factory = Services.BuildServiceProvider().GetService(typeof(IHttpContextAccessor));
                return ((HttpContextAccessor)factory).HttpContext;
            }
        }
    }
}
