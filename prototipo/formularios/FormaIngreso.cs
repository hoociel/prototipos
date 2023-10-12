using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prototipo.formularios
{
    public partial class FormaIngreso : Form
    {
        public FormaIngreso()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void áreaDelTrianguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormaArea area = new FormaArea();
            area.Show();
        }

        private void cambioDeDivisaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormaCambio cambio = new FormaCambio();
                cambio.Show();
        }

        private void frecuenciaCardiacaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormaLPM LPM = new FormaLPM();
            LPM.Show();
        }

        private void nuevoSalarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormaSalario salario = new FormaSalario();
            salario.Show();
        }

        private void chicharroneraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormaCuadratica cuadratica = new FormaCuadratica();
            cuadratica.Show();

        }

        private void visorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormaVisor visor = new FormaVisor();
            visor.Show();
        }
    }
}
