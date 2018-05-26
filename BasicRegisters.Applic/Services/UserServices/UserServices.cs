using BasicRegisters.Domain.Domain;
using EFGetStarted.AspNetCore.NewDb.Models;
using System.Linq;

namespace BasicRegisters.Application.Services.UserServices.Dtos
{
    public class UserServices
    {
        private BasicRegistersContext _context;

        public UserServices(BasicRegistersContext context)
        {
            _context = context;
        }
            
        public User Find(string userID)
        {
            return _context.Users
                .FirstOrDefault(c => c.UserID == userID);
        }

    }
}