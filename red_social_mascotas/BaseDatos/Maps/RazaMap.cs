using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using red_social_mascotas.Models;

namespace red_social_mascotas.BaseDatos.Maps
{
    public class RazaMap: IEntityTypeConfiguration<Raza>
    {
        public void Configure(EntityTypeBuilder<Raza> builder)
        {
            builder.ToTable("Raza");
            builder.HasKey(o => o.Id);

            builder.HasMany(o => o.Mascotas).
              WithOne(o => o.Razas).
              HasForeignKey(o => o.IdRaza);

            builder.HasMany(o => o.Publicaciones).
              WithOne(o => o.Razas).
              HasForeignKey(o => o.IdRaza);
        }
    }
}