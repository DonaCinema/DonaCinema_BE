﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonaCinema.BusinessObject.Models.Auth
{
    public class AuthResponse
    {
        public bool IsSucceed { get; set; }
        public string? Token { get; set; }
        public string? Role { get; set; }
        public string? UserId { get; set; }
        public string? Email { get; set; }
    }
}
