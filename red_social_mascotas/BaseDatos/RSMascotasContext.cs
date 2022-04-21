using Microsoft.EntityFrameworkCore;
using red_social_mascotas.BaseDatos.Maps;
using red_social_mascotas.Models;

namespace red_social_mascotas.BaseDatos
{
    public class RSMascotasContext : DbContext
    {
        public DbSet<Comentario> _comentario { get; set; }
        public DbSet<Especie> _especie { get; set; }
        public DbSet<Mascota> _mascotas { get; set; }
        public DbSet<Publicacion> _publicaciones { get; set; }
        public DbSet<Raza> _razas { get; set; }
        public DbSet<Usuario> _Usuarios { get; set; }


        public RSMascotasContext(DbContextOptions<RSMascotasContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new ComentarioMap());
            modelBuilder.ApplyConfiguration(new EspecieMap());
            modelBuilder.ApplyConfiguration(new MascotaMap());
            modelBuilder.ApplyConfiguration(new PublicacionMap());
            modelBuilder.ApplyConfiguration(new RazaMap());
            modelBuilder.ApplyConfiguration(new UsuarioMap());
        }
    }
}