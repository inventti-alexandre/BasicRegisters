using BasicRegisters.Application.Services.LoginServices.Dtos;
using BasicRegisters.Application.Services.UserServices;
using BasicRegisters.Application.Services.UserServices.Dtos;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Principal;

namespace BasicRegisters.Application.Services.LoginServices
{
    public class LoginServices : ILoginServices
    {
        private readonly IUsuarioServices _usuarioServices;

        public LoginServices(UsuarioServices usuarioServices)
        {
            _usuarioServices = usuarioServices;
        }

        public AutenticacaoDoLogin FazerLogin(LoginDto loginDto)
        {
            bool credenciaisValidas = false;

            if (loginDto != null && !String.IsNullOrWhiteSpace(loginDto.Login))
            {
                var usuarioBase = _usuarioServices.Find(loginDto.Login);
                credenciaisValidas = (usuarioBase.Id != Guid.Empty &&
                    loginDto.Login == usuarioBase.Apelido &&
                    loginDto.Senha == usuarioBase.Senha);
            }

            if (credenciaisValidas)
            {
                var tokenConfigurations = new TokenConfigurations();
                var signingConfigurations = new SigningConfigurations();

                ClaimsIdentity identity = new ClaimsIdentity(
                    new GenericIdentity(loginDto.Login, "Login"),
                    new[] {
                        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString("N")),
                        new Claim(JwtRegisteredClaimNames.UniqueName, loginDto.Login)
                    }
                );

                DateTime dataCriacao = DateTime.Now;
                DateTime dataExpiracao = dataCriacao.AddHours(4);

                var handler = new JwtSecurityTokenHandler();
                var securityToken = handler.CreateToken(new SecurityTokenDescriptor
                {
                    Issuer = tokenConfigurations.Issuer,
                    Audience = tokenConfigurations.Audience,
                    SigningCredentials = signingConfigurations.SigningCredentials,
                    Subject = identity,
                    NotBefore = dataCriacao,
                    Expires = dataExpiracao
                });
                var token = handler.WriteToken(securityToken);

                return new AutenticacaoDoLogin
                {
                    Autenticado = true,
                    DataDeCriacao = dataCriacao.ToString("yyyy-MM-dd HH:mm:ss"),
                    DataDeExpiracao = dataExpiracao.ToString("yyyy-MM-dd HH:mm:ss"),
                    TokenDeAcesso = token,
                    Mensagem = "OK"
                };
            }
            else
            {
                return new AutenticacaoDoLogin
                {
                    Autenticado = false,
                    Mensagem = "Falha ao autenticar"
                };
            }
        }
    }
}