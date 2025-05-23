using Batalha_Naval_API.Models.PartidaJogadasModel;
using Batalha_Naval_API.Services2;
using Microsoft.AspNetCore.Mvc;

namespace Batalha_Naval_API.Controllers_2
{
    [ApiController]
    [Route("api/[controller]")]
    public class PartidasJogadasController : ControllerBase
    {
        private readonly PartidasJogadasService _service;

        public PartidasJogadasController(PartidasJogadasService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> AtualizarResultados([FromBody] PartidasJogadasModel model)
        {
            await _service.AtualizarResultados(model);
            return Ok(new { message = "Resultados atualizados com sucesso" });
        }
    }

}
