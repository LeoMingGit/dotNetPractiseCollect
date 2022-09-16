using Microsoft.EntityFrameworkCore;
using Model.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Base
{
    public class BaseDbContext : DbContext
    {
        public BaseDbContext(DbContextOptions<BaseDbContext> options)
        : base(options)
        {


        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            ///以下是DB First 功能，可忽略
            //string DefaultConnection = "Data Source=.;Initial Catalog=test;Persist Security Info=True;User ID=sa;Password=123456";
            //optionsBuilder.UseSqlServer(DefaultConnection);
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.LogTo(Console.WriteLine);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);
        }

        public DbSet<Base_Customer_SysInfo> Base_Customer_SysInfos { get; set; }

    }
}
