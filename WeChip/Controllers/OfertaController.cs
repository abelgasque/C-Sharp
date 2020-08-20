using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WeChip.Data;
using WeChip.Models;

namespace WeChip.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OfertaController : ControllerBase
    {
        /* 
         [HttpGet]
         [Route("")]
         public async Task<ActionResult<List<Oferta>>> Get([FromServices] AppDataContext context)
         {
             var lista = await context.Ofertas.Include(x => x.Produto).ToListAsync();
             return lista;
         }

         [HttpGet]
         [Route("{id: long}")]
         public async Task<ActionResult<Oferta>> GetById(
             [FromServices] AppDataContext context, long id)
         {
             var oferta = await context.Ofertas
                 .AsNoTracking()
                 .Include(x => x.Produto).FirstOrDefaultAsync(x => x.Id == id);
             return oferta;
         }

         [HttpPost]
         [Route("")]
         public async Task<ActionResult<Oferta>> Post(
             [FromServices] AppDataContext context,
             [FromBody] Oferta model)
         {
             if (ModelState.IsValid)
             {
                 context.Ofertas.Add(model);
                 await context.SaveChangesAsync();
                 return model;
             }
             else
             {
                 return BadRequest(ModelState);
             }
         }
        */
    }
}
