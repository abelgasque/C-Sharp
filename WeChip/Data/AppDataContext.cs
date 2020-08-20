using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeChip.Models;

namespace WeChip.Data
{
    public class AppDataContext : DbContext
    {
        public AppDataContext(DbContextOptions<AppDataContext> options) : base(options)
        { }

        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Status> Status { get; set; }

        public DbSet<Produto> Produtos { get; set; }

        public DbSet<Oferta> Ofertas { get; set; }
    }
}
