using System;

namespace BasicRegisters.Application.Services.UserServices.Dtos
{
    public class UserDto
    {
        public string AccessKey { get; set; }
        public Guid Id { get; set; }
        public string UserID { get; set; }
    }
}