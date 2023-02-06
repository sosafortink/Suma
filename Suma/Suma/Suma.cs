using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Suma
{
    public partial class Suma : Form
    {
        public Suma()
        {
            InitializeComponent();
        }

        private void SumarButton_Click(object sender, EventArgs e)
        {
            // Variables

            double numero1 = Convert.ToDouble(Numero1textBox.Text);
            double numero2 = Convert.ToDouble(Numero2textBox.Text);

            //double resultado = numero1 + numero2;

            double resultado = Convert.ToDouble(Numero1textBox.Text) + Convert.ToDouble(Numero2textBox.Text);

            MessageBox.Show("La suma es:  " + resultado);
        }

     
    }
}
