﻿using System.ComponentModel.DataAnnotations;

namespace DAppAPI.DTO
{
    public class RegisterDto
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
