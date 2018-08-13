namespace BasicRegisters.Application.Services.LoginServices.Dtos
{
    public class AutenticacaoDoLogin
    {
        public bool Autenticado { get; set; }
        public string DataDeCriacao { get; set; }
        public string DataDeExpiracao { get; set; }
        public string Mensagem { get; set; }
        public string TokenDeAcesso { get; set; }
    }
}