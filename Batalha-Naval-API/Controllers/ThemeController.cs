//using Batalha_Naval_API.DTOs;
//using Batalha_Naval_API.Services;
//using Microsoft.AspNetCore.Mvc;

//namespace Batalha_Naval_API.Controllers
//{
//    //[ApiController]
//    //[Route("api/[controller]")]
//    public class ThemeController : ControllerBase
//    {
//        private readonly ThemeService _themeService;

//        public ThemeController(ThemeService themeService)
//        {
//            _themeService = themeService;
//        }

//        /// <summary>
//        /// Cadastra um novo tema no Supabase.
//        /// </summary>
//        [HttpPost]
//        public async Task<IActionResult> Criar([FromBody] ThemeCreateDTO dto)
//        {
//            var sucesso = await _themeService.CriarAsync(dto);

//            if (!sucesso)
//                return BadRequest("Erro ao cadastrar tema.");

//            return Ok("Tema cadastrado com sucesso.");
//        }

//        /// <summary>
//        /// Lista todos os temas cadastrados.
//        /// </summary>
//        [HttpGet]
//        public async Task<ActionResult<List<ThemeResponseDTO>>> BuscarTodos()
//        {
//            var temas = await _themeService.BuscarTodosAsync();

//            if (temas == null || temas.Count == 0)
//                return NotFound("Nenhum tema encontrado.");

//            return Ok(temas);
//        }
//    }
//}
