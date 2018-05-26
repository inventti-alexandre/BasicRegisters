using BasicRegisters.Domain.Domain;
using EFGetStarted.AspNetCore.NewDb.Models;
using System.Linq;

namespace BasicRegisters.Application.Services.UserServices.Dtos
{
    public class UserServices
    {
        private readonly BasicRegistersContext _context;

        //public UserServices()
        public UserServices(BasicRegistersContext context)
        {
            _context = context;
        }
            
        public UserDto Find(string userID)
        {
            var user = _context.Users
                .FirstOrDefault(c => c.UserID == userID);

            return new UserDto { UserID = user.UserID, AccessKey = user.AccessKey };
            //return new UserDto { UserID = "123", AccessKey = "123" };
        }

    }
}