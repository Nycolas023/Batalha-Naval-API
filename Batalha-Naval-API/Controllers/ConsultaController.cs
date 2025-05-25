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
