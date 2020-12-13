using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
       
        static void Main(string[] args)
        {
            int Tam = 0, Menu = 0, resp = 0;
            bool Val = true;
            Console.WriteLine("Pablo Díaz Ochoa");
            Console.WriteLine("Matrícula: 030343");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Cuantos usuarios quieres dar de alta?");
            Tam = int.Parse(Console.ReadLine());
            string[] Nombre = new string[Tam];
            string[] Apellidos = new string[Tam];
            double[] TelCasa = new double[Tam];
            double[] TelCel = new double[Tam];
            string[] CorEle = new string[Tam];
            string[] ID = new string[Tam];

            for (int i = 0; i < Tam; i++)
            {
                Console.Clear();
                Console.WriteLine("Ingrese el nombre: (Solo el nombre) ");
                Nombre[i] = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Ingrese los apellidos: ");
                Apellidos[i] = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Ingrese el Telefono de casa: ");
                TelCasa[i] = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine("Ingrese el Celular: ");
                TelCel[i] = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine("Ingrese el Correo Electrónico: ");
                CorEle[i] = Convert.ToString(Console.ReadLine());
                ID[i] = Convert.ToString(i) ;

            }
            Console.WriteLine(" ");
            Console.WriteLine("Datos dados de alta exitosamente");
            Console.ReadKey();
            Console.Clear();

            while (Val == true)
            {
            Console.WriteLine("Menú");
            Console.WriteLine("1-. Borrado de un Contacto");
            Console.WriteLine("2-. Búsqueda de un Contacto");
            Console.WriteLine("3-. Modificar un contacto");
            Console.WriteLine("4-. Ver lista de Contactos");
            Console.WriteLine(" ");
            Menu = int.Parse(Console.ReadLine());
            switch (Menu)
            {
                case 1:
                    string nomborr = "";
                        for (int j = 0; j < Tam; j++)
                        {
                            Console.WriteLine("ID es: " + ID[j]);
                            Console.WriteLine("El Nombre es: " + Nombre[j]);
                            Console.WriteLine("El Telefono de Casa es:" + TelCasa[j]);
                            Console.WriteLine("El Celular es:" + TelCel[j]);
                            Console.WriteLine("El Correo Electronico es:" + CorEle[j]);
                            Console.WriteLine("----------------------------------------------------------------/");
                        }
                        Console.WriteLine("Ingrese el ID de la persona a borrar:");
                    nomborr = Console.ReadLine();
                        Console.Clear();
                    for (int i = 0; i < Tam; i++)
                    {
                        if (nomborr == ID[i])
                        {
                            Nombre[i] = "";
                            Apellidos[i] = "";
                            TelCasa[i] = 0;
                            TelCel[i] = 0;
                            CorEle[i] = "";
                            ID[i] = " ";
                            Console.WriteLine("Persona eliminada correctamente");

                        }
                    }
                break;
                case 2:
                    string nomborr2 = "";
                    Console.WriteLine("Ingrese el nombre de la persona a buscar: (Solo el nombre)");
                    nomborr2 = Console.ReadLine();
                    for (int j = 0; j < Tam; j++)
                    {
                        if (nomborr2 == Nombre[j])
                        {
                            Console.WriteLine("ID es: " + ID[j]);
                            Console.WriteLine("El Nombre es: " + Nombre[j] + " " + Apellidos[j]);
                            Console.WriteLine("El Telefono de Casa es:" + TelCasa[j]);
                            Console.WriteLine("El Celular es:" + TelCel[j]);
                            Console.WriteLine("El Correo Electronico es:" + CorEle[j]);
                                Console.WriteLine("------------------------------------------------------------------------------/");
                        }
                    }
                    break;
                case 3:

                    string nomborr3 = "";
                        for (int j = 0; j < Tam; j++)
                        {
                            Console.WriteLine("ID es: " + ID[j]);
                            Console.WriteLine("El Nombre es: " + Nombre[j]);
                            Console.WriteLine("El Telefono de Casa es:" + TelCasa[j]);
                            Console.WriteLine("El Celular es:" + TelCel[j]);
                            Console.WriteLine("El Correo Electronico es:" + CorEle[j]);
                            Console.WriteLine("----------------------------------------------------------------/");
                        }
                        Console.WriteLine("Ingrese el ID de la persona a modificar: ");
                    nomborr3 = Console.ReadLine();
                    for (int j = 0; j < Tam; j++)
                    {
                        if (nomborr3 == ID[j])
                        {
                            int repp = 0;
                            Console.Clear();
                            Console.WriteLine("Que quieres modificar?");
                            Console.WriteLine("1-. Telefono Casa");
                            Console.WriteLine("2-. Telefono Celular");
                            Console.WriteLine("3-. Correo Electrónico");
                            repp = int.Parse(Console.ReadLine());
                            switch (repp)
                            {
                                
                                case 1:
                                    int nd = 0;
                                    Console.WriteLine("Ingrese el nuevo numero de casa: ");
                                    TelCasa[j] = Convert.ToInt64(Console.ReadLine());
                                        break;
                                case 2:
                                    int nd2 = 0;
                                    Console.WriteLine("Ingrese el nuevo numero de celular: ");
                                    TelCel[j] = Convert.ToInt64(Console.ReadLine());
                                        break;
                                case 3:
                                    string nd3 = "";
                                    Console.WriteLine("Ingrese el nuevo correo electrónico: ");
                                    CorEle[j] = Console.ReadLine();
                                break;
                                default:
                                    Console.WriteLine("No existe ese nombre");
                                break;
                            }

                        }
                    }
                break;
                case 4:
                        for (int j = 0; j < Tam; j++)
                        {
                            if (Nombre[j] == "")
                            {

                            }
                            else
                            {
                                Console.WriteLine("ID es: " + ID[j]);
                                Console.WriteLine("El Nombre es: " + Nombre[j] + " " + Apellidos[j]);
                                Console.WriteLine("El Telefono de Casa es:" + TelCasa[j]);
                                Console.WriteLine("El Celular es:" + TelCel[j]);
                                Console.WriteLine("El Correo Electronico es:" + CorEle[j]);
                                Console.WriteLine("----------------------------------------------------------------/");
                            }
                            
                        }
                        Console.ReadKey();
                        break;
                default:
                    Console.WriteLine(" ");
                    Console.WriteLine("No existe esa opción. CERRANDO PROGRAMA XDXDXD");
                    Console.ReadKey();
                    Environment.Exit(0);
                break;
            }
                Console.WriteLine(" ");
                Console.WriteLine("Quieres regresar al Menú?");
                Console.WriteLine("1-. Si           2-. No");
                resp = int.Parse(Console.ReadLine());
                
                if (resp == 1)
                {
                    Val = true;
                    Console.Clear();
                }
                else
                {
                    Val = false;
                }

            }
            Console.WriteLine("------->Fin del Programa");
            Console.ReadKey();

        }
    }
}
/*for (int j = 0; j < Tam; j++)
           {
               Console.WriteLine("ID es: " + ID[j]);
               Console.WriteLine("El Nombre es: " + Nombre[j]);
               Console.WriteLine("El Telefono de Casa es:" + TelCasa[j]);
               Console.WriteLine("El Celular es:" + TelCel[j]);
               Console.WriteLine("El Correo Electronico es:" + CorEle[j]);
               Console.WriteLine("----------------------------------------------------------------/");
           }
           */
