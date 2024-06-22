using Core.Database;
using Core.Domain;
using Core.Entidades;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Utils
{
    public static class DependencyInjections
    {

        public static void Init(IServiceCollection services)
        {


            services.AddDbContext<GulliverContext>(options => options.UseInMemoryDatabase("GulliverContext"));


            // Injecao de Dependencia
            services.AddScoped<IGulliverContext, GulliverContext>();
            services.AddScoped<ViagemDomain>();

        }

        public static void SeedData(IServiceProvider services)
        {
            using (var context = new GulliverContext(services.GetRequiredService<DbContextOptions<GulliverContext>>()))
            {
                if (context.Hoteis.Any())
                {
                    return;
                }

                context.Hoteis.AddRange
                (
                    new Hotel("Sao Paulo", "Ibis", new Random().Next(100, 300), 
                        "https://s3.amazonaws.com/assets.stg-apoiase.link/no-image.jpg"),

                    new Hotel("Sao Paulo", "West Plaza", new Random().Next(100, 300),
                        "https://s3.amazonaws.com/assets.stg-apoiase.link/no-image.jpg"),

                    new Hotel("Sao Paulo", "Tokyo Drift", new Random().Next(100, 300),
                        "https://s3.amazonaws.com/assets.stg-apoiase.link/no-image.jpg"),

                    new Hotel("Sao Paulo", "International 12", new Random().Next(100, 300),
                        "https://s3.amazonaws.com/assets.stg-apoiase.link/no-image.jpg"),


                    new Hotel("Atibaia", "Taua Resort", new Random().Next(100, 300),
                        "https://s3.amazonaws.com/assets.stg-apoiase.link/no-image.jpg"),

                    new Hotel("Atibaia", "Bourbon", new Random().Next(100, 300),
                        "https://s3.amazonaws.com/assets.stg-apoiase.link/no-image.jpg"),

                    new Hotel("Atibaia", "Eldorado", new Random().Next(100, 300),
                        "https://s3.amazonaws.com/assets.stg-apoiase.link/no-image.jpg"),

                    new Hotel("Atibaia", "Residence Resort", new Random().Next(100, 300),
                        "https://s3.amazonaws.com/assets.stg-apoiase.link/no-image.jpg")
                );

                context.SaveChanges();

                context.Disponibilidades.AddRange
                (
                    new Disponibilidade
                    {
                        Id = 11,
                        HotelId = 1,
                        Data = DateTime.Now.AddDays(1),
                    },
                    new Disponibilidade
                    {
                        Id = 12,
                        HotelId = 2,
                        Data = DateTime.Now.AddDays(2),
                    }
                );

                context.SaveChanges();

                if (context.Viagens.Any())
                {
                    return;
                }

                context.Viagens.AddRange
                (
                    new Viagem
                    {
                        Id = 1,
                        Tipo = "Aviao",
                        Origem = "Sao Paulo",
                        Data = DateTime.Now.AddDays(1),
                        Destino = "Nova York",
                        Preco = new Random().Next(1000, 3000)
                    },
                     new Viagem
                     {
                         Id = 2,
                         Tipo = "Aviao",
                         Origem = "Sao Paulo",
                         Data = DateTime.Now.AddDays(1),
                         Destino = "Mexico",
                         Preco = new Random().Next(1000, 3000)
                     },
                      new Viagem
                      {
                          Id = 3,
                          Tipo = "Aviao",
                          Origem = "Sao Paulo",
                          Data = DateTime.Now.AddDays(1),
                          Destino = "Tokyo",
                          Preco = new Random().Next(1000, 3000)
                      },
                       new Viagem
                       {
                           Id = 4,
                           Tipo = "Onibus",
                           Origem = "Sao Paulo",
                           Data = DateTime.Now.AddDays(1),
                           Destino = "Rio de Janeiro",
                           Preco = new Random().Next(1000, 3000)
                       }
                );

                context.SaveChanges();
            }
        }
    }
}
