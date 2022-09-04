using EfCoreTest.model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EfCoreTest.TbConfig
{

    public class DogEntityConfig : IEntityTypeConfiguration<Dog>
    {
        public void Configure(EntityTypeBuilder<Dog> builder)
        {
            builder.ToTable("T_Dog");
            builder.HasKey(p => p.Code);
            builder.Property(e => e.Code).HasMaxLength(120).IsRequired();
            builder.Property(e => e.Name).HasMaxLength(120).IsRequired();
        }
    }

}
