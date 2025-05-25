using Batalha_Naval_API.Models.DeletesModel;
using Batalha_Naval_API.Services;
using Microsoft.AspNetCore.Mvc;
using Supabase.Postgrest.Exceptions;

namespace Batalha_Naval_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DeletesController : ControllerBase
    {
        private readonly DeletesService _service;

        public DeletesController(DeletesService service)
        {
            _service = service;
        }

        [HttpDelete("deletar-barco")]
        public async Task<ActionResult> DeletarBarco([FromBody] DeleteBarcoModel model)
        {
            await _service.DeletarBarcoAsync(model);
            return Ok();
        }

        [HttpDelete("deletar-bomba")]
        public async Task<IActionResult> DeletarBomba([FromBody] DeleteBombaModel model)
        {
            await _service.DeletarBombaAsync(model);
            return Ok();
        }


        [HttpDelete("deletar-tema")]
        public async Task<IActionResult> DeletarTema([FromBody] DeleteTemaModel model)
        {
            await _service.DeletarTemaAsync(model);
            return Ok();
        }

        [HttpDelete("deletar-usuario")]
        public async Task<IActionResult> DeletarUsuario([FromBody] DeleteUsuarioModel model)
        {
            await _service.DeletarUsuarioAsync(model);
            return Ok();
        }

        [HttpDelete("usar-bomba")]
        public async Task<IActionResult> UsarBomba([FromBody] UsarBombaModel model)
        {
            try
            {
                await _service.UsarBombaAsync(model);
                return Ok();
            }
            catch (PostgrestException ex)
            {
                return BadRequest(new { erro = ex.Message });
            }
        }
    }
}
