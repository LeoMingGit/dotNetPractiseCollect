using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreTest.关系配置.一对一
{
    public static class TestData
    {
        public static void Test()
        {
            using TestDbContext ctx = new TestDbContext();
            Order order = new Order();
            order.Address = "北京市海淀区中关村南大街999号";
            order.Name = "USB充电器";
            order.Code = Guid.NewGuid().ToString("N");
            Delivery delivery = new Delivery();
            delivery.CompanyName = "蜗牛快递";
            delivery.Number = "SN333322888";
            delivery.Code = Guid.NewGuid().ToString("N");
            delivery.Order = order;
            ctx.Deliveries.Add(delivery);
            ctx.SaveChanges();
        }
    }
}
