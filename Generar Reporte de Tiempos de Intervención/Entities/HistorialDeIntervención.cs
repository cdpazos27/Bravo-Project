using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generar_Reporte_de_Tiempos_de_Intervención.Entities
{
    public class HistorialDeIntervención
    {
        public DateTime fechaHoraDesde { get; set; }
        public Estado estado { get; set; }

        public HistorialDeIntervención() { }

        public HistorialDeIntervención(DateTime desde, Estado estado) { this.fechaHoraDesde = desde;
            this.estado = estado;
        }

        public bool estaEntrePeriodo(DateTime fechaHasta,DateTime fechaDesde)
        {
            if (fechaHoraDesde > fechaDesde && fechaHoraDesde < fechaHasta && this.estado.esFinalizado())
            {
                return true;
            }
            else
                return false;
        }

        internal bool esEstadoEnCurso()
        {
            return (this.estado.esEnCurso());
        }
    }
}
