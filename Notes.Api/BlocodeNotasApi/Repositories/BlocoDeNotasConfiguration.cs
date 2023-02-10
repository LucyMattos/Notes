using BlocodeNotasApi.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlocodeNotasApi.Repositories
{
    public class BlocoDeNotasConfiguration : IEntityTypeConfiguration<BlocoDeNotas>
    {
        public void Configure(EntityTypeBuilder<BlocoDeNotas> builder)
        {
            builder.ToTable("BlocoDeNotas", "Manager");
            builder.HasKey(p => p.Id)
                .HasName("PK_BlocoDeNotas");

            builder.Property(p => p.Id)
                .HasColumnType("INT")
                .UseIdentityColumn()
                .IsRequired();

            builder.Property(p => p.Titulo)
                .HasColumnType("VARCHAR(100)")
                .IsRequired();

            builder.Property(p => p.Descricao)
               .HasColumnType("VARCHAR(500)")
               .IsRequired();
        }
    }
}