using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Generar_Reporte_de_Tiempos_de_Intervención.Entities;

namespace Generar_Reporte_de_Tiempos_de_Intervención.Bussiness_Layer
{
    class TiempoRespuesta : IEstrategiaInforme
    {
        public string[][] CalcularDuracionIntervenciones(Intervencion[] intervenciones, DateTime fechaDesde, DateTime fechaHasta, Gravedad[] gravedades, TipoSiniestro[] tipos)
        {
            throw new NotImplementedException();
        }
    }
}
