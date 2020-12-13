using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBancos
{
    class Cuenta
    {
        public double Saldo { get; set; }
        public double Deuda { get; set; }
        public string EstadoCuenta { get; set; }
        public string TipoDeCuenta { get; set; }

        public Cuenta(double Saldo, double Deuda, string EstadoCuenta)
        {
            this.Saldo = Saldo;
            this.Deuda = Deuda;
            this.EstadoCuenta = EstadoCuenta;
        }
    }
}
