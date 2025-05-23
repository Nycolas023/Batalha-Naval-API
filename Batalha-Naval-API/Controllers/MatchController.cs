using Batalha_Naval_API.DTOs;
using Batalha_Naval_API.Services;
using Microsoft.AspNetCore.Mvc;

namespace Batalha_Naval_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MatchController : ControllerBase
    {
        //private readonly MatchService _matchService;

        //public MatchController(MatchService matchService)
        //{
        //    _matchService = matchService;
        //}

        //[HttpPost]
        //public async Task<IActionResult> CriarPartida([FromBody] MatchCreateDTO dto)
        //{
        //    var resultado = await _matchService.CriarPartidaAsync(dto);

        //    if (resultado.Contains("sucesso"))
        //        return Ok(resultado);

        //    return BadRequest(resultado);
        //}

        ///// <summary>
        ///// Retorna o histórico de partidas de um jogador
        ///// </summary>
        //[HttpGet("user/{id}")]
        //public async Task<IActionResult> BuscarPorUsuario(int id)
        //{
        //    var partidas = await _matchService.BuscarPartidasPorUsuarioAsync(id);

        //    if (partidas == null || partidas.Count == 0)
        //        return NotFound("Nenhuma partida encontrada para o jogador.");

        //    return Ok(partidas);
        //}
    }
}
