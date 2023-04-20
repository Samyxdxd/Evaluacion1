using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlmacenesPorAhi
{
    class Cliente_SCortez
    {
        private string nombreCliente_SCortez;
        private string numTarjeta_SCortez;
        private int saldo_SCortez;
        public Cliente_SCortez()
        {
        }

        public Cliente_SCortez(string nombreCliente, int saldoCliente, string numTarjeta_SCortez)
        {
            this.nombreCliente_SCortez = nombreCliente;
            this.saldo_SCortez = SaldoCliente_SCortez;
            this.numTarjeta_SCortez = numTarjeta_SCortez;
        }
        public string NombreCliente_SCortez { get => nombreCliente_SCortez; set => nombreCliente_SCortez = value; }
        public int SaldoCliente_SCortez { get => saldo_SCortez; set => saldo_SCortez = value; }
        public string NumTarjeta_SCortez { get => numTarjeta_SCortez; set => numTarjeta_SCortez = value; }
    }
}
