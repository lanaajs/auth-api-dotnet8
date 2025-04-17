using API_Authentication.Models;
using API_Authentication.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_Authentication.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class AuthController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly TokenService _tokenService;

        public AuthController(AppDbContext context, TokenService tokenService)
        {
            _context = context;
            _tokenService = tokenService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest request)
        {
            try
            {
                // Verifica se o usuário existe
                var user = await _context.Users.FirstOrDefaultAsync(u => u.Email == request.Email);

                if (user == null)
                {
                    Console.WriteLine("Usuário não encontrado no banco.");
                    return BadRequest(new { message = "Usuário ou senha inválidos." });
                }

                // Gera tokens e retorna
                var tokens = _tokenService.GenerateTokens(user);
                return Ok(tokens);
            }
            catch (Exception ex)
            {
                // Logar o erro real em produção
                return StatusCode(500, new { message = "Erro interno no servidor.", error = ex.Message });
            }
        }
    }
}
