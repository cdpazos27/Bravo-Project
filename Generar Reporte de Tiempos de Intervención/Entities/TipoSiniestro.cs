using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generar_Reporte_de_Tiempos_de_Intervención.Entities
{
    public class TipoSiniestro
    {
        public int id_tipoSiniestro { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }

        public TipoSiniestro() { }

        public bool esTipoSiniestro(TipoSiniestro tp)
        {
            return (this.id_tipoSiniestro == tp.id_tipoSiniestro);
        }
    }
}
