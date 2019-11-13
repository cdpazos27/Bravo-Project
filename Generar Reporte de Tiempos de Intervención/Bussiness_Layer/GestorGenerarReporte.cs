using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Generar_Reporte_de_Tiempos_de_Intervención.Entities;
using Generar_Reporte_de_Tiempos_de_Intervención.DataAccess_Layer.Intervenciones;
using System.Data;

namespace Generar_Reporte_de_Tiempos_de_Intervención.Bussiness_Layer
{
    class GestorGenerarReporte
    {
        private IEstrategiaInforme estrategiaActiva;
        private DateTime fechaDesde;
        private DateTime fechaHasta;
        private Gravedad[] gravedades;
        private TipoSiniestro[] tipos;
        private Intervencion[] intervenciones;
        private IDaoIntervenciones dao;


        public GestorGenerarReporte() { dao = new DaoImpSqlServer(); }



        public void TomarPeriodoReporte(DateTime fechaDesde, DateTime fechaHasta)
        {
            this.fechaDesde = fechaDesde;
            this.fechaHasta = fechaHasta;

        }

        public DataTable consultarTipoSiniestro()
        {
            return dao.consultarTipoSiniestro();
        }

        public DataTable consultarGravedades()
        {
            return dao.consultarGravedades();
        }

        public void TomarGravedad(Gravedad[] lista) { this.gravedades = lista; }

        public void TomarTipoSiniestro(TipoSiniestro[] tipo) { this.tipos = tipo; }

        public void SetEstrategiaInforme(IEstrategiaInforme est) { this.estrategiaActiva = est; }

        public void TomarSeleccionTiempoAnalisis(string tiempo)
        {
            /*
             * Posible solución (es basicamente un case...)
             * Seleccionar según el indice seleccionado, agregar una nueva estrategia solo requeriría un neuvo case.
             * Se podría haber llamado desde la interfaz, pero se quería seguir el análisis
             */
           if (tiempo == "Duración")
            {
                SetEstrategiaInforme(new TiempoDuracion());
            }
           if (tiempo == "Cierre")
            {
                SetEstrategiaInforme(new TiempoCierre());
            }
           if (tiempo == "Respuesta")
            {
                SetEstrategiaInforme(new TiempoRespuesta());
            }
        }

        /**
         * El método delega la responsabilidad de calcular el tiempo de intervencion a su estrategia, y obtiene en un
         * vector de string, los datos para generar el reporte
         * 
         */
        public string[][] calcularTiempoIntervenciones() 
        {
            intervenciones = dao.obtenerIntervenciones();
            return estrategiaActiva.CalcularDuracionIntervenciones(this.intervenciones,fechaDesde,fechaHasta, gravedades, tipos); 
        }

    }
}
