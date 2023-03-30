using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace ApiProdutos.Services.Authentication
{
    /// <summary>
    /// Classe para geração dos TOKENS JWT
    /// </summary>
    public class JwtTokenService
    {
        /// <summary>
        /// chave secreta para geração dos tokens
        /// </summary>
        public static string SecretKey => "fa97e4a5-5e9b-462d-8c71-6e5bceb38e7f";

        /// <summary>
        /// Tempo para expiração do TOKEN em horas
        /// </summary>
        public static int ExpirationInHours => 6;

        /// <summary>
        /// Método para gerar e retornar o token do usuário
        /// </summary>
        /// <returns></returns>
        public static string GenerateToken(string login)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.UTF8.GetBytes(SecretKey);

            var descriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[] { new Claim(ClaimTypes.Name, login) }),
                Expires = DateTime.UtcNow.AddHours(ExpirationInHours),
                SigningCredentials = new  SigningCredentials
                (new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(descriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
