using API_Authentication.Models;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace API_Authentication.Services
{
    public class TokenService
    {
        private readonly IConfiguration _config;

        public TokenService(IConfiguration config)
        {
            _config = config;
        }

        public TokenResponse GenerateTokens(User user)
        {
            // Recupera a chave do appsettings.json
            var jwtKey = _config["Jwt:Key"];
            if (string.IsNullOrEmpty(jwtKey))
                throw new InvalidOperationException("A chave JWT (Jwt:Key) não está configurada.");

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtKey));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            // Claims do token
            var claims = new[]
            {
                new Claim("userId", user.Id.ToString()),
                new Claim("id", user.Id?.ToString() ?? string.Empty),
                new Claim("role", user.Role ?? string.Empty),
                new Claim("tenantId", user.TenantId ?? string.Empty),
                new Claim("languageId", user.LanguageId ?? string.Empty),
                new Claim("name", $"{user.FirstName} {user.LastName}")
            };

            // Gera access token
            var accessToken = new JwtSecurityToken(
                issuer: _config["Jwt:Issuer"],
                audience: _config["Jwt:Audience"],
                claims: claims,
                expires: DateTime.UtcNow.AddMinutes(6),
                signingCredentials: creds
            );

            // Gera refresh token
            var refreshToken = new JwtSecurityToken(
                issuer: _config["Jwt:Issuer"],
                audience: _config["Jwt:Audience"],
                claims: claims,
                expires: DateTime.UtcNow.AddHours(1),
                signingCredentials: creds
            );

            return new TokenResponse
            {
                AccessToken = new JwtSecurityTokenHandler().WriteToken(accessToken),
                RefreshToken = new JwtSecurityTokenHandler().WriteToken(refreshToken)
            };
        }
    }
}
