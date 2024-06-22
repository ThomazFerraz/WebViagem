using Core.Entidades;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace api_traveller.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public partial class DisponibilidadeController : ControllerBase
    {
        private readonly ILogger<DisponibilidadeController> _logger;

        private readonly IGulliverContext _gulliverContext;

        public DisponibilidadeController(ILogger<DisponibilidadeController> logger, IGulliverContext gulliverContext)
        {
            _logger = logger;
            _gulliverContext = gulliverContext;
        }

        [HttpGet("PorHotel")]
        public IEnumerable<Disponibilidade> GetDisponibilidade(int hotelId)
        {
            return _gulliverContext.Disponibilidades.Where(hotel => hotel.HotelId == hotelId);
        }

        [HttpGet]
        public IEnumerable<Hotel> GetTodos()
        {
            return _gulliverContext.Hoteis;
        }

        //[HttpPost]
        //public void PostHotel([FromBody] Disponibilidade disponibilidade)
        //{
        //    _gulliverContext.Disponibilidades.Add(disponibilidade);
        //    _gulliverContext.SaveChanges();
        //}
    }
}

