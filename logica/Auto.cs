using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica
{
    public class Auto:Vehiculo
    {
       
        public int CantidadPuertas { get; set; }
        public DateTime FechaUltimaRevision { get; set; }
        public DateTime FechaUltimoCambioAceite { get; set; }
        public DateTime FechaVencimientoMatafuegos { get; set; }
        public string NombreMarca { get; set; }
        public override string ObtenerDescripcionVehiculos()
        {
           
            List<string> DescripcionAuto = new List<string>();
            string CodString = codigo.ToString();
            string AnioString = AnioFabricacion.ToString();
            string CantString = CantidadPuertas.ToString();
            DescripcionAuto.Add(CodString);
            DescripcionAuto.Add(AnioString);
            DescripcionAuto.Add(CantString);
            DescripcionAuto.Add(NombreMarca);
            string DescripcionAutoConcatenada = string.Join(",", DescripcionAuto.ToArray());
            return DescripcionAutoConcatenada;
    }
}
}

