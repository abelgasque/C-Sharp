using System.Collections.Generic;
using UsuarioApi.Models;

namespace UsuarioApi.Repository
{
    public interface IUsuarioRepository
    {
        void Add(Usuario usuario);
        IEnumerable<Usuario> GetAll();
        Usuario Find(long id);
        void Remove(long id);
        void Update(Usuario usuario);
    }


}