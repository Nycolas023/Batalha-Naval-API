using Batalha_Naval_API.DTOs;
using Batalha_Naval_API.Services;
using Microsoft.AspNetCore.Mvc;

namespace Batalha_Naval_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ShipController : ControllerBase
    {
        private readonly ShipService _shipService;

        public ShipController(ShipService shipService)
        {
            _shipService = shipService;
        }

        [HttpPost]
        public async Task<IActionResult> CriarNavio([FromBody] ShipCreateDTO dto)
        {
            var sucesso = await _shipService.CriarNavioAsync(dto);

            if (!sucesso)
                return BadRequest("Erro ao cadastrar navio.");

            return Ok("Navio cadastrado com sucesso.");
        }


        [HttpGet]
        public async Task<ActionResult<List<ShipResponseDTO>>> BuscarTodos()
        {
            var navios = await _shipService.BuscarTodosAsync();
            if (navios == null) return NotFound("Nenhum navio encontrado.");
            return Ok(navios);
        }
    }
}
