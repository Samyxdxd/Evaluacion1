using AlmacenesPorAhi.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AlmacenesPorAhi.Modelo;

namespace AlmacenesPorAhi
{
    public partial class Form1 : Form
    {
        MovimientoTarjeta objMovimiento = new MovimientoTarjeta();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrear_SCortez_Click(object sender, EventArgs e)
        {
            
            string tipoVisa = "";
            if (rbVisaGold.Checked == true)
            {
                tipoVisa = "ViSA Gold";
            }
            else if (rbVisaPlatinum.Checked == true)
            {
                tipoVisa = "VISA Platinum";
            }


            if (string.IsNullOrEmpty(txtNombreCliente_SCortez.Text))
            {
                System.Windows.Forms.MessageBox.Show("Falta de Datos:(");
            }

            else if (string.IsNullOrEmpty(txtNumeroTarjeta_SCortez.Text))
            {
                System.Windows.Forms.MessageBox.Show("Falta de Datos:(");
            }

            else if (rbVisaGold.Checked == false && rbVisaPlatinum.Checked == false)
            {
                System.Windows.Forms.MessageBox.Show("Falta Seleccionar Tarjeta:(");
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Usuario creado :)");
                gbMovimientos.Visible = true;
            }

            objMovimiento.NumeroCuenta_SCortez = txtNumeroTarjeta_SCortez.Text;
            objMovimiento.NombreCliente_SCortez = txtNombreCliente_SCortez.Text;
            objMovimiento.TipoVisa_SCortez = tipoVisa;
        }

        private void btnCargo_SCortez_Click(object sender, EventArgs e)
        {
            int cantidad = int.Parse(txtMontoCargo_SCortez.Text);
            objMovimiento.Cargos(cantidad);
            listEvento_SCortez.Items.Add("El número de Tarjeta es: " +
            objMovimiento.NumeroCuenta_SCortez + ", MONTO DEPOSITADO: $" + cantidad + " CLP.");
        }

        private void btnEstado_SCortez_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("E S T A D O   D E   C U E N T A   V I S A" + "\n" +
            "Número de cuenta: " + objMovimiento.NumTarjeta_SCortez + "\n" + "Nombre del Cliente: " +
            objMovimiento.NombreCliente_SCortez + "\n" + "Tipo de Cuenta: " + objMovimiento.TipoVisa_SCortez + "\n" +
            "\n" + "SALDO DE LA CUENTA: $" + objMovimiento.SaldoCliente_SCortez.ToString() + " CLP.\n" +
            "\n" + DateTime.Now.ToString());
        }

        private void btnPago_SCortez_Click(object sender, EventArgs e)
        {
            int cantidad = int.Parse(txtPago_SCortez.Text);
            objMovimiento.Pagos(cantidad);
            listEvento_SCortez.Items.Add("El número de cuenta bancaria es: " +
            objMovimiento.NumeroCuenta_SCortez + ", MONTO DEPOSITADO: $" + cantidad + " CLP.");
        }

        private void btnNuevo_SCortez_Click(object sender, EventArgs e)
        {
            txtNombreCliente_SCortez.Clear();
            txtNumeroTarjeta_SCortez.Clear();
            rbVisaGold.Checked = false;
            rbVisaPlatinum.Checked = false;
            listEvento_SCortez.Visible = false;
            gbMovimientos.Visible = false;
        }

        private void txtNombreCliente_SCortez_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
