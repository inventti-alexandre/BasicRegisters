namespace BasicRegisters.Domain.Entidades.Interfaces
{
    internal interface IUsuario : IBaseEntidade
    {
        string Apelido { get; set; }
        string Email { get; set; }
        string Senha { get; set; }
    }
}