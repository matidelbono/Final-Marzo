using System;
using logica;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica
{
    public class Principal
    {
        public List<Reparacion> Reparaciones = new List<Reparacion>();
        public List<Vehiculo> vehiculos = new List<Vehiculo>();
        public List<Auto> autos = new List<Auto>();
        public bool ActualizarFechayCosto(int CodigoVehiculo, string TipoTrabajo)
        {
            foreach (var item in autos)
            {
                foreach (var reparacion in Reparaciones)
                {
                    if ( reparacion.TipoTrabajo=="Revision tecnica")
                    {
                        item.FechaUltimaRevision =DateTime.Today;
                    }
                    else
                    {
                        if (reparacion.TipoTrabajo=="Cambio aceite")
                        {
                            item.FechaUltimoCambioAceite = DateTime.Today;
                        }
                    }
                    return true;
                }
            }
            return false;
        }
        public List<ControlesVencidos> ReportarControlesVencidos()
        {
            Auto aut = new Auto();
            List<ControlesVencidos> ReporteAutosControlesVencidos = new List<ControlesVencidos>();
            foreach (var item in autos)
            {
                if (item.FechaVencimientoMatafuegos<DateTime.Today & DateTime.Today.Year-item.FechaUltimaRevision.Year>=1 )
                {
                    ControlesVencidos autoconControlesVencidos = new ControlesVencidos();
                    autoconControlesVencidos.CodigoDelVehiculo = aut.codigo;
                    autoconControlesVencidos.TipoVencimiento = "Matafuego y Revision";
                    ReporteAutosControlesVencidos.Add(autoconControlesVencidos);
                }
                else
                {
                    if (item.FechaVencimientoMatafuegos< DateTime.Today )
                    {
                        ControlesVencidos autoconControlesVencidos = new ControlesVencidos();
                        autoconControlesVencidos.CodigoDelVehiculo = aut.codigo;
                        autoconControlesVencidos.TipoVencimiento = "Matafuegos";
                        ReporteAutosControlesVencidos.Add(autoconControlesVencidos);
                    }
                    else
                    {
                        if (DateTime.Today.Year-item.FechaUltimaRevision.Year>=1)
                        {

                            ControlesVencidos autoconControlesVencidos = new ControlesVencidos();
                            autoconControlesVencidos.CodigoDelVehiculo = aut.codigo;
                            autoconControlesVencidos.TipoVencimiento = "Revision";
                            ReporteAutosControlesVencidos.Add(autoconControlesVencidos);
                        }
                    }
                }
                return ReporteAutosControlesVencidos;
            }
            return null;
        }
        
    }
}










