using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases1
{
    class Prestamo
    {
        public int ID_Prestamo { get; set; }
        public DateTime FechaPrestamo { get; set; }
        public DateTime FechaDevuelta { get; set; }
        public string CubiculoOLibro { get; set; }
        public Prestamo(int ID_Prestamo, DateTime FechaPrestamo, DateTime FechaDevuelta, string CubiculoOLibro)
        {
            this.ID_Prestamo = ID_Prestamo;
            this.FechaPrestamo = FechaPrestamo;
            this.FechaDevuelta = FechaDevuelta;
            this.CubiculoOLibro = CubiculoOLibro;
        }
        public int Pago()
        {
            if ((FechaDevuelta.Day - FechaPrestamo.Day) <= 2)
            {
                return 0;
            }
            else
            {
                return ((FechaDevuelta.Day - FechaPrestamo.Day) - 2) * 10;
            }
        }
    }
}
