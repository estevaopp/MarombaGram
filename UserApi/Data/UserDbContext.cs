using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using UserApi.Models;

namespace UserApi.Data
{
    public class UserDbContext : IdentityDbContext<CustomIdentityUser, CustomIdentityRole,int>
    {
        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<CustomIdentityRole>().HasIndex(u => u.Name).IsUnique();
            builder.Entity<CustomIdentityUser>().HasIndex(u => u.UserName).IsUnique();
            builder.Entity<CustomIdentityUser>().HasIndex(u => u.Email).IsUnique();
        }


    }
}