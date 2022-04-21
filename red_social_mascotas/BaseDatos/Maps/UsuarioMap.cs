using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using red_social_mascotas.Models;

namespace red_social_mascotas.BaseDatos.Maps
{
    public class UsuarioMap: IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuario");
            builder.HasKey(o => o.Id);

            builder.HasMany(o => o.Mascotas).
               WithOne(o => o.Usuarios).
               HasForeignKey(o => o.IdUsuario);

        }
    }
}