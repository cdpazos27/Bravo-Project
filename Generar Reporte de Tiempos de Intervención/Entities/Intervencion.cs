using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generar_Reporte_de_Tiempos_de_Intervención.Entities
{
    public class Intervencion
    {
        public int id_intervencion { get; set; }
        public string domicilioReportado { get; set; }
        public string nombreApellidoInformante { get; set; }
        public string resumenSiniestro { get; set; }
        public string resumenTrabajoEfectuado { get; set; }
        public string telefono { get; set; }
        public IList<Dotacion> dotaciones { get; set; }
        public Estado estado_actual { get; set; }
        public Gravedad gravedad { get; set; }
        public IList<HistorialDeIntervención> historial { get; set; }
        public TipoSiniestro tipo_siniestro { get; set; }
        public IList<Material> materiales_utilizados { get; set; }
        public Bombero encargado { get; set; }
        public IList<Convocatoria> convocatorias { get; set; }


        public Intervencion()
        {
            dotaciones = new List<Dotacion>();
            estado_actual = new Estado();
            gravedad = new Gravedad();
            historial = new List<HistorialDeIntervención>();
            tipo_siniestro = new TipoSiniestro();
            materiales_utilizados = new List<Material>();
            encargado = new Bombero();
            convocatorias = new List<Convocatoria>();

        }

        public bool esTipoSiniestro(TipoSiniestro tipo)
        {
            return (tipo_siniestro.esTipoSiniestro(tipo));
        }

        public int contarDotaciones()
        {
            return dotaciones.Count;
        }

        public int getEstadoActual()
        {
            return this.estado_actual.id_estado;
        }

        public bool validarTipoSiniestro(TipoSiniestro tp) { return (tipo_siniestro.esTipoSiniestro(tp)); }

        public bool validarGravedad(Gravedad g) { return (gravedad.esDeGravedad(g)); }

        public TimeSpan calcularDuración(DateTime fechaDesde, DateTime fechaHasta)
        {
            Nullable<TimeSpan> duracion=null;
            Nullable<DateTime> fechaFin = null; 
            Nullable<DateTime> fechaEnCurso = null;
            foreach (HistorialDeIntervención h in historial)
            {
                if (h.estaEntrePeriodo(fechaHasta, fechaDesde))
                {
                    fechaFin = h.fechaHoraDesde;
                    break;
                }
            }

            foreach (HistorialDeIntervención h2 in historial)
            {
                if (h2.esEstadoEnCurso())
                {
                    fechaEnCurso = h2.fechaHoraDesde;
                    break;
                }
            }
            if (fechaEnCurso.HasValue && fechaFin.HasValue)
            {
                duracion = fechaFin.Value - fechaEnCurso.Value;
            }
            else
            {
                duracion = TimeSpan.Zero;
            }
            return duracion.Value;
        }
           
    }
}
