using System.Collections.Generic;
using UsuarioApi.Models;
using UsuarioApi.Data;

namespace UsuarioApi.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly DataContext _context;
        public UsuarioRepository(DataContext ctx)
        {
            _context = ctx;
        }

        public void Add(Usuario usuario)
        {
            
        }
        public IEnumerable<Usuario> GetAll()
        {
            return null;
        }
        public Usuario Find(long id)
        {
            return null;
        }
        public void Remove(long id)
        {

        }
        public void Update(Usuario usuario)
        {

        }

    }
}