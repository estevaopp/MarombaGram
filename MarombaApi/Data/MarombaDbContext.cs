using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MarombaApi.Data
{
    public class MarombaDbContext : DbContext
    {
        public MarombaDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}