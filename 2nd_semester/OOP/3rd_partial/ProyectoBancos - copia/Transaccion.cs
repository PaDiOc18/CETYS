using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBancos
{
    public class Transaccion
    {
        public string TipoMovimiento { get; set; }
        
        public Transaccion(string TipoMovimiento)
        {
            this.TipoMovimiento = TipoMovimiento;
        }

        public bool CalculaDinero(double Saldo, double deudas)
        {
            if (Saldo - deudas <= 0)
            {
                return false;
            }
            return true;
        }
        
        public double AbonarASaldo(double Abono, double Saldo)
        {
            return Abono + Saldo;
        }
    }
}
