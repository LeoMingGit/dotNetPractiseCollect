using EfCoreTest.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace EfCoreTest.Test
{
    public  class UsersTest
    {
        public void QueryUsers()
        {
            using (var ctx= new TestDbContext())
            {
                List<User> lst= ctx.Users.Skip(0).Take(20).ToList();
                string json = JsonSerializer.Serialize(lst);
                Console.WriteLine(json);
            }
        }
    }
}
