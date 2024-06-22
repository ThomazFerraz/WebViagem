using api_traveller.Model;
using Core.Domain;
using Microsoft.AspNetCore.Mvc;

namespace api_traveller.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PesquisaController : ControllerBase
    {
        private ViagemDomain ViagemDomain { get; }

        public PesquisaController(ViagemDomain viagemDomain)
        {
            ViagemDomain = viagemDomain;
        }

        [HttpGet("PorNome")]
        public ResponseModel GetHotelPorNome(string cidade)
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
