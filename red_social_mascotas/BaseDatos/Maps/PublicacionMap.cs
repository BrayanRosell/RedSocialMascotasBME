using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using red_social_mascotas.Models;

namespace red_social_mascotas.BaseDatos.Maps
{
    public class PublicacionMap: IEntityTypeConfiguration<Publicacion>
    {
        public void Configure(EntityTypeBuilder<Publicacion> builder)
        {
            builder.ToTable("Publicacion");
            builder.HasKey(o => o.Id);

            builder.HasMany(o => o.Comentarios).
               WithOne(o => o.Publicaciones).
               HasForeignKey(o => o.IdPublicacion);


        }
    }
}