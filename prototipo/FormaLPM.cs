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
    public partial class FormaLPM : Form
    {
        public FormaLPM()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double cardiaco = double.Parse(textoEdad.Text);

                if (cardiaco <= 0 || cardiaco >= 105)
                {
                    MessageBox.Show("Edad no correcta");
                }
                else
                {

                    double resu = (220 - cardiaco);

                    labelResu.Text = resu.ToString();
                }
                
            }
            catch(FormatException)
            {
                MessageBox.Show("Ingresa numeros validos");
            }
        }

        private void FormaLPM_Load(object sender, EventArgs e)
        {

        }
    }
}
