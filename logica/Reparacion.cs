using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica
{
    public class Reparacion
    {
        public int CodigoReparacion { get; set; }
        public DateTime FechaReparacion { get; set; }
        public string TipoTrabajo { get; set; }
        public int CodigoCliente { get; set; }
        public int CodigoVehiculo { get; set; }
        public decimal CostoTrabajo { get; set; }
    }
}
