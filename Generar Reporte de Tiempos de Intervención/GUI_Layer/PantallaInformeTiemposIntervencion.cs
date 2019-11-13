using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Generar_Reporte_de_Tiempos_de_Intervención.Bussiness_Layer;
using Generar_Reporte_de_Tiempos_de_Intervención.Entities;
using Generar_Reporte_de_Tiempos_de_Intervención.GUI_Layer;

namespace Generar_Reporte_de_Tiempos_de_Intervención
{
    public partial class PantallaInformeTiemposIntervencion : Form
    {
        private readonly GestorGenerarReporte gestor;

        public PantallaInformeTiemposIntervencion()
        {
            gestor = new GestorGenerarReporte();
            InitializeComponent();
        }

        private void HabilitarPantalla(object sender, EventArgs e)
        {
            LlenarCkBox(ckListGravedades, gestor.consultarGravedades(), "id_gravedad", "nombre");
            LlenarCkBox(ckListTipoSiniestro, gestor.consultarTipoSiniestro(), "id_tipoSiniestro", "nombre");
        }
        
        private void LlenarCkBox(CheckedListBox clb, Object source, string value, string display)
        {
            clb.DataSource = source;
            clb.DisplayMember = display;
            clb.ValueMember = value;
        }

        private void LlenarListBox(ListBox lcb, Object source, string value, string display)
        {
            lcb.DataSource = source;
            lcb.DisplayMember = display;
            lcb.ValueMember = value;
            lcb.SelectedIndex = -1;
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            if (validarPeriodo())
            {
                if (ckListGravedades.CheckedItems.Count >= 1)
                {
                    if (ckListTipoSiniestro.CheckedItems.Count >= 1)
                    {
                        gestor.TomarPeriodoReporte(dtFechaHoraDesde.Value, dtFechaHoraHasta.Value);
                        List<Gravedad> gravedades = new List<Gravedad>();
                        foreach (Object c in ckListGravedades.CheckedItems)
                        {
                            Gravedad gravedad = new Gravedad();
                            DataRowView casted = c as DataRowView;
                            gravedad.id_Gravedad = Int32.Parse(casted["id_gravedad"].ToString());
                            gravedad.nombre = casted["nombre"].ToString();
                            gravedades.Add(gravedad);
                        }


                        List<TipoSiniestro> tipos = new List<TipoSiniestro>();
                        foreach (DataRowView row in ckListTipoSiniestro.CheckedItems)
                        {
                            TipoSiniestro ts = new TipoSiniestro();
                            ts.id_tipoSiniestro = Int32.Parse(row.Row["id_tipoSiniestro"].ToString());
                            ts.nombre = row.Row["nombre"].ToString();
                            tipos.Add(ts);
                        }

                        gestor.TomarTipoSiniestro(tipos.ToArray());
                        gestor.TomarGravedad(gravedades.ToArray());
                        RadioButton radioBtn = this.pnlTiempo.Controls.OfType<RadioButton>()
                                           .Where(x => x.Checked).FirstOrDefault();

                        if (radioBtn != null)
                        {
                            gestor.TomarSeleccionTiempoAnalisis(radioBtn.Text);
                            try
                            {
                                string[][] reporte = gestor.calcularTiempoIntervenciones();
                                if (reporte == null)
                                {
                                    MessageBox.Show("No se encontraron encomiendas que cumplen con los filtros seleccionados", "Reporte", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    VisualizaciónFrm frm = new VisualizaciónFrm();
                                    frm.ShowDialog();
                                    if (frm.confirmacion)
                                    {
                                        ReporteTiemposFrm frm2 = new ReporteTiemposFrm(reporte, dtFechaHoraDesde.Value, dtFechaHoraHasta.Value);
                                        frm2.ShowDialog();
                                        if (!(frm2.otro_ok))
                                        {
                                            this.Close();
                                        }

                                    }
                                }
                            }
                            catch (NotImplementedException ex)
                            {
                                MessageBox.Show("Función aun no implementada...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            MessageBox.Show("No se seleccionó el tiempo del reporte", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("No se seleccionó ningun tipo de Siniestro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("No selecionó ninguna gravedad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("El periodo ingresado no es válido.", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private bool validarPeriodo()
        {
            return (dtFechaHoraDesde.Value < dtFechaHoraHasta.Value);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdCierre_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pnlTiempo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Los tiempos de la intervención pueden ser: \n  \n" +
                " - Duración de Intervenciones: Se calcula el tiempo que una intervención estuvo “EnCurso” hasta su finalización y mostrando el resumen de trabajo efectuado, el nombre y apellido del encargado de intervención y cantidad de dotaciones que participaron. \n \n " +
                " - Tiempo de Cierre: Se calcula el tiempo desde que una intervención finaliza hasta su firma se muestra el resumen de los trabajos efectuados y el detalle de materiales utilizados. \n \n " +
                " - Tiempo de Respuesta:  Se calcula el tiempo desde que una intervención es informada hasta que se pone “EnCurso” mostrando el domicilio reportado y la cantidad de bomberos convocados", "Tiempo del Reporte", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
