using System;

namespace BasicRegisters.Application.Services.UserServices.Dtos
{
    public class UsuarioDto
    {
        public string Apelido { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataDeCadastro { get; set; }
        public DateTime DataDeExclusao { get; set; }
        public string Email { get; set; }
        public bool Excluido { get; set; }
        public Guid Id { get; set; }
        public string Senha { get; set; }

        public Guid UsuarioDeCadastroId { get; set; }

        public Guid UsuarioDeExlusaoId { get; set; }
    }
}