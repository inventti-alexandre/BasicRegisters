using BasicRegisters.Domain.Domain;
using System;

namespace BasicRegisters.Domain.Entidades.Contas
{
    public interface IConta
    {
        string Apelido { get; }
        bool Ativo { get; }
        DateTime DataDeCadastro { get; }
        DateTime? DataDeExclusao { get; }
        bool? Excluido { get; }
        Guid Id { get; }
        string Nome { get; }

        Usuario UsuarioDeExlusao { get; }

        Guid? UsuarioDeExlusaoId { get; }

        Conta SetApelido(string apelido);

        Conta SetAtivo(bool ativo);

        Conta SetDataDeCadastro(DateTime dataDeCadastro);

        Conta SetDataDeExclusao(DateTime? dataDeExclusao);

        Conta SetExcluido(bool? excluido);

        Conta SetId(Guid id);

        Conta SetNome(string nome);

        Conta SetUsuarioDeExlusao(Usuario usuarioDeExlusao);
    }
}