using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Generar_Reporte_de_Tiempos_de_Intervención.Entities;

namespace Generar_Reporte_de_Tiempos_de_Intervención.Bussiness_Layer
{
    class TiempoDuracion : IEstrategiaInforme
    {
        List<string[]> datos;

        public string[][] CalcularDuracionIntervenciones(Intervencion[] intervenciones, DateTime fechaDesde, DateTime fechaHasta, Gravedad[] gravedades, TipoSiniestro[] tipos)
        {

            datos = new List<string[]>();
            int idx = 0;
            List<TimeSpan> times = new List<TimeSpan>();
            foreach (Intervencion i  in intervenciones)
            {
                string[] ar = new string[5];
                TimeSpan ts = i.calcularDuración(fechaDesde, fechaHasta);
                if (ts == TimeSpan.Zero) { continue; }
                bool ok_tipo = false, ok_grav = false;
                foreach (TipoSiniestro tp in tipos)
                {
                    if (i.esTipoSiniestro(tp))
                    {
                        ok_tipo = true;
                    }
                }
                foreach (Gravedad g in gravedades)
                {
                    if (i.validarGravedad(g))
                    {
                        ok_grav = true;
                    }
                }
                if (!(ok_grav && ok_tipo)) { continue; }
                times.Add(ts);
                ar[0] = ts.ToString();
                ar[1] = i.contarDotaciones().ToString();
                ar[2] = i.encargado.getNombre();
                ar[3] = i.id_intervencion.ToString();
                ar[4] = i.resumenTrabajoEfectuado;
                datos.Add(ar);
                
            }
            if (datos.Count != 0)
            {
                TimeSpan average = new TimeSpan(Convert.ToInt64(times.Average(x => TimeSpan.Parse(x.ToString()).Ticks)));
                string[] ar2 = new string[2];
                ar2[0] = average.ToString();
                datos.Add(ar2);
                return datos.ToArray();
            }
            else
                return null;
        }
    }
}
