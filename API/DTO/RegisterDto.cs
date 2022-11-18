using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.DTO
{
    public class RegisterDto
    {
        [Required]
        public string Username { get; set; } = null!;
        [Required]
        public string KnownAs { get; set; } = null;
        [Required]
        public string Gender { get; set; } = null!;
        [Required]
        public DateTime DateOfBirth { get; set; }
        [Required]
        public string City { get; set; } = null;
        [Required]
        public String Country { get; set; } = null;
        
        [Required]
        [StringLength(8, MinimumLength =4)]
        public string Password { get; set; } = null!;
    }
}