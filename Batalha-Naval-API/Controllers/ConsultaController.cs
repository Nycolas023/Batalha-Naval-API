using System.Text.Json.Serialization;
using Batalha_Naval_API.DTOs;
using Batalha_Naval_API.Models.SelectModels;
using Batalha_Naval_API.Services;
using Microsoft.AspNetCore.Mvc;

namespace Batalha_Naval_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ConsultaController : ControllerBase
    {
        private readonly ConsultaService _procService;

        public ConsultaController(ConsultaService procService)
        {
            _procService = procService;
        }

        [HttpGet("todosTemas")]
        public async Task<ActionResult<ThemeModel>> RetornaTodosTemas()
        {
            var tema = await _procService.RetornaTodosTemasAsync();
            if (tema == null) return NotFound();
            return Ok(tema);
        }

        [HttpGet("todosBarcos")]
        public async Task<ActionResult<ShipModel>> RetornaTodosBarcos()
        {
            var ship = await _procService.RetornaTodosBarcosAsync();
            if (ship == null) return NotFound();
            return Ok(ship);
        }

        [HttpGet("todasBombas")]
        public async Task<ActionResult<BombModel>> RetornaTodasBombas()
        {
            var bomb = await _procService.RetornaTodasBombasAsync();
            if (bomb == null) return NotFound();
            return Ok(bomb);
        }
        [HttpGet("todosUsuarios")]
        public async Task<ActionResult<UserModel>> RetornaTodosUsuarios()
        {
            var user = await _procService.RetornaTodosUsuariosAsync();
            if (user == null) return NotFound();
            return Ok(user);
        }

        [HttpGet("barco/{id}")]
        public async Task<ActionResult<ShipModel>> RetornaBarco(int id)
        {
            var barco = await _procService.RetornaBarcoAsync(id);
            if (barco == null) return NotFound();
            return Ok(barco);
        }

        [HttpGet("bomba/{id}")]
        public async Task<ActionResult<BombModel>> RetornaBomba(int id)
        {
            var bomba = await _procService.RetornaBombaAsync(id);
            if (bomba == null) return NotFound();
            return Ok(bomba);
        }

        [HttpGet("tema/{id}")]
        public async Task<ActionResult<ThemeModel>> RetornaTema(int id)
        {
            var tema = await _procService.RetornaTemaAsync(id);
            if (tema == null) return NotFound();
            return Ok(tema);
        }

        [HttpPost("usuario")]
        public async Task<ActionResult<UserModel>> RetornaUsuario([FromBody] LoginDTO login)
        {
            var usuario = await _procService.RetornaUsuarioAsync(login);
            if (usuario == null) return Unauthorized();
            return Ok(usuario);
        }

        [HttpPost("temaFoiComprado")]
        public async Task<ActionResult<ThemeQuantityModel>> RetornaTemaComprado([FromBody] TemaCompradoDTO temaComprado)
        {
            var tema = await _procService.RetornaTemaCompradoAsync(temaComprado);
            if (tema == null) return Unauthorized();
            return Ok(tema);
        }


        //[HttpPost("login")]
        //public async Task<ActionResult<UserModel>> Login([FromBody] LoginDTO dto)
        //{
        //    var usuario = await _procService.Login(dto);

        //    if (usuario == null)
        //        return Unauthorized("Login ou senha inválidos.");

        //    return Ok(usuario);
        //}
    }
}
