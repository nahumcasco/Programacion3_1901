using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programacion3._1901
{
    public partial class FuncionesRecursivas : Form
    {
        public FuncionesRecursivas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RecorrerDeUnoEnUno(1, 20);
        }

        private void RecorrerDeUnoEnUno(int num1, int num2)
        {
            listBox1.Items.Add(num1);
            if (num1 < num2)
            {
                RecorrerDeUnoEnUno(num1 + 1, num2);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 20; i++)
            {
                listBox1.Items.Add(i);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ResultadoFactoriallabel.Text = FactorialDe(Convert.ToDecimal(NumerotextBox.Text)).ToString();
        }

        private decimal FactorialDe(decimal numero)
        {
            if (numero == 1)
            {
                return numero;
            }
            else
            {
                return numero * FactorialDe(numero - 1);
            }
        }

    }
}
