using EfCoreTest.model;
using Microsoft.EntityFrameworkCore;


namespace EfCoreTest
{
    public class TestDbContext : DbContext
    {

        public DbSet<Book> Books { get; set; }

        public DbSet<Dog> Dogs { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
<<<<<<< HEAD
            string DefaultConnection = "Data Source=Computer-2021TO\\SQLEXPRESS;Initial Catalog=YZK;Persist Security Info=True;User ID=sa;Password=123456";
          //  string DefaultConnection = "Data Source=.;Initial Catalog=test;Persist Security Info=True;User ID=sa;Password=123456";
=======
            // string DefaultConnection = "Data Source=Computer-2021TO\\SQLEXPRESS;Initial Catalog=YZK;Persist Security Info=True;User ID=sa;Password=123456";
            string DefaultConnection = "Data Source=.;Initial Catalog=test;Persist Security Info=True;User ID=sa;Password=123456";
>>>>>>> 2b2cea6d58c7e74b11566396018dedf18f7aa1ad
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
