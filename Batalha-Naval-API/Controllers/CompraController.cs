using Batalha_Naval_API.Models.Compra;
using Batalha_Naval_API.Services;
using Microsoft.AspNetCore.Mvc;

namespace Batalha_Naval_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CompraController : ControllerBase
    {
        private readonly CompraService _service;

        public CompraController(CompraService service)
        {
            _service = service;
        }

        [HttpPost("tema")]
        public async Task<IActionResult> PostCompraTema([FromBody] CompraTemaModel model)
        {
            try
            {
                await _service.PostCompraTema(model);
                return Ok(new { message = "Tema comprado com sucesso" });
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("já possui o tema"))
                {
                    return BadRequest(new { error = "Usuário já comprou este tema." });
                }

                // Erro inesperado
                return StatusCode(500, new { error = "Erro ao processar a compra do tema.", detalhes = ex.Message });
            }
        }

        [HttpPost("moedas")]
        public async Task<IActionResult> PostCompraMoedas([FromBody] CompraMoedasModel model)
        {
            await _service.PostCompraMoedas(model);
            return Ok(new { message = "Moedas compradas com sucesso" });
        }

        [HttpPost("bomba")]
        public async Task<IActionResult> PostCompraBomba([FromBody] CompraBombaModel model)
        {
            await _service.PostCompraBomba(model);
            return Ok(new { message = "Bomba comprada com sucesso" });
        }
    }

}
