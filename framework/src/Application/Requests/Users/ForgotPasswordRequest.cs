﻿using System.ComponentModel.DataAnnotations;

namespace CoreBoilerplate.Application.Requests.Users
{
    public class ForgotPasswordRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}