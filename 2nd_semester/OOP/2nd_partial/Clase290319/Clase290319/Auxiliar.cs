using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase290319
{
    static class Auxiliar
    {
        public static readonly double G = 6.67;

        public static double calculaDistancia(double x1, double y1, double x2, double y2)
        {
            double suma = Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2);
            return Math.Sqrt(suma);
        }

        public static punto calculaPuntoMedio(punto unPunto, punto otroPunto)
        {
            double newX = (unPunto.X + otroPunto.X) / 2;
            double newY = (unPunto.Y + otroPunto.Y) / 2;
            return new punto(newX, newY);
        }
        public static List<punto> CalculaPuntosMedios(List<punto> puntos)
        {
            List<punto> medios = new List<punto>();
            for (int i = 0; i < puntos.Count; i++)
            {
                for (int j = i+1; j < puntos.Count; j++)
                {
                    punto medio = calculaPuntoMedio(puntos[i], puntos[j]);
                    medios.Add(medio);
                }
            }
            return medios;
        }
        public static bool ContieneUnLattice(List<punto> Puntos)
        {
            foreach (var item in Puntos)
            {
                if (item.EsLattice())
                {
                    return true;
                }
            }
            return false;
        }
    }
}
