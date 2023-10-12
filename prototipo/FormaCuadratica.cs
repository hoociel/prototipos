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
    public partial class FormaCuadratica : Form
    {
        public FormaCuadratica()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double valorA = double.Parse(textoA.Text);
                double valorB = double.Parse(textoB.Text);
                double valorC = double.Parse(textoC.Text);
                double cuadratica = (valorB * valorB) - (4 * valorA * valorC);

                if (cuadratica > 0)
                {
                    double xuno = (-valorB + Math.Sqrt(cuadratica)) / (2 * valorA);
                    double xdos = (-valorB - Math.Sqrt(cuadratica)) / (2 * valorA);

                    labelUno.Text = xuno.ToString();
                    labelDos.Text = xdos.ToString();

                }
                else
                {
                    MessageBox.Show("No tiene solución");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("ingresa valores validos");
            }
        }
    }
}
