using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reto.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public int Identificacion { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public  Sbs Sbs { get; set; }
        public Sentinel Sentinel { get; set; }
        public AI AI { get; set; }
        public List<Solicitud> Solicitudes { get; set; }

    }
}
