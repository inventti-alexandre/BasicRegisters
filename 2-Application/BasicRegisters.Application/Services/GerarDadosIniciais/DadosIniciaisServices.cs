using AutoMapper;
using BasicRegisters.Application.Services.GerarDadosIniciais.Dtos;
using EFGetStarted.AspNetCore.NewDb.Models;

namespace BasicRegisters.Application.Services.GerarDadosIniciais
{
    public class DadosIniciaisServices : IDadosIniciaisServices
    {
        private readonly BasicRegistersContext _context;
        private readonly IMapper _mapper;

        public DadosIniciaisServices(BasicRegistersContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public DadosIniciaisDto GerarDadosIniciais(DadosIniciaisDto dadosIniciaisDto)
        {
            //var conta = new ContaBuilder();
            //var usuario = new UsuarioBuilder();

            return new DadosIniciaisDto();
        }
    }
}