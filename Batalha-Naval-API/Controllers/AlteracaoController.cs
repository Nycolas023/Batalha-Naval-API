using Batalha_Naval_API.Models;
using Batalha_Naval_API.Services;
using Microsoft.AspNetCore.Mvc;

namespace Batalha_Naval_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlteracaoController : ControllerBase
    {
        private readonly AlteracaoService _service;

        public AlteracaoController(AlteracaoService service)
        {
            _service = service;
        }

        [HttpPut("AtualizarResultado")]
        public async Task<IActionResult> AtualizarResultados([FromBody] PartidasJogadasModel model)
        {
            await _service.AtualizarResultados(model);
            return Ok(new { message = "Resultados atualizados com sucesso" });
        }

        [HttpPut("AtualizarBarco")]
        public async Task<IActionResult> AtualizarBarco([FromBody] BarcoUpdateModel model)
        {
            await _service.AtualizarBarcos(model);
            return Ok(new { message = "Resultados atualizados com sucesso" });
        }

        [HttpPut("AtualizarTema")]
        public async Task<IActionResult> AtualizarTema([FromBody] TemaUpdateModel model)
        {
            await _service.AtualizarTemas(model);
            return Ok(new { message = "Resultados atualizados com sucesso" });
        }

        [HttpPut("AtualizarBomba")]
        public async Task<IActionResult> AtualizarBomba([FromBody] BombaUpdateModel model)
        {
            await _service.AtualizarBombas(model);
            return Ok(new { message = "Resultados atualizados com sucesso" });
        }

    }
}
