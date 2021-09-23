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
    public partial class Arreglos : Form
    {
        public Arreglos()
        {
            InitializeComponent();
        }

        private void Ejecutarbutton_Click(object sender, EventArgs e)
        {
            //Arreglos
            int[] arreglo1 = new int[5];

            arreglo1[0] = 10;
            arreglo1[1] = 20;
            arreglo1[2] = 60;
            arreglo1[3] = 100;
            arreglo1[4] = 30;

            int[] arreglo2 = new int[] { 1, 2, 3, 4, 5, 6 };

            int[] arreglo3 = { 1, 2, 3, 4, 5, 6 };

            string[] arreglo4 = { "Juan", "Maria", "Estela", "Carlos" };

            //for (int i = 0; i < arreglo4.Length; i++)
            //{
            //    listBox1.Items.Add(arreglo4[i]);
            //}

            foreach (var item in arreglo4)
            {
                listBox1.Items.Add(item);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] valores = new int[] { 6, 1, 9, 2, 5, 3, 7, 8 };
            //Ordenar de Menor a Mayor
            Array.Sort(valores);

            //Ordenar de Mayor a Menor
            Array.Reverse(valores);

            foreach (var item in valores)
            {
                listBox2.Items.Add(item);
            }

        }
    }
}
