using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generar_Reporte_de_Tiempos_de_Intervención.Entities
{
    public class TipoAlerta
    {
        private int id_TipoAlerta { get; set; }
        private string descripcion { get; set; }
        private string nombre { get; set; }
        private int intensidad { get; set; } 
        private int tono { get; set; }

        public TipoAlerta() { }
    }
}
