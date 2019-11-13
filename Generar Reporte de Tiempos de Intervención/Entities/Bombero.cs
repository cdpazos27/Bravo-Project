using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generar_Reporte_de_Tiempos_de_Intervención.Entities
{
    public class Bombero
    {
        private bool activo { get; set; }
        private int idBombero { get; set; }
        private string direccion { get; set; }
        private string dni { get; set; }
        private string email { get; set; }
        private DateTime fechaNacimiento { get; set; }
        public string nombre { get; set; }
        private string telefeno { get; set; }
        private IList<Asistencia> asistencias { get; set; }
        private Rol rol { get; set; }
        private IList<Disponibilidad> disponibilidad { get; set; }
        private Usuario usuario { get; set; }

        public Bombero() { }

        public string getNombre() { return this.nombre; }

    }
}
