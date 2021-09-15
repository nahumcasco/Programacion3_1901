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
    public partial class FuncionesDeFecha : Form
    {
        public FuncionesDeFecha()
        {
            InitializeComponent();
        }

        private void EjecutarButton_Click(object sender, EventArgs e)
        {
            DateTime fechaIngresada = FechaDateTimePicker.Value;

            NumeroDiaTextBox.Text = fechaIngresada.Day.ToString();
            NumeroMestextBox.Text = fechaIngresada.Month.ToString();
            AnioTextBox.Text = fechaIngresada.Year.ToString();
            HoraTextBox.Text = fechaIngresada.Hour.ToString();

            MesTextBox.Text = fechaIngresada.ToString("MMMM");

            int diasASumar = Convert.ToInt32(AgregarDiastextBox.Text);

            NuevaFechaConDiastextBox.Text = fechaIngresada.AddDays(diasASumar).ToShortDateString();

            int diasARestar = Convert.ToInt32(DiasARestartextBox.Text);
            NuevaFechaRestadatextBox.Text = fechaIngresada.AddDays(-diasARestar).ToShortDateString();

            EdadTextBox.Text = DevolverEdad(fechaIngresada).ToString();

        }

        private int DevolverEdad(DateTime _fechanacimiento)
        {
            DateTime fechaNacimiento = _fechanacimiento;
            DateTime fechaActual = DateTime.Now;
            int edad = 0;

            if (fechaNacimiento >= fechaActual)
            {
                MessageBox.Show("Fecha mayor al día de hoy");
                return 0;
            }
            else
            {
                edad = fechaActual.Year - fechaNacimiento.Year;
                if (fechaNacimiento.Month > fechaActual.Month)
                {
                    --edad;
                }
            }

            return edad;
        }


    }
}
