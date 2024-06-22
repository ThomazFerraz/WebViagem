using Core.Domain;
using Core.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Core.Interfaces
{
    public interface IGulliverContext
    {
        DbSet<Disponibilidade> Disponibilidades { get; set; }
        DbSet<Hotel> Hoteis { get; set; }
        DbSet<Viagem> Viagens { get; set; }
    }
}