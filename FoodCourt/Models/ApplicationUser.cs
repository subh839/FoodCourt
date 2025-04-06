﻿using Microsoft.AspNetCore.Identity;

namespace FoodCourt.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ICollection<Order> Orders { get; set; }

    }
}
