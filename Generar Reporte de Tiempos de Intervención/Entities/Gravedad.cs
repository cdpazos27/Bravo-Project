using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generar_Reporte_de_Tiempos_de_Intervención.Entities
{
    public class Gravedad
    {
        public int id_Gravedad { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }

        public Gravedad() { }

        internal bool esDeGravedad(Gravedad g)
        {
            return (this.id_Gravedad == g.id_Gravedad);
        }
    }
}
