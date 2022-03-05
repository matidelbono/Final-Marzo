using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica
{
    class Marca
    {
        public int CodigoMarca { get; set; }
        public string Descripcion { get; set; }
        public Marca( string Descripcion)
        {
            this.Descripcion = Descripcion;
        }
}
}

