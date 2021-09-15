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
    public partial class FuncionesDeTexto : Form
    {
        public FuncionesDeTexto()
        {
            InitializeComponent();
        }

        private void Ejecutarbutton_Click(object sender, EventArgs e)
        {
            string cadena = CadenaTextBox.Text;

            //Obtener la longitud de la cadena ingresada
            LongitudTextBox.Text = cadena.Length.ToString();

            //Obtener el primer elemento o caracter
            PrimerCaractertextBox.Text = cadena.Substring(0, 1);

            //Obtener el último elemento o caracter
            UltimoTextBox.Text = cadena.Substring(cadena.Length - 1, 1);

            //Convertir a Mayúsculas
            MayusculaTextBox.Text = cadena.ToUpper();

            //Convertir a Minúsculas
            MinusculaTextBox.Text = cadena.ToLower();

            //Reemplazar
            ReemplazarTextBox.Text = cadena.Replace("a", "x");


        }
    }
}
