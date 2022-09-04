using Microsoft.Extensions.DependencyInjection;
using NAutowired.Core.Attributes;
using NAutowired.Core.Models;

namespace 依赖注入.Logic
{
    //The default Lifetime value is Scoped
   // [Service]
    //Lifetime to choose the life cycle of dependency injection
    [Service(Lifetime.Singleton)]

    public class MyService02 : IService
    {
        public string SayHi()
        {
            return $" hello world server22222222 {DateTime.Now.ToString()}";
        }
    }
}
