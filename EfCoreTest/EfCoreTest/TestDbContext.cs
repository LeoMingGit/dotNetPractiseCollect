using EfCoreTest.model;
using Microsoft.EntityFrameworkCore;


namespace EfCoreTest
{
    public class TestDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Book> Books { get; set; }

        public DbSet<Dog> Dogs { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string DefaultConnection = "Data Source=Computer-2021TO\\SQLEXPRESS;Initial Catalog=YZK;Persist Security Info=True;User ID=sa;Password=123456";
           // string DefaultConnection = "Data Source=.;Initial Catalog=test;Persist Security Info=True;User ID=sa;Password=123456";
            optionsBuilder.UseSqlServer(DefaultConnection);
            optionsBuilder.LogTo(Console.WriteLine);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);
        }
    }
}
