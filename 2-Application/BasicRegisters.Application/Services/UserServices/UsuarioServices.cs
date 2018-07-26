using AutoMapper;
using BasicRegisters.Domain.Domain;
using EFGetStarted.AspNetCore.NewDb.Models;
using System;
using System.Linq;

namespace BasicRegisters.Application.Services.UserServices.Dtos
{
    public class UsuarioServices : IUsuarioServices
    {
        private readonly BasicRegistersContext _context;
        private readonly IMapper _mapper;

        public UsuarioServices(BasicRegistersContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public UsuarioDto Find(string userID)
        {
            var user = _context.Usuarios
                .FirstOrDefault(c => c.Apelido == userID);

            if (user == null) return new UsuarioDto();

            return _mapper.Map<Usuario, UsuarioDto>(user);
        }
    }
}