using EfCoreTest.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace EfCoreTest.Test
{
    public class UsersTest
    {
        public void QueryUsers()
        {
            using (var ctx = new TestDbContext())
            {
                List<User> lst = ctx.Users.Skip(0).Take(20).ToList();
                string json = JsonSerializer.Serialize(lst);
                Console.WriteLine(json);
            }
        }
        public void InsertUser()
        {
            using (var ctx = new TestDbContext())
            {
                User user = new User();
                user.ID = ctx.Users.OrderByDescending(x => x.ID).First().ID + 1;
                user.Newcolumn = "test";
                user.FirstNameLastName = "test";
                user.EmailAddress = "test";
                user.JobTitle = "test";
                ctx.Users.Add(user);
                ctx.SaveChanges();
            }
        }
        public void DelUser()
        {
            using (var ctx = new TestDbContext())
            {
                var id = ctx.Users.Where(p => p.Newcolumn.Contains("test")).FirstOrDefault()?.ID;
                ctx.Users.DeleteByKey(id);
                ctx.SaveChanges();
            }
        }
    }
}
