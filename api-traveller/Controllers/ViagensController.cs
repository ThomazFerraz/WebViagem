using Core.Entidades;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace api_traveller.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public partial class ViagensController : ControllerBase
    {
        private readonly ILogger<HoteisController> _logger;

        private readonly IGulliverContext _gulliverContext;

        public ViagensController(ILogger<HoteisController> logger, IGulliverContext gulliverContext)
        {
            _logger = logger;
            _gulliverContext = gulliverContext;
        }

        [HttpGet()]
        public IEnumerable<Viagem> GetViagemPorNome()
        {
            return _gulliverContext.Viagens;
        }
    }
}
