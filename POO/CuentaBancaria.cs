using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO
{
    public partial class CuentaBancaria : Form
    {
        public CuentaBancaria()
        {
            InitializeComponent();
        }

        Cliente cliente;
        Cuenta cuenta;
        MovimientoCuenta movimientoCuenta;
        List<MovimientoCuenta> listaMovimientosCuenta;


        private void CrearCuentaButton_Click(object sender, EventArgs e)
        {
            //1.Crear El Cliente
            cliente = new Cliente(IdentidadClienteTextBox.Text, NombreClienteTextBox.Text);

            //.Crear La Cuenta
            cuenta = new Cuenta(NumeroCuentaTextBox.Text, cliente, DateTime.Now);

            SaldoTextBox.Text = cuenta.Saldo.ToString("N");

        }

        private void AgregarMovimientoButton_Click(object sender, EventArgs e)
        {
            if (MontoMovimientoTextBox.Text == string.Empty)
            {
                MessageBox.Show("Ingrese el monto del movimiento.");
                MontoMovimientoTextBox.Focus();
                return;
            }
            if (string.IsNullOrEmpty(TipoMovimeintoComboBox.Text))
            {
                MessageBox.Show("Seleccione el tipo de movimiento");
                return;
            }

            if (TipoMovimeintoComboBox.Text == "Depósito")
            {
                cuenta.Depositar(Convert.ToDecimal(MontoMovimientoTextBox.Text));

                movimientoCuenta = new MovimientoCuenta(cuenta, DateTime.Now, Convert.ToDecimal(MontoMovimientoTextBox.Text),
                                                        TipoMovimeintoComboBox.Text);

                listaMovimientosCuenta = new List<MovimientoCuenta>();

                listaMovimientosCuenta.Add(movimientoCuenta);

                MovimientosListBox.Items.Add("Depósito a la cuenta N." + cuenta.NumeroCuenta + 
                                             " por la cantidad de L." + movimientoCuenta.Monto + 
                                             " con fecha: " + movimientoCuenta.FechaMovimiento);

                SaldoTextBox.Text = cuenta.Saldo.ToString("N");
            }
            else if (TipoMovimeintoComboBox.Text == "Retiro")
            {
                bool pudoRetirar = cuenta.Retirar(Convert.ToDecimal(MontoMovimientoTextBox.Text));
                if (pudoRetirar)
                {
                    movimientoCuenta = new MovimientoCuenta(cuenta, DateTime.Now, Convert.ToDecimal(MontoMovimientoTextBox.Text),
                                                        TipoMovimeintoComboBox.Text);

                    listaMovimientosCuenta = new List<MovimientoCuenta>();

                    listaMovimientosCuenta.Add(movimientoCuenta);

                    MovimientosListBox.Items.Add("Retiro a la cuenta N." + cuenta.NumeroCuenta +
                                                 " por la cantidad de L." + movimientoCuenta.Monto +
                                                 " con fecha: " + movimientoCuenta.FechaMovimiento);

                    SaldoTextBox.Text = cuenta.Saldo.ToString("N");
                }
                else
                {
                    MessageBox.Show("No tiene suficiente saldo en su cuenta, para realizar la transacción");
                }
            }
            MontoMovimientoTextBox.Clear();
        }
    }
}
