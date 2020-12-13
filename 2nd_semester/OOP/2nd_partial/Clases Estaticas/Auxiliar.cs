using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Estaticas
{
    public static class Auxiliar
    {
        public static readonly double G = 6.67;

        public static double CalculaDistancia(double x1, double x2, double y1, double y2)
        {
            double suma = Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2);
            return Math.Sqrt(suma);
        }

        public static Punto CalculaPuntoMedio(Punto unPunto, Punto otroPunto) //Aquí va public
        {
            double newX = (unPunto.X + otroPunto.X) / 2;
            double newY = (unPunto.Y + otroPunto.Y) / 2;
            return new Punto(newX, newY);
        }

        public static List<Punto> CalculaPuntosMedios(List<Punto> puntos)
        {
            List<Punto> medios = new List<Punto>();
            for (int i = 0; i < puntos.Count; i++)
            {
                for (int j = 0; j < puntos.Count; j++)
                {
                    Punto medio = CalculaPuntoMedio(puntos[i], puntos[j]);
                    medios.Add(medio);
                }
            }
            return medios;
        }

        public static bool ContieneUnlatice(List<Punto> puntos)
        {
            foreach (var item in puntos)
            {
                if (item.EsLatice())
                {
                    return true;
                }
            }
            return false;
        }
        //Clase lineas

    }
}
