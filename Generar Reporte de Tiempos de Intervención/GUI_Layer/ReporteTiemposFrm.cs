using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generar_Reporte_de_Tiempos_de_Intervención.GUI_Layer
{
    public partial class ReporteTiemposFrm : Form
    {
        private string[][] reporte;
        private DateTime fechaDesde, fechaHasta;
        public bool otro_ok = false;
        public ReporteTiemposFrm()
        {
            InitializeComponent();
        }

        public ReporteTiemposFrm(string[][] reporte, DateTime fechaDesde, DateTime fechaHasta)
        {
            this.reporte = reporte;
            this.fechaDesde = fechaDesde;
            this.fechaHasta = fechaHasta;
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ReporteTiemposFrm_Load(object sender, EventArgs e)
        {
            lblReporte.Text = "Reporte de duración de intervenciones entre el " + fechaDesde.ToShortDateString() + " hasta  el " + fechaHasta.ToShortDateString();
            dgvReporte.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvReporte.Columns[4].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            if (reporte != null)
            {
                List<string[]>  rep = reporte.ToList();
                foreach(string[] row in rep)
                {
                    if (row == rep.Last()) { break; }
                    dgvReporte.Rows.Add(new object[]
                    {
                        row[3],
                        row[0],
                        row[1],
                        row[2],
                        row[4]
                    });
                }
                txtDuracionPromedio.Text = rep.Last()[0];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            otro_ok = true;
            this.Close();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
