using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using red_social_mascotas.Models;

namespace red_social_mascotas.BaseDatos.Maps
{
    public class MascotaMap: IEntityTypeConfiguration<Mascota>
    {
        public void Configure(EntityTypeBuilder<Mascota> builder)
        {
            builder.ToTable("Mascota");
            builder.HasKey(o => o.Id);

            builder.HasMany(o => o.Publicaciones).
              WithOne(o => o.Mascotas).
              HasForeignKey(o => o.IdMascota);

            builder.HasMany(o => o.Fotos).
           WithOne(o => o.Mascotas).
           HasForeignKey(o => o.IdMascota);
        }
    }
}