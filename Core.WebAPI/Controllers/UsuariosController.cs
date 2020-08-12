using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Core.WebAPI.Models;

namespace Core.WebAPI.Controllers
{
    
    [ApiController]
    [Route("api/[controller]")]

    public class UsuariosController : Controller
    {
        private readonly AppDataContext _context;

        public UsuariosController(AppDataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Usuario>> Get()
        {
            return _context.Usuarios.ToList();
        }
    }
}
