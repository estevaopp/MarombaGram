using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;


namespace UserApi.Models
{
    public class CustomIdentityUser : IdentityUser<int>
    {
        public DateTime? BirthDay { get; set; }
        public override string? NormalizedEmail => Email.ToLower();
        public override string? NormalizedUserName => UserName.ToLower();
    }
}