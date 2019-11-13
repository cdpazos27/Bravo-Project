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
    public partial class PrincipalFrm : Form
    {
        public PrincipalFrm()
        {
            InitializeComponent();
        }

        private void PrincipalFrm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PantallaInformeTiemposIntervencion frm = new PantallaInformeTiemposIntervencion();
            frm.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
}
