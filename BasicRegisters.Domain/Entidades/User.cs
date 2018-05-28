using System;
using System.ComponentModel.DataAnnotations;

namespace BasicRegisters.Domain.Domain
{
    public class User
    {
        [Key]
        public string UserID { get; set; }
        public string  AccessKey { get; set; }
    }
}