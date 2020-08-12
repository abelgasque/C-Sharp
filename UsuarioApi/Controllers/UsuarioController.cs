using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UsuarioApi.Data;
using UsuarioApi.Models;

namespace UsuarioApi.Controllers
{
    [ApiController]
    [Route("usuarios")]

    public class UsuarioController : ControllerBase{

        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Usuario>>> Get([FromServices] DataContext context)
        {
            var usuarios = await context.Usuarios.ToListAsync();
            return usuarios;
        }


        [HttpPost]
        [Route("")]
        public async Task<ActionResult<Usuario>> Post(
            [FromServices] DataContext context,
            [FromBody] Usuario model)
        {
            if(ModelState.IsValid)
            {
                context.Usuarios.Add(model);
                await context.SaveChangesAsync();
                return model;
            }else
            {
                return BadRequest(ModelState);
            }
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult<Usuario>> GetById(
            [FromServices] DataContext context, int id)
        {
            var usuario = await context.Usuarios.FirstOrDefaultAsync(u => u.Id == id);
            return usuario;
        }
    }
}