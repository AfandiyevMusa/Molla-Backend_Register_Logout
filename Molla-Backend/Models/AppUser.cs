using System;
using Microsoft.AspNetCore.Identity;

namespace Molla_Backend.Models
{
	public class AppUser : IdentityUser
    {
        public string FullName { get; set; }
    }
}

