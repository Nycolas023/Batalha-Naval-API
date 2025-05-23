//using Batalha_Naval_API.DTOs;
//using Batalha_Naval_API.Services;
//using Microsoft.AspNetCore.Mvc;

//namespace Batalha_Naval_API.Controllers
//{
//    //[ApiController]
//    //[Route("api/[controller]")]
//    public class BombController : ControllerBase
//    {
//        private readonly BombService _bombService;

//        public BombController(BombService bombService)
//        {
//            _bombService = bombService;
//        }

//        [HttpGet]
//        public async Task<ActionResult<List<BombResponseDTO>>> BuscarBombas()
//        {
//            var bombas = await _bombService.BuscarTodasAsync();
//            return Ok(bombas);
//        }

//        [HttpPost]
//        public async Task<IActionResult> CriarBomba([FromBody] BombCreateDTO dto)
//        {
//            var sucesso = await _bombService.CriarAsync(dto);
//            if (!sucesso)
//                return BadRequest("Erro ao cadastrar bomba.");

//            return Ok(new { mensagem = "Bomba cadastrada com sucesso!" });
//        }

//        /// <summary>
//        /// Retorna o inventário de bombas de um jogador
//        /// </summary>
//        [HttpGet("inventario/{userId}")]
//        public async Task<ActionResult<List<BombInventarioDTO>>> ObterInventario(int userId)
//        {
//            var inventario = await _bombService.ListarInventarioAsync(userId);
//            return Ok(inventario);
//        }

//        /// <summary>
//        /// Compra uma bomba (desconta saldo e incrementa inventário)
//        /// </summary>
//        [HttpPost("comprar")]
//        public async Task<IActionResult> ComprarBomba([FromBody] BombCompraDTO dto)
//        {
//            var resultado = await _bombService.ComprarAsync(dto);
//            if (resultado == null)
//                return BadRequest("Erro ao comprar bomba (saldo insuficiente ou falha no servidor).");

//            return Ok(new { mensagem = resultado });
//        }



//    }
//}
