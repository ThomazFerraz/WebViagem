using Core.Domain;
using Core.Entidades;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace Core.Database
{
    public class GulliverContext : DbContext, IGulliverContext
    {
        public GulliverContext(DbContextOptions<GulliverContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Hotel>()
            .Property(f => f.Id)
            .ValueGeneratedOnAdd();

            modelBuilder.Entity<Disponibilidade>()
            .Property(f => f.Id)
            .ValueGeneratedOnAdd();

            modelBuilder.Entity<Viagem>()
            .Property(f => f.Id)
            .ValueGeneratedOnAdd();

        }

        public DbSet<Hotel> Hoteis { get; set; }
        public DbSet<Disponibilidade> Disponibilidades { get; set; }
        public DbSet<Viagem> Viagens { get; set; }
    }
}