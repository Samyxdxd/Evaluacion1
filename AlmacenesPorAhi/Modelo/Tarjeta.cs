using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlmacenesPorAhi.Modelo
{
    class Tarjeta : Cliente_SCortez
    {
        private string numeroCuenta_SCortez;
        private string tipoVisa_SCortez;
        public Tarjeta()
        {
        }
        public Tarjeta(string numeroCuenta, string tipoCuenta)
        {
            this.numeroCuenta_SCortez = numeroCuenta;
            this.tipoVisa_SCortez = tipoCuenta;
        }
        public string NumeroCuenta_SCortez { get => numeroCuenta_SCortez; set => numeroCuenta_SCortez = value; }
        public string TipoVisa_SCortez { get => tipoVisa_SCortez; set => tipoVisa_SCortez = value; }
    }
}
