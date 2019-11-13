using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Generar_Reporte_de_Tiempos_de_Intervención.DataAccess_Layer;
using Generar_Reporte_de_Tiempos_de_Intervención.Entities;


namespace Generar_Reporte_de_Tiempos_de_Intervención.DataAccess_Layer.Intervenciones
{
    class DaoImpSqlServer : IDaoIntervenciones
    {
        public DataTable consultarGravedades()
        {
            string sql = "SELECT * FROM Gravedades";
            return DBHelper.getDBHelper().ConsultaSQL(sql);
        }

        public DataTable consultarTipoSiniestro()
        {
            return DBHelper.getDBHelper().ConsultaSQL("SELECT * FROM TiposSiniestro");
        }

        public Intervencion[] obtenerIntervenciones()
        {
            /*
             * Debido a la falta de tiempo se generarán intervenciones a través del mismo lenguaje como prueba
             */

            Intervencion[] i = new Intervencion[13];


            Estado enCurso = new Estado();
            enCurso.id_estado = 5;
            enCurso.nombre = "En Curso";
            enCurso.ambito = 1;

            Estado finalizada = new Estado();
            finalizada.id_estado = 7;
            finalizada.nombre = "Finalizada";
            finalizada.ambito = 1;

            Estado creada = new Estado();
            creada.id_estado = 1;
            creada.nombre = "Creada";
            creada.ambito = 1;

            Estado abortada = new Estado();
            abortada.id_estado = 6;
            abortada.nombre = "Abortada";
            abortada.ambito = 1;

            Estado firmada = new Estado();
            firmada.id_estado = 2;
            firmada.nombre = "Firmada";
            firmada.ambito = 1;

            Dotacion d1 = new Dotacion();
            Dotacion d2 = new Dotacion();
            Dotacion d3 = new Dotacion();
            Dotacion d4 = new Dotacion();
            Dotacion d5 = new Dotacion();


            Gravedad alta = new Gravedad();
            alta.id_Gravedad = 1;
            alta.nombre = "Alta";

            Gravedad media = new Gravedad();
            media.id_Gravedad = 2;
            media.nombre = "Media";

            Gravedad baja = new Gravedad();
            baja.id_Gravedad = 3;
            baja.nombre = "Baja";

            TipoSiniestro incendio = new TipoSiniestro();
            incendio.id_tipoSiniestro = 1;
            incendio.nombre = "Incendio";

            TipoSiniestro acc = new TipoSiniestro();
            acc.id_tipoSiniestro = 2;
            acc.nombre = "Accidente Vial";

            TipoSiniestro res = new TipoSiniestro();
            res.id_tipoSiniestro = 3;
            res.nombre = "Rescate";

            TipoSiniestro ev = new TipoSiniestro();
            ev.id_tipoSiniestro = 4;
            ev.nombre = "Evacuación";


            Intervencion iv = new Intervencion();
            iv.id_intervencion = 1;
            iv.estado_actual = finalizada;
            iv.dotaciones.Add(d1);
            iv.dotaciones.Add(d2);
            iv.dotaciones.Add(d3);
            iv.encargado = new Bombero();
            iv.encargado.nombre = "Perez, Juan";
            iv.gravedad = alta;
            iv.tipo_siniestro = acc;
            HistorialDeIntervención h1 = new HistorialDeIntervención(new DateTime(2019, 9, 1, 15, 10, 0), creada);
            HistorialDeIntervención h2 = new HistorialDeIntervención(new DateTime(2019, 9, 1, 15, 40, 0), enCurso);
            HistorialDeIntervención h3 = new HistorialDeIntervención(new DateTime(2019, 9, 1, 15, 59, 0), finalizada);
            iv.historial.Add(h1);
            iv.historial.Add(h2);
            iv.historial.Add(h3);
            iv.resumenTrabajoEfectuado = "El accidente no tuvo víctimas fatales, se procedió a limpiar los daños al automóvil involucrado";

            i[0] = iv;

            Intervencion iv2 = new Intervencion();
            iv2.id_intervencion = 2;
            iv2.estado_actual = finalizada;
            iv2.dotaciones.Add(d1);
            iv2.dotaciones.Add(d2);
            iv2.encargado = new Bombero();
            iv2.encargado.nombre = "Paez, Juan";
            iv2.gravedad = media;
            iv2.tipo_siniestro = res;
            HistorialDeIntervención h4 = new HistorialDeIntervención(new DateTime(2019, 9, 2, 16, 10, 0), creada);
            HistorialDeIntervención h5 = new HistorialDeIntervención(new DateTime(2019, 9, 2, 17, 20, 0), enCurso);
            HistorialDeIntervención h6 = new HistorialDeIntervención(new DateTime(2019, 9, 2, 17, 59, 0), finalizada);
            iv2.historial.Add(h4);
            iv2.historial.Add(h5);
            iv2.historial.Add(h6);
            iv2.resumenTrabajoEfectuado = "Hubo un retraso hasta que los bomberos se pudieron presentar al cuartel, debido al temblor que atascó el tráfico, luego de eso," +
                "se pudo realizar el rescate del edificio.";

            i[1] = iv2;

            Intervencion iv3 = new Intervencion();
            iv3.id_intervencion = 3;
            iv3.estado_actual = finalizada;
            iv3.dotaciones.Add(d1);
            iv3.encargado = new Bombero();
            iv3.encargado.nombre = "Esquivel, Ana María";
            iv3.gravedad = baja;
            iv3.tipo_siniestro = ev;
            HistorialDeIntervención h7 = new HistorialDeIntervención(new DateTime(2019, 9, 1, 19, 10, 0), creada);
            HistorialDeIntervención h8 = new HistorialDeIntervención(new DateTime(2019, 9, 1, 19, 40, 0), enCurso);
            HistorialDeIntervención h9 = new HistorialDeIntervención(new DateTime(2019, 9, 1, 20, 20, 0), finalizada);
            HistorialDeIntervención h10 = new HistorialDeIntervención(new DateTime(2019, 9, 1, 20, 21, 0), firmada);
            iv3.historial.Add(h7);
            iv3.historial.Add(h8);
            iv3.historial.Add(h9);
            iv3.historial.Add(h10);
            iv3.resumenTrabajoEfectuado = "No hubo problemas en evacuar al personal de la escuela y biblioteca ";

            i[2] = iv3;

            Intervencion iv4 = new Intervencion();
            iv4.id_intervencion = 4;
            iv4.estado_actual = abortada;
            iv4.dotaciones.Add(d1);
            iv4.dotaciones.Add(d2);
            iv4.dotaciones.Add(d3);
            iv4.dotaciones.Add(d4);
            iv4.dotaciones.Add(d5);
            iv4.encargado = new Bombero();
            iv4.encargado.nombre = "Urdipalleta, Ghael";
            iv4.gravedad = alta;
            iv4.tipo_siniestro = incendio;
            HistorialDeIntervención h11 = new HistorialDeIntervención(new DateTime(2019, 10, 2, 1, 10, 0), creada);
            HistorialDeIntervención h12 = new HistorialDeIntervención(new DateTime(2019, 10, 2, 1, 40, 0), enCurso);
            HistorialDeIntervención h13 = new HistorialDeIntervención(new DateTime(2019, 10, 2, 1, 45, 0), abortada);
            iv4.historial.Add(h11);
            iv4.historial.Add(h12);
            iv4.historial.Add(h13);
            iv4.resumenTrabajoEfectuado = "Ningún trabajo fue efectuado";

            i[3] = iv4;

            Intervencion iv5 = new Intervencion();
            iv5.id_intervencion = 5;
            iv5.estado_actual = firmada;
            iv5.dotaciones.Add(d1);
            iv5.dotaciones.Add(d2);
            iv5.dotaciones.Add(d3);
            iv5.dotaciones.Add(d4);
            iv5.encargado = new Bombero();
            iv5.encargado.nombre = "Ludueña, María";
            iv5.gravedad = alta;
            iv5.tipo_siniestro = acc;
            HistorialDeIntervención h14 = new HistorialDeIntervención(new DateTime(2019, 9, 10, 10, 28, 0), creada);
            HistorialDeIntervención h15 = new HistorialDeIntervención(new DateTime(2019, 9, 10, 10, 38, 0), enCurso);
            HistorialDeIntervención h16 = new HistorialDeIntervención(new DateTime(2019, 9, 10, 18, 0, 0), finalizada);
            HistorialDeIntervención h17 = new HistorialDeIntervención(new DateTime(2019, 9, 10, 18, 30, 0), firmada);
            iv5.historial.Add(h14);
            iv5.historial.Add(h15);
            iv5.historial.Add(h16);
            iv5.historial.Add(h17);
            iv5.resumenTrabajoEfectuado = "El trabajo fue complicado, se contaba con 4 dotaciones, las cuales fueron divididas " +
                "según que iba a hacer cada una. Las primeras dos, evacuaron y auxiliaron a los heridos, y las otras dos apagaron el incendio generado" +
                " por el choque.";

            i[4] = iv5;

            Intervencion iv6 = new Intervencion();
            iv6.id_intervencion = 6;
            iv6.estado_actual = firmada;
            iv6.dotaciones.Add(d1);
            iv6.dotaciones.Add(d2);
            iv6.encargado = new Bombero();
            iv6.encargado.nombre = "Esquivel, Ana María";
            iv6.gravedad = baja;
            iv6.tipo_siniestro = incendio;
            HistorialDeIntervención h18 = new HistorialDeIntervención(new DateTime(2019, 9, 15, 22, 10, 0), creada);
            HistorialDeIntervención h19 = new HistorialDeIntervención(new DateTime(2019, 9, 15, 22, 40, 0), enCurso);
            HistorialDeIntervención h20 = new HistorialDeIntervención(new DateTime(2019, 9, 15, 23, 1, 0), finalizada);
            HistorialDeIntervención h21 = new HistorialDeIntervención(new DateTime(2019, 9, 15, 23, 5, 0), firmada);
            iv6.historial.Add(h18);
            iv6.historial.Add(h19);
            iv6.historial.Add(h20);
            iv6.historial.Add(h21);
            iv6.resumenTrabajoEfectuado = "El incendio fue controlado sin mayores dificultades.";

            i[5] = iv6;

            Intervencion iv7 = new Intervencion();
            iv7.id_intervencion = 7;
            iv7.estado_actual = finalizada;
            iv7.dotaciones.Add(d1);
            iv7.encargado = new Bombero();
            iv7.encargado.nombre = "Esquivel, Ana María";
            iv7.gravedad = media;
            iv7.tipo_siniestro = res;
            HistorialDeIntervención h22 = new HistorialDeIntervención(new DateTime(2019, 9, 28, 6, 10, 0), creada);
            HistorialDeIntervención h23 = new HistorialDeIntervención(new DateTime(2019, 9, 28, 6, 12, 0), enCurso);
            HistorialDeIntervención h24 = new HistorialDeIntervención(new DateTime(2019, 9, 28, 6, 59, 0), finalizada);
            iv7.historial.Add(h22);
            iv7.historial.Add(h23);
            iv7.historial.Add(h24);
            iv7.resumenTrabajoEfectuado = "Los pasajeros a bordo del ascensor atascado fueron rescatados con éxito.";

            i[6] = iv7;

            Intervencion iv8 = new Intervencion();
            iv8.id_intervencion = 8;
            iv8.estado_actual = creada;
            iv8.dotaciones.Add(d1);
            iv8.dotaciones.Add(d2);
            iv8.encargado = new Bombero();
            iv8.encargado.nombre = "Perez, Juan";
            iv8.gravedad = alta;
            iv8.tipo_siniestro = res;
            iv8.historial.Add(new HistorialDeIntervención(new DateTime(2019, 10, 1, 9, 19, 0),creada));
            iv8.resumenTrabajoEfectuado = "";

            i[7] = iv8;

            Intervencion iv9 = new Intervencion();
            iv9.id_intervencion = 9;
            iv9.estado_actual = firmada;
            iv9.dotaciones.Add(d1);
            iv9.dotaciones.Add(d2);
            iv9.encargado = new Bombero();
            iv9.encargado.nombre = "Ludueña, María";
            iv9.gravedad = media;
            iv9.tipo_siniestro = ev;
            HistorialDeIntervención h25 = new HistorialDeIntervención(new DateTime(2019, 10, 9, 22, 0, 0), creada);
            HistorialDeIntervención h26 = new HistorialDeIntervención(new DateTime(2019, 10, 9, 23, 0, 0), enCurso);
            HistorialDeIntervención h27 = new HistorialDeIntervención(new DateTime(2019, 10, 10, 0, 50, 0), finalizada);
            HistorialDeIntervención h28 = new HistorialDeIntervención(new DateTime(2019, 10, 10, 0, 55, 0), firmada);
            iv9.historial.Add(h25);
            iv9.historial.Add(h26);
            iv9.historial.Add(h27);
            iv9.historial.Add(h28);
            iv9.resumenTrabajoEfectuado = "Pese al horario, la evacuación fue ruidosa y lenta, pero se logro hacer sin heridos";

            

            i[8] = iv9;

            Intervencion iv10 = new Intervencion();
            iv10.id_intervencion = 10;
            iv10.estado_actual = finalizada;
            iv10.dotaciones.Add(d1);
            iv10.encargado = new Bombero();
            iv10.encargado.nombre = "Perez, Ramiro";
            iv10.gravedad = baja;
            iv10.tipo_siniestro = res;
            HistorialDeIntervención h29 = new HistorialDeIntervención(new DateTime(2019, 11, 11, 13, 20, 0), creada);
            HistorialDeIntervención h30 = new HistorialDeIntervención(new DateTime(2019, 11, 11, 13, 45, 0), enCurso);
            HistorialDeIntervención h31 = new HistorialDeIntervención(new DateTime(2019, 11, 11, 14, 50, 0), finalizada);
            iv10.historial.Add(h29);
            iv10.historial.Add(h30);
            iv10.historial.Add(h31);
            iv10.resumenTrabajoEfectuado = "El domicilio de destino era muy lejos, se perdió más tiempo en viaje que realizando el rescate del gato en el arbol";



            i[9] = iv10;

            Intervencion iv11 = new Intervencion();
            iv11.id_intervencion = 11;
            iv11.estado_actual = finalizada;
            iv11.dotaciones.Add(d1);
            iv11.encargado = new Bombero();
            iv11.encargado.nombre = "Macri, Mauricio";
            iv11.gravedad = baja;
            iv11.tipo_siniestro = res;
            HistorialDeIntervención h32 = new HistorialDeIntervención(new DateTime(2019, 10, 14, 17, 20, 0), creada);
            HistorialDeIntervención h33 = new HistorialDeIntervención(new DateTime(2019, 10, 14, 18, 10, 0), enCurso);
            HistorialDeIntervención h34 = new HistorialDeIntervención(new DateTime(2019, 10, 14, 19, 0, 0), finalizada);
            HistorialDeIntervención h35 = new HistorialDeIntervención(new DateTime(2019, 10, 14, 19, 5, 0), firmada);
            iv11.historial.Add(h32);
            iv11.historial.Add(h33);
            iv11.historial.Add(h34);
            iv11.historial.Add(h35);
            iv11.resumenTrabajoEfectuado = "El domicilio de destino era muy lejos, se perdió más tiempo en viaje que realizando el rescate del gato en el arbol";



            i[10] = iv11;

            Intervencion iv12 = new Intervencion();
            iv12.id_intervencion = 12;
            iv12.estado_actual = abortada;
            iv12.dotaciones.Add(d1);
            iv12.encargado = new Bombero();
            iv12.encargado.nombre = "Malagueño, Ramiro";
            iv12.gravedad = baja;
            iv12.tipo_siniestro = ev;
            HistorialDeIntervención h36 = new HistorialDeIntervención(new DateTime(2019, 11, 5, 4, 10, 0), creada);
            HistorialDeIntervención h37 = new HistorialDeIntervención(new DateTime(2019, 11, 5, 4, 12, 0), enCurso);
            HistorialDeIntervención h38 = new HistorialDeIntervención(new DateTime(2019, 11, 5, 4, 20, 0), abortada);
            iv12.historial.Add(h36);
            iv12.historial.Add(h37);
            iv12.historial.Add(h38);
            iv12.resumenTrabajoEfectuado = "Ningún trabajo fue efectuado";

            i[11] = iv12;

            Intervencion iv13 = new Intervencion();
            iv13.id_intervencion = 13;
            iv13.estado_actual = finalizada;
            iv13.dotaciones.Add(d1);
            iv13.dotaciones.Add(d2);
            iv13.dotaciones.Add(d3);
            iv13.dotaciones.Add(d4);
            iv13.encargado = new Bombero();
            iv13.encargado.nombre = "Fey, Candelaria";
            iv13.gravedad = alta;
            iv13.tipo_siniestro = incendio;
            HistorialDeIntervención h39 = new HistorialDeIntervención(new DateTime(2019, 8, 3, 23, 10, 0), creada);
            HistorialDeIntervención h40 = new HistorialDeIntervención(new DateTime(2019, 9, 3, 23, 40, 0), enCurso);
            HistorialDeIntervención h41 = new HistorialDeIntervención(new DateTime(2019, 9, 4, 0, 10, 0), finalizada);
            iv13.historial.Add(h39);
            iv13.historial.Add(h40);
            iv13.historial.Add(h41);
            iv13.resumenTrabajoEfectuado = "Se disipó el incendio con la mayor eficiencia posible.";

            i[12] = iv13;




            return i;
        }
    }
}
