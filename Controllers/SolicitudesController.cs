using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Reto.Data;
using Reto.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Reto.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SolicitudesController : ControllerBase
    {
        private readonly PrestamoContexto _context;

        public SolicitudesController(PrestamoContexto context)
        {
            _context = context;
        }
        // GET: api/Solicitudes
        [HttpGet]
        public IEnumerable<object> Get()
        {
            return _context.Clientes.Include(x=>x.Sbs).Include(x=>x.Sentinel).Include(x=>x.AI)
               .Select(x => new { Cliente = x, Solicitudes = x.Solicitudes.Where(e => e.Tipo == "Personal").Where(e=>e.Monto<=50).Where(e=>e.Estado=="Pendiente").ToList() }).ToList();
        }

        // GET api/<SolicitudesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<SolicitudesController>
        [HttpPost]
        public void Post(Solicitud solicitud)
        {
            _context.Solicitudes.Add(solicitud);
             _context.SaveChanges();
          
        }

        // PUT api/Solicitudes/5/Pendiente
        [HttpPut("{id}/{estado}")]
        public void SolicitudesAprobar(int id,string estado)
        {
            Solicitud solicitud = _context.Solicitudes.Find(id);
            solicitud.Estado = estado;
            _context.Entry(solicitud).State = EntityState.Modified;           
            _context.SaveChanges();
           
        }       

        // DELETE api/<SolicitudesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Solicitud solicitud = _context.Solicitudes.Find(id);
            _context.Solicitudes.Remove(solicitud);
            _context.SaveChanges();
        }
    }
}
