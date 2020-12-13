using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1MN
{
    class Program
    {
        static void Main(string[] args)
        {
            //FuncionDeTaylor1(); //Descomentar para ver el ejercicio 1
            //Ejercicio2(); //Descomentar para ver el ejercicio 2
            //NewtonRaphson(4); //Descomentar para ver ejercicio 3
            //NewtonRaphson4(7); //Descomentar para ver ejercicio 3 Solucion 1
            //NewtonRaphson4(4); //Descomentar para ver ejercicio 3 Solucion 2
            Ejercicio2();

            Console.ReadKey();


            //Ejercicio 1
            void FuncionDeTaylor1()
            {
                double imprime = 0; //La variable que va a air acumulando el valor de la serie, incializada en 0
                double x = 0.2; //Elegimos x = 0.2 en la ecuación, ya que en el punto b, determinamos que es necsario para calcula el ln(1.5)
                for (double i = 0; i < 5; i++) //Un for con 5 iteraciones necesarias para alcanzar el resultado 
                {
                    double aux = (2 * i) + 1; //Es una variable auxiliar que calcula en 2n + 1 (Numero Impar de la iteración)
                    imprime = imprime + (Math.Pow(x, aux) / aux); //Aqui es donde se ejecuta la magia, es la formula traducida en C# (Ver punto A del problema 1)
                    Console.WriteLine("Valor: " + 2*imprime); //Concatenamos el resultado para verlo en pantalla 
                    Console.WriteLine("Iteracion " + i); //Imprimimos iteración
                    Console.WriteLine();
                    Console.WriteLine("___________________________");
                }
                
            }

            //Ejercicio 2

            double arctang(double x, double i)
            {
                double auxiliar = (2 * i) + 1;
                double arctan = Math.Pow(-1,i) *  (Math.Pow(x, auxiliar) / auxiliar); //Es la (formula) serie de arcotangente traducida en c#
                                                                                       //Llamo la función cuando se le da un valor nuevo, y me retorna el valor
                                                                                       //Para usarlo en el acumulador de la funcion Ejercicio2()
                return arctan;
            }

            void Ejercicio2()
            {
                double valormedio = 0; //Inicializamos la variable que nos acumulará los resultados de arcotangente(0.5)
                double valortercio = 0;//Inicializamos la variable que nos acumulará los resultados de arcotangente(0.3333333..)
                double valorres = 0; ///Inicializamos la variable que nos guardará el valor de los resultados para comparar 

                for (int i = 0; i < 5; i++) //For iterador
                {
                    valortercio = valortercio + arctang(0.3333333, i); //Llamamos la función arctan con 0.3333 para que nos retorne elvalor, y estarlo guardando 
                    valormedio = valormedio + arctang(0.5, i);//Llamamos la función arctan con 0.5 para que nos retorne elvalor, y estarlo guardando 
                    valorres = 4 * (valortercio + valormedio); //Lo muliplicamos por 4 para hallar el valor de PI 
                    Console.WriteLine("Valor: " + valorres); //Imprimimo el valor, oara verlo en pantalla
                    Console.WriteLine("Iteración: " + i); //Imprimimos numero de iteraciones
                    Console.WriteLine("__________________________________");
                }

            }

            //Ejercicio 3
            double ValorFuncionNewtonDerivada3(double x)
            {

                double Funcion = (3 * x * (x + 4)) / 2; //Aquí introducimos la derivada, nada más para que reciba el valor de x y te retorne el valor que debe ser
                return Funcion;
            }
            double ValorFuncionNewton3(double x)
            {
                //double Funcion = Math.Pow(x, 3) - x - 1;
                double Funcion = Math.Pow(x, 3) + (6 * Math.Pow(x, 2) - Math.Pow(x, 3)) / 2 - 60; //Aquí introducimos la función, nada más para que reciba el valor de x y retorne el valor que debe ser
                return Funcion;
            }
            void NewtonRaphson(double ValorInicial)
            {
                Console.WriteLine("--Método de Newton Rhapson");
                double p = 0, p0 = 0; //Inicializamos nuestroas variables que guardaran iteracion pasada e iteracion presente
                int Itera = 0; //Contador de iteraciones 
                bool sigue = true; //Booleano que te permite entrar al ciclo while
                p0 = ValorInicial; //Igualamos el valor que damos de incio con el valor de la primera iteracion de p
                while (sigue == true)
                {
                    p = p0 - (ValorFuncionNewton3(p0) / ValorFuncionNewtonDerivada3(p0)); //Aplicamos formula de Newton-Raphson, nos auxiliamos de los metodos de arriba para retornar el valor y hacer op.
                    Console.WriteLine("Valor de p: " + p); //Imprime vista en pantalla de iteracion actual.
                    Console.WriteLine("Valor de p0: " + p0); //Imprime vista en pantalla de iteracion pasada.
                    Console.WriteLine("La diferencia es de: " + Math.Abs(p - p0)); //La diferencia para la precision
                    Console.WriteLine("Número de Iteración: " + Itera); //Imprime numero de iteraciones
                    Console.WriteLine("________________________");
                    if (Math.Abs(p - p0) < 0.0001) //Aquí estamos comparando la precisión del algortimo, entre más 0 les dé, más preciso será.
                    {
                        Console.WriteLine("Tolerancia alcanzada");
                        break;
                    }
                    Itera++;
                    p0 = p;
                }
                Console.WriteLine("La raíz es: " + p); //Imprime resultado final
                Console.WriteLine("Número de Iteraciones es: " + (Itera + 1));
            }


            //Ejercicio 4
            double ValorFuncionNewtonDerivada4(double x)
            {
                //double Funcion = 3 * Math.Pow(x, 2) - 1;
                double Funcion = 12 * Math.Pow(x, 2) - 240 * x + 800;//Aquí introducimos la derivada,nada más para que reciba el parámetro A y haga la operación(Retorna valor)
                return Funcion;
            }
            double ValorFuncionNewton4(double x)
            {
                //double Funcion = Math.Pow(x, 3) - x - 1;
                double Funcion = 4*Math.Pow(x, 3) - (120 *Math.Pow(x, 2)) + 800 * x - 1500; //La fórmula normal para que regrese los valores correctos con un parametro de x
                return Funcion;
            }
            void NewtonRaphson4(double ValorInicial)
            {
                Console.WriteLine("--Método de Newton Rhapson");
                double p = 0, p0 = 0;//Inicializamos nuestroas variables que guardaran iteracion pasada e iteracion presente
                int Itera = 0; //Contador de Iteraciones
                bool sigue = true; //Booleano que da acceso al While
                p0 = ValorInicial; //Igualamos el valor dado por el usuario para empezar a hacer las iteraciones.
                while (sigue == true)
                {
                    p = p0 - (ValorFuncionNewton4(p0) / ValorFuncionNewtonDerivada4(p0));//Aplicamos formula de Newton-Raphson, nos auxiliamos de los metodos de arriba para retornar el valor y hacer operaciones
                    Console.WriteLine("Valor de p: " + p); //Imprimimos valor actual 
                    Console.WriteLine("Valor de p0: " + p0); //Imprimimps valor pasado
                    Console.WriteLine("La diferencia es de: " + Math.Abs(p - p0)); //La diferencia para la precision
                    Console.WriteLine("Número de Iteración: " + Itera); //Imprime numero de iteraciones
                    Console.WriteLine("________________________");
                    if (Math.Abs(p - p0) < 0.0001)//Aquí estamos comparando la precisión del algortimo, entre más 0 les dé, más preciso será.
                    {
                        Console.WriteLine("Tolerancia alcanzada"); //Si ya alcanzó la precisión, se sale del ciclo
                        break;
                    }
                    Itera++;
                    p0 = p;
                }
                Console.WriteLine("La raíz es: " + p); //Imprime resultado final
                Console.WriteLine("Número de Iteraciones es: " + (Itera + 1)); //Itera + 1 porque el algoritmo comenzó en 0
            }
        }
    }
}
