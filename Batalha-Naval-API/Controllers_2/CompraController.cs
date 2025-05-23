using Batalha_Naval_API.Models.Compra;
using Batalha_Naval_API.Services2;
using Microsoft.AspNetCore.Mvc;

namespace Batalha_Naval_API.Controllers_2
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
            await _service.PostCompraTema(model);
            return Ok(new { message = "Tema comprado com sucesso" });
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
