using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;


namespace UserApi.Models
{
    public class Role : IdentityRole<int>
    {
        public override string? NormalizedName => Name.ToLower();
    }
}