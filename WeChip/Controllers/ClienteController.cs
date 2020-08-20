using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WeChip.Data;
using WeChip.Models;
using System.Web.Http.Cors;

namespace WeChip.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Cliente>>> Get([FromServices] AppDataContext context)
        {
            var lista = await context.Clientes.ToListAsync();
            return lista;
        }


        [HttpPost]
        [Route("")]
        public async Task<ActionResult<Cliente>> Post(
            [FromServices] AppDataContext context,
            [FromBody] Cliente model)
        {
            if (ModelState.IsValid)
            {
                context.Clientes.Add(model);
                await context.SaveChangesAsync();
                return model;
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult<Cliente>> GetById(
            [FromServices] AppDataContext context, int id)
        {
            var usuario = await context.Clientes.FirstOrDefaultAsync(u => u.Id == id);
            return usuario;
        }
    }
}
