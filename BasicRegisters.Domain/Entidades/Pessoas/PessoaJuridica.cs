﻿using BasicRegisters.Domain.Domain;
using BasicRegisters.Domain.Entidades.Interfaces;
using BasicRegisters.Domain.Entidades.Pessoas;
using BasicRegisters.Domain.Telefones;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BasicRegisters.Domain.Entidades
{
    public class PessoaJuridica : IPessoaJuridica
    {
        public bool Ativo { get; set; }
        public string Cnpj { get; set; }
        public DateTime DataDeCadastro { get; set; }
        public DateTime? DataDeExclusao { get; set; }
        public bool? Excluido { get; set; }

        [Key]
        public Guid Id { get; set; }

        public string InscricaoEstadual { get; set; }
        public string Nome { get; set; }
        public string NomeFantasia { get; set; }
        public List<Telefone> Telefones { get; set; }
        public Usuario UsuarioDeCadastro { get; set; }
        public Guid? UsuarioDeCadastroId { get; set; }
        public Usuario UsuarioDeExlusao { get; set; }
        public Guid? UsuarioDeExlusaoId { get; set; }

        public Pessoa SetAtivo(bool ativo)
        {
            throw new NotImplementedException();
        }

        public Pessoa SetDataDeCadastro(DateTime dataDeCadastro)
        {
            throw new NotImplementedException();
        }

        public Pessoa SetDataDeExclusao(DateTime? dataDeExclusao)
        {
            throw new NotImplementedException();
        }

        public Pessoa SetExcluido(bool? excluido)
        {
            throw new NotImplementedException();
        }

        public Pessoa SetId(Guid id)
        {
            throw new NotImplementedException();
        }

        public Pessoa SetUsuarioDeCadastro(Usuario usuarioDeCadastro)
        {
            throw new NotImplementedException();
        }

        public Pessoa SetUsuarioDeExlusao(Usuario usuarioDeExlusao)
        {
            throw new NotImplementedException();
        }
    }
}