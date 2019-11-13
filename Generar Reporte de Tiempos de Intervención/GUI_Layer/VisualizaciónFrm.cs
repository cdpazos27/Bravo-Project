using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Generar_Reporte_de_Tiempos_de_Intervención.Bussiness_Layer;

namespace Generar_Reporte_de_Tiempos_de_Intervención.GUI_Layer
{
    public partial class VisualizaciónFrm : Form
    {
        public bool confirmacion=false;

        public VisualizaciónFrm()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            RadioButton radioBtn = this.Controls.OfType<RadioButton>()
                                           .Where(x => x.Checked).FirstOrDefault();
            if (radioBtn != null)
            {
                switch (radioBtn.Text)
                {
                    case "Excel":
                        MessageBox.Show("Función aún no implementada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case "Pantalla":
                        DialogResult res = MessageBox.Show("¿Está seguro que desea generar el reporte?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        confirmacion = (res == DialogResult.Yes);
                        this.Close();
                        break;
                    case "PDF":
                        MessageBox.Show("Función aún no implementada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                }
            }
            else
                MessageBox.Show("No se seleccionó ninguna forma de visualización", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void VisualizaciónFrm_Load(object sender, EventArgs e)
        {
            rdPantalla.Checked = true;
        }
    }
}
