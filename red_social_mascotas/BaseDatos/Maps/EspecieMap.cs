using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using red_social_mascotas.Models;

namespace red_social_mascotas.BaseDatos.Maps
{
    public class EspecieMap: IEntityTypeConfiguration<Especie>
    {
        public void Configure(EntityTypeBuilder<Especie> builder)
        {
            builder.ToTable("Especie");
            builder.HasKey(o => o.Id);

            builder.HasMany(o => o.Mascotas).
             WithOne(o => o.Especies).
             HasForeignKey(o => o.IdEspecie);


            builder.HasMany(o => o.Publicaciones).
             WithOne(o => o.Especies).
             HasForeignKey(o => o.IdEspecie);
        }
    }
}