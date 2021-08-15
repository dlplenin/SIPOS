using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIPOS.Entities.User;

namespace SIPOS.Persistence.Seed
{
    public class SiposRolSeed : IEntityTypeConfiguration<SiposRol>
    {
        public void Configure(EntityTypeBuilder<SiposRol> builder)
        {
            builder.HasData(
                new SiposRol { Id = new Guid("cbdb7e0a-f65c-44ca-9708-29d606770f4f"), Name = "Administrador" },
                new SiposRol { Id = new Guid("3bf4148a-6dcc-44ec-bf2b-7612ae1d3551"), Name = "Vendedor" }
                );
        }
    }
}
