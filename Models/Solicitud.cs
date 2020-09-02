using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reto.Models
{
    public class Solicitud
    {
        public int Id { get; set; }
        public decimal Monto { get; set; }
        public string Estado { get; set; }
        public string Tipo { get; set; }
        public int ClienteId { get; set; }
    }
}
