using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BasicRegisters.Admin.Models
{
    public class Conta
    {
        [Required]
        [MaxLength(20)]
        [DisplayName("Apelido")]
        public string ApelidoDaConta { get; set; }

        public bool Ativa { get; set; }
        public string CNPJ { get; set; }
        public string CPF { get; set; }

        [Required]
        [DisplayName("Email usuário")]
        public string EmailParaUsuarioAdministrador { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid Id { get; set; }

        [MaxLength(80)]
        public string Nome { get; set; }

        [Required]
        [MaxLength(80)]
        [DisplayName("Nome da conta")]
        public string NomeDaConta { get; set; }

        [Required]
        public string SenhaParaUsuarioAdministrador { get; set; }
    }
}