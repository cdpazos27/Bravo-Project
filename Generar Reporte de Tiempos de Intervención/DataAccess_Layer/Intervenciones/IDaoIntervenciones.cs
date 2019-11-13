using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Generar_Reporte_de_Tiempos_de_Intervención.Entities;

namespace Generar_Reporte_de_Tiempos_de_Intervención.DataAccess_Layer.Intervenciones
{
    interface IDaoIntervenciones
    {

        DataTable consultarTipoSiniestro();

        DataTable consultarGravedades();
        Intervencion[] obtenerIntervenciones();
    }
}
