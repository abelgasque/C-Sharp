using Core.WebAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.WebAPI.Models
{
    public class AppDataContext : DbContext
    {

        public AppDataContext(DbContextOptions options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }

    }
}
