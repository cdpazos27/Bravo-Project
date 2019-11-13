using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generar_Reporte_de_Tiempos_de_Intervención.Entities
{
    /// <summary>
    /// Clase que representa un estado en, ya sea una intervención, una guardia de bombero, o una programación de guardias de bombero.
    /// </summary>
    public class Estado
    {
        /// <summary>
        /// Ambito indica a cual de las clases se está refiriendo el estado 
        /// Ambito == 1 -> Intervención
        /// Ambito == 2 -> Guardia
        /// Ambito == 3 -> ProgramaciónGuardia
        /// </summary>
        public int ambito { get; set; }
        public int id_estado { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }


        public bool esEnCurso()
        {
            return (this.nombre == "En Curso");
        }

        public bool esFinalizado()
        {
            return (this.nombre == "Finalizada");
        }
        /// <summary>
        /// new() que genera un nuevo estado.
        /// </summary>
        /// 
        public Estado() { }
        public Estado(int ambito, int id, string nombre, string desc)
        {
            this.ambito = ambito;
            this.id_estado = id;
            this.nombre = nombre;
            this.descripcion = desc;
        }

    }
}
