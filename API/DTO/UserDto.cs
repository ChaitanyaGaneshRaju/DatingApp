using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.DTO
{
    public class UserDto
    {
        public string Username { get; set; } = null!;
        public string Token { get; set; } = null!;
        public string PhotoUrl { get; set; } = null!;
        public string KnownAs { get; set; } = null!;

        
    }
}