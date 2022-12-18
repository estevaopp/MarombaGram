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
    public class UserDbContext : IdentityDbContext<User, Role,int>
    {
        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Role>().HasIndex(u => u.Name).IsUnique();
            builder.Entity<User>().HasIndex(u => u.UserName).IsUnique();
            builder.Entity<User>().HasIndex(u => u.Email).IsUnique();
        }


    }
}