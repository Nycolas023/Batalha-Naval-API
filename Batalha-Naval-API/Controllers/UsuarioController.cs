//using Microsoft.AspNetCore.Mvc;
//using Batalha_Naval_API.Services;
//using Batalha_Naval_API.DTOs;

//namespace Batalha_Naval_API.Controllers
//{
//    [ApiController]
//    [Route("api/[controller]")]
//    public class UsuarioController : ControllerBase
//    {
//        private readonly UsuarioService _usuarioService;

//        public UsuarioController(UsuarioService usuarioService)
//        {
//            _usuarioService = usuarioService;
//        }

//        // POST: api/usuario
//        [HttpPost]
//        public async Task<ActionResult<UsuarioResponseDTO>> CriarUsuario([FromBody] UsuarioCreateDTO dto)
//        {
//            var usuario = await _usuarioService.CriarUsuarioAsync(dto);

//            if (usuario == null)
//                return BadRequest("Erro ao criar usuário.");

//            return Ok("Usuario cadastrado com sucesso!");
//        }

//        [HttpDelete("{id}")]
//        public async Task<IActionResult> Excluir(int id)
//        {
//            var sucesso = await _usuarioService.ExcluirUsuarioAsync(id);

//            if (!sucesso)
//                return NotFound("Usuário não encontrado ou erro ao excluir.");

//            return Ok("Usuário excluído com sucesso.");
//        }


//        // POST: api/usuario/login
//        [HttpPost("login")]
//        public async Task<ActionResult<UsuarioResponseDTO>> Login([FromBody] UsuarioLoginDTO dto)
//        {
//            var usuario = await _usuarioService.Login(dto);

//            if (usuario == null)
//                return Unauthorized("Login ou senha inválidos.");

//            return Ok(usuario);
//        }
//    }
//}
