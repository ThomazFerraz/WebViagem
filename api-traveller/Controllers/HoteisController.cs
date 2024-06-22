using api_traveller.Model;
using Core.Domain;
using Core.Entidades;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace api_traveller.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public partial class HoteisController : ControllerBase
    {
        private readonly ILogger<HoteisController> _logger;
        public ViagemDomain ViagemDomain { get; }

        public HoteisController(ILogger<HoteisController> logger, ViagemDomain viagemDomain)
        {
            _logger = logger;
            ViagemDomain = viagemDomain;
        }

        [HttpGet("PorNome")]
        public IEnumerable<Hotel> GetHotelPorNome(string cidade)
        {
            var hoteis = ViagemDomain.PesquisarHotel(cidade);

            if(!hoteis.Any())
            {
                var emptyHotel = new Hotel (cidade, "Não Disponivel", 0, 
                    "https://s3.amazonaws.com/assets.stg-apoiase.link/no-image.jpg");

                return new List<Hotel> { emptyHotel, emptyHotel,emptyHotel,emptyHotel };
            }

            return hoteis;
        }

        [HttpGet("PorNomeData")]
        public ResponseModel GetHotelPorNome(string cidade, string data)
        {
            var response = new ResponseModel();

            try
            {
                var lista = ViagemDomain.PesquisarHotel(cidade);
                response.Dados = lista;
            }
            catch (Exception exception)
            {
                response.Erros.Add(exception.Message);
            }

            return response;
        }
    }
}
