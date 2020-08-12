using Microsoft.EntityFrameworkCore;
using UsuarioApi.Models;

namespace UsuarioApi.Data{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options)
        {}

        public DbSet<Usuario> Usuarios { get; set; }
    }
}