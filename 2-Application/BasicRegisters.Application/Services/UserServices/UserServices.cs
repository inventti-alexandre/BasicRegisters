using EFGetStarted.AspNetCore.NewDb.Models;
using System;
using System.Linq;

namespace BasicRegisters.Application.Services.UserServices.Dtos
{
    public class UserServices : IUserServices
    {
        private readonly BasicRegistersContext _context;

        public UserServices(BasicRegistersContext context)
        {
            _context = context;
        }

        public UserDto Find(string userID)
        {
            var user = _context.Users
                .FirstOrDefault(c => c.UserID == userID);

            if (user == null) return new UserDto { UserID = null, Id = Guid.Empty, AccessKey = null };

            return new UserDto { UserID = user.UserID, AccessKey = user.AccessKey, Id= user.Id };
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}