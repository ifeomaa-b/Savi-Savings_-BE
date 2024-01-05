﻿using Microsoft.AspNetCore.Identity;
using Savi.Model.Enums;

namespace Savi.Model.Entities
{
    public class AppUser : IdentityUser
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
        public bool IsDeleted { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime ModifiedAt { get; set; } = DateTime.UtcNow;
     
        public ICollection<Saving> Savings { get; set; }
        public ICollection<CardDetail> CardDetails { get; set; }
        public ICollection<AppUserTransaction> AppUserTransactions { get; set; }
        public ICollection<Group> Groups { get; set; }
        public ICollection<GroupTransaction> GroupTransactions { get; set; }
    }
}
