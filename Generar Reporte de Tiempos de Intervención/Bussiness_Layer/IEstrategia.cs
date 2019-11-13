using Generar_Reporte_de_Tiempos_de_Intervención.Entities;
using System;

namespace Generar_Reporte_de_Tiempos_de_Intervención.Bussiness_Layer
{
    public interface IEstrategiaInforme
    {
        string[][] CalcularDuracionIntervenciones(Intervencion[] intervenciones,
            DateTime fechaDesde, DateTime fechaHasta,
            Gravedad[] gravedades,
            TipoSiniestro[] tipos);
        
    }
}