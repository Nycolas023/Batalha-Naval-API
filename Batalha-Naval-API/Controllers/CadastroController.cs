using Batalha_Naval_API.Models.CreateModels;
using Batalha_Naval_API.Services;
using Microsoft.AspNetCore.Mvc;

namespace Batalha_Naval_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CadastroController : ControllerBase
    {
        private readonly CadastroService _procCreationService;

        public CadastroController(CadastroService procCreationService)
        {
            _procCreationService = procCreationService;
        }

        [HttpPost("usuario")]
        public async Task<IActionResult> CriarUsuario([FromBody] CreateUserModel model)
        {
            await _procCreationService.CriarUsuarioAsync(model);
            return Ok();
        }

        [HttpPost("barco")]
        public async Task<IActionResult> CriarBarco([FromBody] CreateShipModel model)
        {
            await _procCreationService.CriarBarcoAsync(model);
            return Ok();
        }

        [HttpPost("bomba")]
        public async Task<IActionResult> CriarBomba([FromBody] CreateBombModel model)
        {
            await _procCreationService.CriarBombaAsync(model);
            return Ok();
        }

        [HttpPost("tema")]
        public async Task<IActionResult> CriarTema([FromBody] CreateThemeModel model)
        {
            await _procCreationService.CriarTemaAsync(model);
            return Ok();
        }
    }
}
