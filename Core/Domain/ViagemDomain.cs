using Core.Entidades;
using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain
{
    public class ViagemDomain
    {
        public IGulliverContext Context { get; }

        public ViagemDomain(IGulliverContext context)
        {
            Context = context;
        }

        public List<Hotel> PesquisarHotel(string chave)
        {
            if (!ValidarChave(chave))
                throw new Exception("Insira tres letras ou mais para pesquisar.");

            return Context.Hoteis
                .Where(hotel => hotel.Cidade.ToUpperInvariant().Contains(chave.ToUpperInvariant()))
                .ToList();
        }

        private bool ValidarChave(string chave)
        {
            if (chave.Length < 3)
                return false;

            return true;
        }
    }
}
