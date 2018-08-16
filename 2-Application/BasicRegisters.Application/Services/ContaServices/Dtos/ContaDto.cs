using BasicRegisters.Application.Services.UserServices.Dtos;
using System;

namespace BasicRegisters.Application.Services.ContaServices.Dtos
{
    public class ContaDto
    {
        public string Apelido { get; set; }

        public bool Ativo { get; set; }

        public DateTime DataDeCadastro { get; set; }

        public DateTime? DataDeExclusao { get; set; }

        public bool? Excluido { get; set; }

        public Guid Id { get; set; }

        public string Nome { get; set; }

        public UsuarioDto UsuarioDeCadastro { get; set; }

        public Guid? UsuarioDeCadastroId { get; set; }

        public UsuarioDto UsuarioDeExlusao { get; set; }

        public Guid? UsuarioDeExlusaoId { get; set; }
    }
}