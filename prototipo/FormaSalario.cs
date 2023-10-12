using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prototipo
{
    public partial class FormaSalario : Form
    {
        public FormaSalario()
        {
            InitializeComponent();
        }

        private void botonC_Click(object sender, EventArgs e)
        {
            try
            {
                double salario = double.Parse(textoActual.Text);
                if (salario <= 0)
                {
                    MessageBox.Show("No valido");
                }
                else
                {
                    double incremento = (salario * 0.25) + salario;

                    labelPor.Text = incremento.ToString();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingresa valor valido");
            }
        }
    }
}
