using EfCoreTest.model;
using Microsoft.EntityFrameworkCore;
using EfCoreTest.关系配置.一对一;
using EfCoreTest.关系配置.一对多;
using EfCoreTest.关系配置.多对多;
namespace EfCoreTest
{
    public class TestDbContext : DbContext
    {
        public DbSet<StudentTeacherRelation> StudentTeacherRelations { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Comment> Comments { get; set; }

        public DbSet<Order> Orders { get; set; }
        public DbSet<Delivery> Deliveries { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Book> Books { get; set; }

        public DbSet<Dog> Dogs { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // string DefaultConnection = "Data Source=Computer-2021TO\\SQLEXPRESS;Initial Catalog=YZK;Persist Security Info=True;User ID=sa;Password=123456";
            string DefaultConnection = "Data Source=.;Initial Catalog=test;Persist Security Info=True;User ID=sa;Password=123456";
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
