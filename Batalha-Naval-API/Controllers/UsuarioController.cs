using Microsoft.AspNetCore.Mvc;
using Batalha_Naval_API.Interfaces;
using Batalha_Naval_API.Model;
using Batalha_Naval_API.Services;
using System.Threading.Tasks;

namespace Batalha_Naval_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuario _usuarioService;

        public UsuarioController(IUsuario usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpPost(Name = "CadastraUsuario")]
        public async Task<IActionResult> CadastraUsuario([FromBody] UsuarioModel usuario) 
        {
            //object value = await _usuarioService.AdicionaUsuario(usuario);
            return Ok(usuario);
        }

    }
}
