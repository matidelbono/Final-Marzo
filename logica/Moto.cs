using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica
{
     class Moto:Vehiculo
    {
        public int Cilindrada { get; set; }
        public int CantidadMarchas { get; set; }
        public string NombreMarca { get; set; }
        public string TipoMoto { get; set; }
        public override string ObtenerDescripcionVehiculos()
        {
            List<string> DescripcionMoto = new List<string>();
            string Cmstring = codigo.ToString();
            string CilindradaString = Cilindrada.ToString();
            DescripcionMoto.Add(Cmstring);
            DescripcionMoto.Add(NombreMarca);
            DescripcionMoto.Add(CilindradaString);
            DescripcionMoto.Add(TipoMoto);
            string DescripcionMotoConcatenada = string.Join(",", DescripcionMoto.ToArray());
            return DescripcionMotoConcatenada;
        }
    }
}
