namespace BasicRegisters.Application.Services.LoginServices.Dtos
{
    public class TokenConfigurationsDto
    {
        public string Audience { get; set; }
        public string Issuer { get; set; }
        public int Seconds { get; set; }
    }
}
