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
    public partial class FormaCambio : Form
    {
        public FormaCambio()
        {
            InitializeComponent();
        }

        private void FormaCambio_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double mexico = double.Parse(textoPeso.Text);
                if (mexico <= 0)
                {
                    MessageBox.Show("Error");
                }
                else
                {
                    double dolares = (mexico / 2) * 0.056;
                    double euros = (mexico / 2) * 0.053;


                    labelEuro.Text = euros.ToString();
                    labelDolar.Text = dolares.ToString();
                }
            }
            catch(FormatException)
            {
                MessageBox.Show("Ingresa numeros validos");
            }
        }
    }
}
