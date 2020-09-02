using Microsoft.EntityFrameworkCore;
using Reto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reto.Data
{
    public class PrestamoContexto: DbContext
    {
        public PrestamoContexto(DbContextOptions<PrestamoContexto> options):base(options)
        {

        }

        public DbSet<Sbs> Sbs { get; set; }
        public DbSet<Sentinel> Sentinels { get; set; }
        public DbSet<AI> AI { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Solicitud> Solicitudes { get; set; }


    }
}
