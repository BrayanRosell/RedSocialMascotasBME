using Microsoft.EntityFrameworkCore;
using red_social_mascotas.BaseDatos.Maps;
using red_social_mascotas.Models;
using System.Collections.Generic;
using System.Linq;

namespace red_social_mascotas.BaseDatos
{
    public interface IRSMascotasContext
    {
        DbSet<Comentario> _comentario { get; set; }
        DbSet<Especie> _especie { get; set; }
        DbSet<Mascota> _mascotas { get; set; }
        DbSet<Publicacion> _publicaciones { get; set; }
        DbSet<Raza> _razas { get; set; }
        DbSet<Usuario> _Usuarios { get; set; }
        DbSet<Foto> _Fotos { get; set; }
        int SaveChanges();
       
    }
    public class RSMascotasContext : DbContext, IRSMascotasContext
    {
       
        public virtual DbSet<Comentario> _comentario { get; set; }
        public virtual DbSet<Especie> _especie { get; set; }
        public virtual DbSet<Mascota> _mascotas { get; set; }
        public virtual DbSet<Publicacion> _publicaciones { get; set; }
        public virtual DbSet<Raza> _razas { get; set; }
        public virtual DbSet<Usuario> _Usuarios { get; set; }
        public virtual DbSet<Foto> _Fotos { get; set; }
        public RSMascotasContext()
        {

        }
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
            modelBuilder.ApplyConfiguration(new FotoMap());
        }

    }
}