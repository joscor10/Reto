using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reto.Models
{
    public class SolicitudxCliente
    {
        public IEnumerable<Solicitud> solicitudes { get; set; }
        public Cliente Cliente { get; set; }
    }
}
