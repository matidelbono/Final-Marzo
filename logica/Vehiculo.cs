using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica
{
    public abstract class Vehiculo
    {
        public int codigo { get; set; }
        public int CapacidadTanque { get; set; }
        public int AnioFabricacion { get; set; }
        public string Color { get; set; }
        public abstract string ObtenerDescripcionVehiculos();
    }
}

