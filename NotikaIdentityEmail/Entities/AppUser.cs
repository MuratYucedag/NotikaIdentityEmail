﻿using Microsoft.AspNetCore.Identity;

namespace NotikaIdentityEmail.Entities
{
    public class AppUser : IdentityUser
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string? ImageUrl { get; set; }
        public string? City { get; set; }
        public int? ActivationCode { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
