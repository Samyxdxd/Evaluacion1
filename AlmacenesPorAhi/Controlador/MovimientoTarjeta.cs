using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlmacenesPorAhi.Modelo;

namespace AlmacenesPorAhi.Controlador
{
    class MovimientoTarjeta : Tarjeta
    {
       public void Cargos(int cantidad)
        {
            SaldoCliente_SCortez += cantidad;
        }
        public bool Pagos(int cantidad)
        {
            if (SaldoCliente_SCortez >= cantidad)
            {
                SaldoCliente_SCortez -= cantidad;
                return true;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Saldo insuficiente" + "\n" +
                "Operacón Invalida");
                return false;
            }
        }
    }
}
