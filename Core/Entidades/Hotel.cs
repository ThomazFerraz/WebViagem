using Core.Interfaces;

namespace Core.Entidades
{
    public class Hotel
    {
        public Hotel(string cidade, string nome, decimal preco, string source)
        {
            Nome = nome;
            Cidade = cidade;
            Preco = preco;
            Source = source;
        }

        public int Id { get; internal set; }
        public string Nome { get; internal set; }
        public string Cidade { get; internal set; }
        public decimal Preco { get; internal set; }
        public string Source { get; internal set; }
    }
}
