using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaDeDonChapo
{
    class Program
    {
        public struct Cajero
        {
            public string Nombre;
            public string Direccion;
            public int CodigoPostal;
            public double Telefono;
            public double Celular;
            public string email;
            public string usuario;
            public string contrasena;
        }

        public struct Aparatos
        {
            public int CP;
            public string DES;
            public int CantidadProducto;
            public int StockMinimo;
            public double Precio;
            public bool EstaDescuento;
        }
        public struct Descuentos
        {
            public int ClaveDescuento;
            public double PorcentajeDescuento;
            public string FechaDeRegistro;
            public bool status;
            public int Producto;
            
        }
        public struct Ventas
        {
            public int ClaveVenta;
            public string Usuario;
            public double CantidadProductos;
            public string FechaDeVenta;
            public double Subtotal;
            public double DescuentoTotal;
            public double IVA;
            public double TotalAPagar;
        }


        public static void Main(string[] args)
        {
           
            // Declaramos los productos
            Aparatos[] aparatos = new Aparatos[60];
            aparatos[0].DES = "Laptop HP Pavilion 14.6 120SSD 12GB RAM 1TB";
            aparatos[1].DES = "Notebook HP Pavilion 15-cd005la ";
            aparatos[2].DES = "HP Laptop S1003-1622 de 10.1 Intel Atom Memoria de 2 GB Unidad de estado sólido de 32 GB  Gris";
            aparatos[3].DES = "HP Laptop 14-ck0001la de 14 Celeron UHD 600 Memoria de 4GB Disco duro de 500GB Negro Modelo: 3PX14LA";
            aparatos[4].DES = "HP Laptop 14-ck0014la de 14 Celeron - UHD 600 - Memoria de 4GB - Disco duro de 500GB - Blanco";
            aparatos[5].DES = "HP Laptop Convertible MIIX 320 de 10.1 Intel Atom  Intel HD  Memoria 4GB  Disco duro 32 GB  Plata";
            aparatos[6].DES = "HP Laptop X541NA-GO013T de 15.6 Intel Pentium  Memoria de 4 GB  Disco Duro 500 GB  Plata";
            aparatos[7].DES = "HP Pavilion x360 2-in-1 14 Touch Screen Laptop Intel Core i5 8GB Memory 128GB Solid State Drive";
            aparatos[8].DES = "HP Pavilion x360 2-in-1 11.6 Touch Screen Laptop Intel Pentium 4GB Memory 500GB Hard Drive HP Finish In Natural Silver";
            aparatos[9].DES = "HP Pavilion x360 2-in-1 14 Touch Screen Laptop Intel Core i5 8GB Memory 128GB Solid State Drive HP Sand Blast Matte In Pale Gold Natural Silver";
            aparatos[10].DES = "Laptop Lenovo Ideapad 320 Amd A9 9420 8gb Ram 1tb Ati";
            aparatos[11].DES = "Laptop Lenovo 80XV00A7US AMD A9 4GB RAM 1TB DD";
            aparatos[12].DES = "LAPTOP GAMER LENOVO LEGION Y520 CORE I5 7300 8G 1T GTX1050 15.6 W10";
            aparatos[13].DES = "LAPTOP LENOVO THINK V110 CELERON N3350 4GB 500GB 14";
            aparatos[14].DES = "Laptop Lenovo V110 14, Celeron, 500gb, 2gb (80tf0008)";
            aparatos[15].DES = "Laptop Lenovo IP 120S-14IAP Intel Celeron N3350 2GB RAM 32GB ";
            aparatos[16].DES = "Laptop Lenovo Intel N3350 14 Platinium Grey";
            aparatos[17].DES = "Laptop Lenovo V110 14'', Intel Celeron N3350 1.10GHz, 2GB, 500GB, FreeDOS, Negro";
            aparatos[18].DES = "Laptop Lenovo Ideapad 520S-14IKB, Procesador Intel Core I5 7200U (hasta 3.10 GHz), Memoria De 8GB DDR4, Disco Duro De 1TB, Pantalla De 14";
            aparatos[19].DES = "Laptop 14 Lenovo Ideapad 110-14ibr N3060 4gb 500gb W10h Rojo";
            aparatos[20].DES = "Laptop Lenovo AMD Ryzen 5 2500U 8GB RAM 256GB SSD";
            aparatos[21].DES = "Laptop Lenovo Ideapad 110-15acl A4 500gb 15.6 Hd Windows 10";
            aparatos[22].DES = "Laptop Lenovo 81F500BFLM Intel Core i5-8250U Memoria 4GB RAM 16GB OPTANE 1TB ";
            aparatos[23].DES = "Apple iPhone 5 16GB  Blanco";
            aparatos[24].DES = "Apple iPhone 5 16GB  Gris";
            aparatos[25].DES = "Apple iPhone 5 32GB  Blanco";
            aparatos[26].DES = "Apple iPhone 5 64GB  Rojo";
            aparatos[27].DES = "Apple iPhone 5 16GB  Rosa";
            aparatos[28].DES = "Apple iPhone 5s 16GB  Rosa";
            aparatos[29].DES = "Apple iPhone 5s 16GB  Rojo";
            aparatos[30].DES = "Apple iPhone 5s 64GB  Blanco";
            aparatos[31].DES = "Apple iPhone 5s 32GB  Gris";
            aparatos[32].DES = "Apple iPhone 5s 16GB  Blanco";
            aparatos[33].DES = "Apple iPhone 6 32GB Blanco";
            aparatos[34].DES = "Apple iPhone 6 32GB Gris";
            aparatos[35].DES = "Apple iPhone 6 16GB Rosa";
            aparatos[36].DES = "Apple iPhone 6s 32GB Rosa";
            aparatos[37].DES = "Apple iPhone 6s 16GB Gris";
            aparatos[38].DES = "Apple iPhone 6s 32GB Blanco";
            aparatos[39].DES = "Apple iPhone 6s + 32GB Blanco";
            aparatos[40].DES = "Apple iPhone 6s + 32GB Gris";
            aparatos[41].DES = "Apple iPhone 6s + 32GB Rosa";
            aparatos[42].DES = "Apple iPhone 7 64GB Blanco";
            aparatos[43].DES = "Apple iPhone 7 64GB Gris";
            aparatos[44].DES = "Apple iPhone 7 64GB Rosa";
            aparatos[45].DES = "Apple iPhone 7 64GB Rosa";
            aparatos[46].DES = "Apple iPhone 7s 64GB Rosa";
            aparatos[47].DES = "Apple iPhone 7s 64GB Blanco";
            aparatos[48].DES = "Apple iPhone 7s 64GB Gris";
            aparatos[49].DES = "Apple iPhone 8 64GB Gris";
            aparatos[50].DES = "Apple iPhone 8 64GB Blanco";
            aparatos[51].DES = "Apple iPhone 8 64GB Rosa";
            aparatos[52].DES = "Apple iPhone X 128GB Rosa";
            aparatos[53].DES = "Apple iPhone X 128GB Blanco";
            aparatos[54].DES = "Apple iPhone X 128GB Gris";
            aparatos[55].DES = "";
            aparatos[56].DES = "";
            aparatos[57].DES = "";
            aparatos[58].DES = "";
            aparatos[59].DES = "";

            //Generamos numeros random
            Random NumRan = new Random();
            //Metemos los índices al arreglo
            for (int i = 0; i < aparatos.Length; i++)
            {
                aparatos[i].CP = i;
            }
            //Generamos precios random de 500 a 2000 pesos
            for (int i = 0; i < aparatos.Length; i++)
            {
                aparatos[i].Precio = NumRan.Next(500, 2000);
            }
            //Generamos Cantidad de productos
            for (int i = 0; i < aparatos.Length; i++)
            {
                aparatos[i].CantidadProducto = NumRan.Next(20, 50);
            }
            //Stock Minimo producto
            for (int i = 0; i < aparatos.Length; i++)
            {
                aparatos[i].StockMinimo = NumRan.Next(5, 10);
            }
            Console.WriteLine("Bienvenido a la Tienda del Chapo");
            Cajero[] cajero = new Cajero[4];
            cajero[0].Nombre = "Pablo"; cajero[0].Direccion = "Villa Fontana"; cajero[0].CodigoPostal = 22205; cajero[0].Telefono = 9787310; cajero[0].Celular = 6647098461;
            cajero[0].email = "pdiaz632@hotmail.com"; cajero[0].usuario = "PaDiOc18"; cajero[0].contrasena = "mellamopablo123";
            cajero[1].Nombre = "Adrian"; cajero[1].Direccion = "Villa Fontana"; cajero[1].CodigoPostal = 22210; cajero[1].Telefono = 3654972; cajero[1].Celular = 6642087694;
            cajero[1].email = "smith@gmail.com"; cajero[1].usuario = "AdrySmith"; cajero[1].contrasena = "mellamosmith123";
            cajero[2].Nombre = "Carlos"; cajero[2].Direccion = "Tecate"; cajero[2].CodigoPostal = 23598; cajero[2].Telefono = 8974525; cajero[2].Celular = 6659657614;
            cajero[2].email = "carlos@gmail.com"; cajero[2].usuario = "ElForaneo"; cajero[2].contrasena = "mellamocarlos123";

            //Vacio para inserción de datos
            cajero[3].Nombre = null; cajero[3].Direccion = null; cajero[3].CodigoPostal = 0; cajero[3].Telefono = 0; cajero[3].Celular = 0;
            cajero[3].email = null; cajero[3].usuario = null; cajero[3].contrasena = null;

            //Alta Baja Modificar o mostrar vendedores
            bool estado3 = true;
            while (estado3 == true)
            {
                int k = 0;
                Console.WriteLine("¿Qué desea realizar?  -----------SECCIÓN DE VENDEDORES");
                Console.WriteLine("1-. Alta");
                Console.WriteLine("2-. Baja");
                Console.WriteLine("3-. Modificar");
                Console.WriteLine("4-. Mostrar usuarios");
                k = int.Parse(Console.ReadLine());
                switch (k)
                {
                    case 1:
                        Console.WriteLine("Ingrese el Nombre del nuevo usuario");
                        cajero[3].Nombre = Console.ReadLine();
                        Console.WriteLine("Ingrese Dirección: ");
                        cajero[3].Direccion = Console.ReadLine();
                        Console.WriteLine("Ingrese Codigo postal: ");
                        cajero[3].CodigoPostal = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese Dirección: ");
                        cajero[3].Direccion = Console.ReadLine();
                        Console.WriteLine("Ingrese Telefono: ");
                        cajero[3].Telefono = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese Celular: ");
                        cajero[3].Celular = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese Email: ");
                        cajero[3].email = Console.ReadLine();
                        Console.WriteLine("Ingrese Usuario: ");
                        cajero[3].usuario = Console.ReadLine();
                        Console.WriteLine("Ingrese Contraseña: ");
                        cajero[3].contrasena = Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("A quien quieres eliminar??");
                        Console.WriteLine("1 -. Pablo");
                        Console.WriteLine("2 -. Adrian");
                        Console.WriteLine("3 -. Carlos");
                        int w = 0;
                        w = int.Parse(Console.ReadLine());
                        w = w - 1;
                        cajero[w].Nombre = ""; cajero[w].Direccion = ""; cajero[w].CodigoPostal = 0; cajero[w].Telefono = 0; cajero[w].Celular = 0;
                        cajero[w].email = ""; cajero[w].usuario = ""; cajero[w].contrasena = "";
                        break;
                    case 3:
                        Console.WriteLine("A quien quieres modificar?");
                        Console.WriteLine("1 -. Pablo");
                        Console.WriteLine("2 -. Adrian");
                        Console.WriteLine("3 -. Carlos");
                        int a = 0;
                        a = int.Parse(Console.ReadLine());
                        a = a - 1;
                        Console.WriteLine("Ingrese el Nombre del nuevo usuario");
                        cajero[a].Nombre = Console.ReadLine();
                        Console.WriteLine("Ingrese Dirección: ");
                        cajero[a].Direccion = Console.ReadLine();
                        Console.WriteLine("Ingrese Codigo postal: ");
                        cajero[a].CodigoPostal = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese Dirección: ");
                        cajero[a].Direccion = Console.ReadLine();
                        Console.WriteLine("Ingrese Telefono: ");
                        cajero[a].Telefono = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese Celular: ");
                        cajero[a].Celular = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese Email: ");
                        cajero[a].email = Console.ReadLine();
                        Console.WriteLine("Ingrese Usuario: ");
                        cajero[a].usuario = Console.ReadLine();
                        Console.WriteLine("Ingrese Contraseña: ");
                        cajero[a].contrasena = Console.ReadLine();
                        break;
                    case 4:
                        for (int i = 0; i < cajero.Length; i++)
                        {
                            Console.WriteLine("Nombre: " + cajero[i].Nombre);
                            Console.WriteLine("Dirección: " + cajero[i].Direccion);
                            Console.WriteLine("Código Postal: " + cajero[i].CodigoPostal);
                            Console.WriteLine("Telefono: " + cajero[i].Telefono);
                            Console.WriteLine("Celular " + cajero[i].Celular);
                            Console.WriteLine("Email: " + cajero[i].email);
                            Console.WriteLine("Usuario: " + cajero[i].usuario);
                            Console.WriteLine("Contraseña: " + cajero[i].contrasena);
                            Console.WriteLine("----------------------------------------------------");
                        }
                        break;
                    default:
                        Console.WriteLine("ERROR XDXDXXDXDXD");
                        break;
                }
                int d = 0;
                Console.WriteLine("Alguna otra operacion con los vendedores?");
                Console.WriteLine("1- Si            2- No");
                d = int.Parse(Console.ReadLine());
                if (d == 1)
                {
                    estado3 = true;
                    Console.Clear();
                }
                else
                {
                    estado3 = false;
                    Console.Clear();
                }

            }


            //Inicio de sesión vendedor
            bool estado = true;
            int ControlCiclo = 0;
            int contadorantirango = 55;
            while (estado == true)
            {
                Descuentos[] descuentos = new Descuentos[4];
                descuentos[0].PorcentajeDescuento = 0.25;
                descuentos[1].PorcentajeDescuento = 0.50;
                descuentos[2].PorcentajeDescuento = 0.75;
                descuentos[3].PorcentajeDescuento = 0.90;
                for (int i = 0; i < descuentos.Length; i++)
                {
                    Random x = new Random();                   
                    Console.WriteLine("Presione una tecla para generar los descuentos");
                    Console.ReadKey();
                    descuentos[i].ClaveDescuento = i;
                    Console.WriteLine("Clave: {0}", descuentos[i].ClaveDescuento);
                    Console.WriteLine("Porcentaje de Descuento: {0}%", descuentos[i].PorcentajeDescuento * 100);
                    Console.WriteLine("Ingrese la fecha de registro del descuento: (dd/mm/aa) ");
                    descuentos[i].FechaDeRegistro = Console.ReadLine();
                    Console.WriteLine("Fecha de registro del Descuento: {0}", descuentos[i].FechaDeRegistro + "\n");
                }

                Console.ReadKey();
                int NumCajero = 0;
                Console.WriteLine("¿Que vendedor eres?");
                Console.WriteLine("1 -. Pablo");
                Console.WriteLine("2 -. Adrian");
                Console.WriteLine("3 -. Carlos");
                //Si existe, fierro, si no, nel compa no lo muestre
                if (cajero[3].Nombre != null)
                {
                    Console.WriteLine("4 -. " + cajero[3].Nombre);
                }
                NumCajero = int.Parse(Console.ReadLine());
                //Inicio de sesión
                string Usuario = "";
                string Contra = "";
                Random yapofavo = new Random();
                Console.Clear();
                switch (NumCajero)
                {
                    case 1:
                        Console.WriteLine("Ingrese Usuario: ");
                        Usuario = Console.ReadLine();
                        Console.WriteLine("");
                        Console.WriteLine("Ingrese Contraseña:");
                        Contra = Console.ReadLine();
                        if (Usuario == cajero[0].usuario && Contra == cajero[0].contrasena)
                        {
                            Console.WriteLine("Has ingresado con éxito\nBienvendo " + cajero[0].Nombre);
                            Console.ReadKey();
                            bool estado4 = true;
                            while (estado4 == true)
                            {
                                int k = 0;
                                Console.WriteLine("¿Qué desea realizar?  -----------SECCIÓN DE PRODUCTOS");
                                Console.WriteLine("1-. Alta");
                                Console.WriteLine("2-. Baja");
                                Console.WriteLine("3-. Modificar");
                                Console.WriteLine("4-. Mostrar productos");
                                k = int.Parse(Console.ReadLine());
                                Console.WriteLine("");
                                switch (k)
                                {
                                    case 1:
                                        if (contadorantirango <= 59)
                                        {
                                            aparatos[contadorantirango].CP = contadorantirango;
                                            Console.WriteLine("La clave de este producto es: " + aparatos[contadorantirango].CP);
                                            Console.WriteLine("Ingrese descripción ");
                                            aparatos[contadorantirango].DES = Console.ReadLine();
                                            Console.WriteLine("Ingrese Cantidad disponible: ");
                                            aparatos[contadorantirango].CantidadProducto = int.Parse(Console.ReadLine());
                                            Console.WriteLine("Ingrese Stock Minimo: ");
                                            aparatos[contadorantirango].StockMinimo = int.Parse(Console.ReadLine());
                                            Console.WriteLine("Ingrese Precio: ");
                                            aparatos[contadorantirango].Precio = double.Parse(Console.ReadLine());
                                            contadorantirango++;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Ya no hay espacio para más productos");
                                        }
                                        break;
                                    case 2:
                                        Console.WriteLine("Ingrese Clave de producto a Borrar: ");
                                        int b = 0;
                                        b = int.Parse(Console.ReadLine());
                                        if (b <= 59)
                                        {
                                            aparatos[b].CP = b;
                                            aparatos[b].DES = "";
                                            aparatos[b].CantidadProducto = 0;
                                            aparatos[b].StockMinimo = 0;
                                            aparatos[b].Precio = 0;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Producto no existente");
                                        }
                                        break;
                                    case 3:
                                        Console.WriteLine("A clave de producto a modificar?");
                                        int a = 0;
                                        a = int.Parse(Console.ReadLine());
                                        if (a <= 59)
                                        {
                                            aparatos[a].CP = a;
                                            Console.WriteLine("La clave de este producto es: " + aparatos[a].CP);
                                            Console.WriteLine("Ingrese descripción ");
                                            aparatos[a].DES = Console.ReadLine();
                                            Console.WriteLine("Ingrese Cantidad disponible: ");
                                            aparatos[a].CantidadProducto = int.Parse(Console.ReadLine());
                                            Console.WriteLine("Ingrese Stock Minimo: ");
                                            aparatos[a].StockMinimo = int.Parse(Console.ReadLine());
                                            Console.WriteLine("Ingrese Precio: ");
                                            aparatos[a].Precio = double.Parse(Console.ReadLine());
                                        }
                                        else
                                        {
                                            Console.WriteLine("Producto no existente");
                                        }
                                        break;
                                    case 4:
                                        for (int i = 0; i < aparatos.Length; i++)
                                        {
                                            if (aparatos[i].DES != "")
                                            {
                                                Console.WriteLine("Clave del producto: " + aparatos[i].CP.ToString("##.###.##"));
                                                Console.WriteLine("Descripción: " + aparatos[i].DES);
                                                Console.WriteLine("Cantidad de Producto: " + aparatos[i].CantidadProducto.ToString("##.###.##"));
                                                Console.WriteLine("Stock Minimo: " + aparatos[i].StockMinimo.ToString("##.###.##"));
                                                Console.WriteLine("Precio Unitario: " + aparatos[i].Precio.ToString("##.###.##"));
                                                Console.WriteLine("");
                                            }
                                        }
                                        break;
                                    default:
                                        Console.WriteLine("ERROR");
                                        break;
                                }
                                int d = 0;
                                Console.WriteLine("Alguna otra operacion con los productos?");
                                Console.WriteLine("1- Si            2- No");
                                d = int.Parse(Console.ReadLine());
                                if (d == 1)
                                {
                                    estado4 = true;
                                    Console.Clear();
                                }
                                else
                                {
                                    estado4 = false;
                                    Console.Clear();
                                }
                            }
                            //Ventas
                            Ventas[] ventas = new Ventas[70];
                            bool estadoventa = true;
                            int contadoraux = 0; double totalVendido = 0;
                            while (estadoventa == true)
                            {                              
                                Console.WriteLine("Ingrese la clave del producto a vender");
                                int j = 0;
                                j = int.Parse(Console.ReadLine());
                                Console.WriteLine("Ingrese la cantidad de producto");
                                int g = 0;
                                g = int.Parse(Console.ReadLine());
                                //Aquí va el proceso de venta
                                contadoraux = ventas[contadoraux].ClaveVenta;
                                Console.WriteLine("La clave de venta es: " + contadoraux);
                                Console.WriteLine("El producto vendido es " + aparatos[j].DES);
                                Console.WriteLine("El Precio es: " + aparatos[j].Precio);
                                Console.WriteLine("La cantidad vendida fue: " + g);
                                Console.WriteLine("Ingrese la fecha de venta (dd/mm/aa): ");
                                string k = Console.ReadLine();
                                ventas[contadoraux].FechaDeVenta = k;
                                Console.WriteLine("Tiene descuento de: " + descuentos[yapofavo.Next(0,3)].PorcentajeDescuento * 100 + "%");
                                double subtotal = 0; double aux = 0;
                                aux = aparatos[j].Precio * descuentos[yapofavo.Next(0,6)].PorcentajeDescuento;
                                subtotal = aparatos[j].Precio - aux;
                                Console.WriteLine("El subtotal es: " + subtotal);
                                subtotal = subtotal * 1.16;
                                Console.WriteLine("Precio con el 16% de IVA: " + subtotal);
                                double TotalT = 0;
                                TotalT = (g * subtotal);
                                Console.WriteLine("El total de la venta es: " + TotalT);
                                totalVendido = totalVendido + TotalT;
                                Console.WriteLine("Quieres ejecutar otra venta?");
                                Console.WriteLine("1- Si            2- No");
                                int f = 0;
                                f = int.Parse(Console.ReadLine());
                                if (f == 1)
                                {
                                    estadoventa = true;
                                }
                                else
                                {
                                    Console.WriteLine("Vendedor: " + cajero[0].Nombre);
                                    Console.WriteLine("Vendió: " + totalVendido.ToString("##,###.##"));
                                    totalVendido = 0;
                                    Console.ReadKey();
                                    estadoventa = false;

                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Contraseña Incorrecta y/o usuario incorrecto");
                            Console.ReadKey();
                            Environment.Exit(0);
                        }
                        break;
                    case 2:
                        Console.WriteLine("Ingrese Usuario: ");
                        Usuario = Console.ReadLine();
                        Console.WriteLine("");
                        Console.WriteLine("Ingrese Contraseña:");
                        Contra = Console.ReadLine();
                        if (Usuario == cajero[1].usuario && Contra == cajero[1].contrasena)
                        {
                            Console.WriteLine("Has ingresado con éxito\nBienvendo " + cajero[1].Nombre);
                            Console.ReadKey();
                            bool estado4 = true;
                            while (estado4 == true)
                            {
                                int k = 0;
                                Console.WriteLine("¿Qué desea realizar?  -----------SECCIÓN DE PRODUCTOS");
                                Console.WriteLine("1-. Alta");
                                Console.WriteLine("2-. Baja");
                                Console.WriteLine("3-. Modificar");
                                Console.WriteLine("4-. Mostrar productos");
                                k = int.Parse(Console.ReadLine());
                                Console.WriteLine("");
                                switch (k)
                                {
                                    case 1:
                                        if (contadorantirango <= 59)
                                        {
                                            aparatos[contadorantirango].CP = contadorantirango;
                                            Console.WriteLine("La clave de este producto es: " + aparatos[contadorantirango].CP);
                                            Console.WriteLine("Ingrese descripción ");
                                            aparatos[contadorantirango].DES = Console.ReadLine();
                                            Console.WriteLine("Ingrese Cantidad disponible: ");
                                            aparatos[contadorantirango].CantidadProducto = int.Parse(Console.ReadLine());
                                            Console.WriteLine("Ingrese Stock Minimo: ");
                                            aparatos[contadorantirango].StockMinimo = int.Parse(Console.ReadLine());
                                            Console.WriteLine("Ingrese Precio: ");
                                            aparatos[contadorantirango].Precio = double.Parse(Console.ReadLine());
                                            contadorantirango++;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Ya no hay espacio para más productos");
                                        }
                                        break;
                                    case 2:
                                        Console.WriteLine("Ingrese Clave de producto a Borrar: ");
                                        int b = 0;
                                        b = int.Parse(Console.ReadLine());
                                        if (b <= 59)
                                        {
                                            aparatos[b].CP = b;
                                            aparatos[b].DES = "";
                                            aparatos[b].CantidadProducto = 0;
                                            aparatos[b].StockMinimo = 0;
                                            aparatos[b].Precio = 0;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Producto no existente");
                                        }
                                        break;
                                    case 3:
                                        Console.WriteLine("A clave de producto a modificar?");
                                        int a = 0;
                                        a = int.Parse(Console.ReadLine());
                                        if (a <= 59)
                                        {
                                            aparatos[a].CP = a;
                                            Console.WriteLine("La clave de este producto es: " + aparatos[a].CP);
                                            Console.WriteLine("Ingrese descripción ");
                                            aparatos[a].DES = Console.ReadLine();
                                            Console.WriteLine("Ingrese Cantidad disponible: ");
                                            aparatos[a].CantidadProducto = int.Parse(Console.ReadLine());
                                            Console.WriteLine("Ingrese Stock Minimo: ");
                                            aparatos[a].StockMinimo = int.Parse(Console.ReadLine());
                                            Console.WriteLine("Ingrese Precio: ");
                                            aparatos[a].Precio = double.Parse(Console.ReadLine());
                                        }
                                        else
                                        {
                                            Console.WriteLine("Producto no existente");
                                        }
                                        break;
                                    case 4:
                                        for (int i = 0; i < aparatos.Length; i++)
                                        {
                                            if (aparatos[i].DES != "")
                                            {
                                                Console.WriteLine("Clave del producto: " + aparatos[i].CP.ToString("##.###.##"));
                                                Console.WriteLine("Descripción: " + aparatos[i].DES);
                                                Console.WriteLine("Cantidad de Producto: " + aparatos[i].CantidadProducto.ToString("##.###.##"));
                                                Console.WriteLine("Stock Minimo: " + aparatos[i].StockMinimo.ToString("##.###.##"));
                                                Console.WriteLine("Precio Unitario: " + aparatos[i].Precio.ToString("##.###.##"));
                                                Console.WriteLine("");
                                            }
                                        }
                                        break;
                                    default:
                                        Console.WriteLine("ERROR");
                                        break;
                                }
                                int d = 0;
                                Console.WriteLine("Alguna otra operacion con los productos?");
                                Console.WriteLine("1- Si            2- No");
                                d = int.Parse(Console.ReadLine());
                                if (d == 1)
                                {
                                    estado4 = true;
                                    Console.Clear();
                                }
                                else
                                {
                                    estado4 = false;
                                    Console.Clear();
                                }
                            }
                            //Ventas
                            Ventas[] ventas = new Ventas[70];
                            bool estadoventa = true;
                            int contadoraux = 0; double totalVendido = 0;
                            while (estadoventa == true)
                            {
                                Console.WriteLine("Ingrese la clave del producto a vender");
                                int j = 0;
                                j = int.Parse(Console.ReadLine());
                                Console.WriteLine("Ingrese la cantidad de producto");
                                int g = 0;
                                g = int.Parse(Console.ReadLine());
                                //Aquí va el proceso de venta
                                contadoraux = ventas[contadoraux].ClaveVenta;
                                Console.WriteLine("La clave de venta es: " + contadoraux);
                                Console.WriteLine("El producto vendido es " + aparatos[j].DES);
                                Console.WriteLine("El Precio es: " + aparatos[j].Precio);
                                Console.WriteLine("La cantidad vendida fue: " + g);
                                Console.WriteLine("Ingrese la fecha de venta (dd/mm/aa): ");
                                string k = Console.ReadLine();
                                ventas[contadoraux].FechaDeVenta = k;
                                Console.WriteLine("Tiene descuento de: " + descuentos[yapofavo.Next(0, 3)].PorcentajeDescuento * 100 + "%");
                                double subtotal = 0; double aux = 0;
                                aux = aparatos[j].Precio * descuentos[j].PorcentajeDescuento;
                                subtotal = aparatos[j].Precio - aux;
                                Console.WriteLine("El subtotal es: " + subtotal);
                                subtotal = subtotal * 1.16;
                                Console.WriteLine("Precio con el 16% de IVA: " + subtotal);
                                double TotalT = 0;
                                TotalT = (g * subtotal);
                                Console.WriteLine("El total de la venta es: " + TotalT);
                                totalVendido = totalVendido + TotalT;
                                Console.WriteLine("Quieres ejecutar otra venta?");
                                Console.WriteLine("1- Si            2- No");
                                int f = 0;
                                f = int.Parse(Console.ReadLine());
                                if (f == 1)
                                {
                                    estadoventa = true;
                                }
                                else
                                {
                                    Console.WriteLine("Vendedor: " + cajero[1].Nombre);
                                    Console.WriteLine("Vendió: " + totalVendido.ToString("##,###.##"));
                                    totalVendido = 0;
                                    Console.ReadKey();
                                    estadoventa = false;

                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Contraseña Incorrecta y/o usuario incorrecto");
                            Console.ReadKey();
                            Environment.Exit(0);
                        }
                        break;
                    case 3:
                        Console.WriteLine("Ingrese Usuario: ");
                        Usuario = Console.ReadLine();
                        Console.WriteLine("");
                        Console.WriteLine("Ingrese Contraseña:");
                        Contra = Console.ReadLine();
                        if (Usuario == cajero[2].usuario && Contra == cajero[2].contrasena)
                        {
                            Console.WriteLine("Has ingresado con éxito\nBienvendo " + cajero[2].Nombre);
                            Console.ReadKey();
                            bool estado4 = true;
                            while (estado4 == true)
                            {
                                int k = 0;
                                Console.WriteLine("¿Qué desea realizar?  -----------SECCIÓN DE PRODUCTOS");
                                Console.WriteLine("1-. Alta");
                                Console.WriteLine("2-. Baja");
                                Console.WriteLine("3-. Modificar");
                                Console.WriteLine("4-. Mostrar productos");
                                k = int.Parse(Console.ReadLine());
                                Console.WriteLine("");
                                switch (k)
                                {
                                    case 1:
                                        if (contadorantirango <= 59)
                                        {
                                            aparatos[contadorantirango].CP = contadorantirango;
                                            Console.WriteLine("La clave de este producto es: " + aparatos[contadorantirango].CP);
                                            Console.WriteLine("Ingrese descripción ");
                                            aparatos[contadorantirango].DES = Console.ReadLine();
                                            Console.WriteLine("Ingrese Cantidad disponible: ");
                                            aparatos[contadorantirango].CantidadProducto = int.Parse(Console.ReadLine());
                                            Console.WriteLine("Ingrese Stock Minimo: ");
                                            aparatos[contadorantirango].StockMinimo = int.Parse(Console.ReadLine());
                                            Console.WriteLine("Ingrese Precio: ");
                                            aparatos[contadorantirango].Precio = double.Parse(Console.ReadLine());
                                            contadorantirango++;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Ya no hay espacio para más productos");
                                        }
                                        break;
                                    case 2:
                                        Console.WriteLine("Ingrese Clave de producto a Borrar: ");
                                        int b = 0;
                                        b = int.Parse(Console.ReadLine());
                                        if (b <= 59)
                                        {
                                            aparatos[b].CP = b;
                                            aparatos[b].DES = "";
                                            aparatos[b].CantidadProducto = 0;
                                            aparatos[b].StockMinimo = 0;
                                            aparatos[b].Precio = 0;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Producto no existente");
                                        }
                                        break;
                                    case 3:
                                        Console.WriteLine("A clave de producto a modificar?");
                                        int a = 0;
                                        a = int.Parse(Console.ReadLine());
                                        if (a <= 59)
                                        {
                                            aparatos[a].CP = a;
                                            Console.WriteLine("La clave de este producto es: " + aparatos[a].CP);
                                            Console.WriteLine("Ingrese descripción ");
                                            aparatos[a].DES = Console.ReadLine();
                                            Console.WriteLine("Ingrese Cantidad disponible: ");
                                            aparatos[a].CantidadProducto = int.Parse(Console.ReadLine());
                                            Console.WriteLine("Ingrese Stock Minimo: ");
                                            aparatos[a].StockMinimo = int.Parse(Console.ReadLine());
                                            Console.WriteLine("Ingrese Precio: ");
                                            aparatos[a].Precio = double.Parse(Console.ReadLine());
                                        }
                                        else
                                        {
                                            Console.WriteLine("Producto no existente");
                                        }
                                        break;
                                    case 4:
                                        for (int i = 0; i < aparatos.Length; i++)
                                        {
                                            if (aparatos[i].DES != "")
                                            {
                                                Console.WriteLine("Clave del producto: " + aparatos[i].CP.ToString("##.###.##"));
                                                Console.WriteLine("Descripción: " + aparatos[i].DES);
                                                Console.WriteLine("Cantidad de Producto: " + aparatos[i].CantidadProducto.ToString("##.###.##"));
                                                Console.WriteLine("Stock Minimo: " + aparatos[i].StockMinimo.ToString("##.###.##"));
                                                Console.WriteLine("Precio Unitario: " + aparatos[i].Precio.ToString("##.###.##"));
                                                Console.WriteLine("");
                                            }
                                        }
                                        break;
                                    default:
                                        Console.WriteLine("ERROR");
                                        break;
                                }
                                int d = 0;
                                Console.WriteLine("Alguna otra operacion con los productos?");
                                Console.WriteLine("1- Si            2- No");
                                d = int.Parse(Console.ReadLine());
                                if (d == 1)
                                {
                                    estado4 = true;
                                    Console.Clear();
                                }
                                else
                                {
                                    estado4 = false;
                                    Console.Clear();
                                }
                            }
                            //Ventas
                            Ventas[] ventas = new Ventas[70];
                            bool estadoventa = true;
                            int contadoraux = 0; double totalVendido = 0;
                            while (estadoventa == true)
                            {
                                Console.WriteLine("Ingrese la clave del producto a vender");
                                int j = 0;
                                j = int.Parse(Console.ReadLine());
                                Console.WriteLine("Ingrese la cantidad de producto");
                                int g = 0;
                                g = int.Parse(Console.ReadLine());
                                //Aquí va el proceso de venta
                                contadoraux = ventas[contadoraux].ClaveVenta;
                                Console.WriteLine("La clave de venta es: " + contadoraux);
                                Console.WriteLine("El producto vendido es " + aparatos[j].DES);
                                Console.WriteLine("El Precio es: " + aparatos[j].Precio);
                                Console.WriteLine("La cantidad vendida fue: " + g);
                                Console.WriteLine("Ingrese la fecha de venta (dd/mm/aa): ");
                                string k = Console.ReadLine();
                                ventas[contadoraux].FechaDeVenta = k;
                                Console.WriteLine("Tiene descuento de: " + descuentos[yapofavo.Next(0, 3)].PorcentajeDescuento * 100 + "%");
                                double subtotal = 0; double aux = 0;
                                aux = aparatos[j].Precio * descuentos[j].PorcentajeDescuento;
                                subtotal = aparatos[j].Precio - aux;
                                Console.WriteLine("El subtotal es: " + subtotal);
                                subtotal = subtotal * 1.16;
                                Console.WriteLine("Precio con el 16% de IVA: " + subtotal);
                                double TotalT = 0;
                                TotalT = (g * subtotal);
                                Console.WriteLine("El total de la venta es: " + TotalT);
                                totalVendido = totalVendido + TotalT;
                                Console.WriteLine("Quieres ejecutar otra venta?");
                                Console.WriteLine("1- Si            2- No");
                                int f = 0;
                                f = int.Parse(Console.ReadLine());
                                if (f == 1)
                                {
                                    estadoventa = true;
                                }
                                else
                                {
                                    Console.WriteLine("Vendedor: " + cajero[2].Nombre);
                                    Console.WriteLine("Vendió: " + totalVendido.ToString("##,###.##"));
                                    totalVendido = 0;
                                    Console.ReadKey();
                                    estadoventa = false;

                                }
                            }
                            
                        }
                        else
                        {
                            Console.WriteLine("Contraseña Incorrecta y/o usuario incorrecto");
                            Console.ReadKey();
                            Environment.Exit(0);
                        }
                        break;
                    case 4:
                        Console.WriteLine("Ingrese Usuario: ");
                        Usuario = Console.ReadLine();
                        Console.WriteLine("");
                        Console.WriteLine("Ingrese Contraseña:");
                        Contra = Console.ReadLine();
                        if (Usuario == cajero[3].usuario && Contra == cajero[3].contrasena)
                        {
                            Console.WriteLine("Has ingresado con éxito\nBienvendo " + cajero[3].Nombre);
                            Console.ReadKey();
                            bool estado4 = true;
                            while (estado4 == true)
                            {
                                int k = 0;
                                Console.WriteLine("¿Qué desea realizar?  -----------SECCIÓN DE PRODUCTOS");
                                Console.WriteLine("1-. Alta");
                                Console.WriteLine("2-. Baja");
                                Console.WriteLine("3-. Modificar");
                                Console.WriteLine("4-. Mostrar productos");
                                k = int.Parse(Console.ReadLine());
                                Console.WriteLine("");
                                switch (k)
                                {
                                    case 1:
                                        if (contadorantirango <= 59)
                                        {
                                            aparatos[contadorantirango].CP = contadorantirango;
                                            Console.WriteLine("La clave de este producto es: " + aparatos[contadorantirango].CP);
                                            Console.WriteLine("Ingrese descripción ");
                                            aparatos[contadorantirango].DES = Console.ReadLine();
                                            Console.WriteLine("Ingrese Cantidad disponible: ");
                                            aparatos[contadorantirango].CantidadProducto = int.Parse(Console.ReadLine());
                                            Console.WriteLine("Ingrese Stock Minimo: ");
                                            aparatos[contadorantirango].StockMinimo = int.Parse(Console.ReadLine());
                                            Console.WriteLine("Ingrese Precio: ");
                                            aparatos[contadorantirango].Precio = double.Parse(Console.ReadLine());
                                            contadorantirango++;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Ya no hay espacio para más productos");
                                        }
                                        break;
                                    case 2:
                                        Console.WriteLine("Ingrese Clave de producto a Borrar: ");
                                        int b = 0;
                                        b = int.Parse(Console.ReadLine());
                                        if (b <= 59)
                                        {
                                            aparatos[b].CP = b;
                                            aparatos[b].DES = "";
                                            aparatos[b].CantidadProducto = 0;
                                            aparatos[b].StockMinimo = 0;
                                            aparatos[b].Precio = 0;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Producto no existente");
                                        }
                                        break;
                                    case 3:
                                        Console.WriteLine("A clave de producto a modificar?");
                                        int a = 0;
                                        a = int.Parse(Console.ReadLine());
                                        if (a <= 59)
                                        {
                                            aparatos[a].CP = a;
                                            Console.WriteLine("La clave de este producto es: " + aparatos[a].CP);
                                            Console.WriteLine("Ingrese descripción ");
                                            aparatos[a].DES = Console.ReadLine();
                                            Console.WriteLine("Ingrese Cantidad disponible: ");
                                            aparatos[a].CantidadProducto = int.Parse(Console.ReadLine());
                                            Console.WriteLine("Ingrese Stock Minimo: ");
                                            aparatos[a].StockMinimo = int.Parse(Console.ReadLine());
                                            Console.WriteLine("Ingrese Precio: ");
                                            aparatos[a].Precio = double.Parse(Console.ReadLine());
                                        }
                                        else
                                        {
                                            Console.WriteLine("Producto no existente");
                                        }
                                        break;
                                    case 4:
                                        for (int i = 0; i < aparatos.Length; i++)
                                        {
                                            if (aparatos[i].DES != "")
                                            {
                                                Console.WriteLine("Clave del producto: " + aparatos[i].CP.ToString("##.###.##"));
                                                Console.WriteLine("Descripción: " + aparatos[i].DES);
                                                Console.WriteLine("Cantidad de Producto: " + aparatos[i].CantidadProducto.ToString("##.###.##"));
                                                Console.WriteLine("Stock Minimo: " + aparatos[i].StockMinimo.ToString("##.###.##"));
                                                Console.WriteLine("Precio Unitario: " + aparatos[i].Precio.ToString("##.###.##"));
                                                Console.WriteLine("");
                                            }
                                        }
                                        break;
                                    default:
                                        Console.WriteLine("ERROR");
                                        break;
                                }
                                int d = 0;
                                Console.WriteLine("Alguna otra operacion con los productos?");
                                Console.WriteLine("1- Si            2- No");
                                d = int.Parse(Console.ReadLine());
                                if (d == 1)
                                {
                                    estado4 = true;
                                    Console.Clear();
                                }
                                else
                                {
                                    estado4 = false;
                                    Console.Clear();
                                }
                            }
                            //Ventas
                            Ventas[] ventas = new Ventas[70];
                            bool estadoventa = true;
                            int contadoraux = 0; double totalVendido = 0;
                            while (estadoventa == true)
                            {
                                Console.WriteLine("Ingrese la clave del producto a vender");
                                int j = 0;
                                j = int.Parse(Console.ReadLine());
                                Console.WriteLine("Ingrese la cantidad de producto");
                                int g = 0;
                                g = int.Parse(Console.ReadLine());
                                //Aquí va el proceso de venta
                                contadoraux = ventas[contadoraux].ClaveVenta;
                                Console.WriteLine("La clave de venta es: " + contadoraux);
                                Console.WriteLine("El producto vendido es " + aparatos[j].DES);
                                Console.WriteLine("El Precio es: " + aparatos[j].Precio);
                                Console.WriteLine("La cantidad vendida fue: " + g);
                                Console.WriteLine("Ingrese la fecha de venta (dd/mm/aa): ");
                                string k = Console.ReadLine();
                                ventas[contadoraux].FechaDeVenta = k;
                                Console.WriteLine("Tiene descuento de: " + descuentos[yapofavo.Next(0, 3)].PorcentajeDescuento * 100 + "%");
                                double subtotal = 0; double aux = 0;
                                aux = aparatos[j].Precio * descuentos[j].PorcentajeDescuento;
                                subtotal = aparatos[j].Precio - aux;
                                Console.WriteLine("El subtotal es: " + subtotal);
                                subtotal = subtotal * 1.16;
                                Console.WriteLine("Precio con el 16% de IVA: " + subtotal);
                                double TotalT = 0;
                                TotalT = (g * subtotal);
                                Console.WriteLine("El total de la venta es: " + TotalT);
                                totalVendido = totalVendido + TotalT;
                                Console.WriteLine("Quieres ejecutar otra venta?");
                                Console.WriteLine("1- Si            2- No");
                                int f = 0;
                                f = int.Parse(Console.ReadLine());
                                if (f == 1)
                                {
                                    estadoventa = true;
                                }
                                else
                                {
                                    Console.WriteLine("Vendedor: " + cajero[3].Nombre);
                                    Console.WriteLine("Vendió: " + totalVendido.ToString("##,###.##"));
                                    totalVendido = 0;
                                    Console.ReadKey();
                                    estadoventa = false;

                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Contraseña Incorrecta y/o usuario incorrecto");
                            Console.ReadKey();
                            Environment.Exit(0);
                        }
                        break;
                    default:
                        Console.WriteLine("Nombre mijo, no sabes leer 3 números, ni para que me ejecuto, bai xdxdxdxd");
                        Console.ReadKey();
                        Environment.Exit(0);
                        break;
                }
                Console.WriteLine("Quiere cambiar de Vendedor?");
                Console.WriteLine("1-. Si       2-. No");
                ControlCiclo = int.Parse(Console.ReadLine());
                if (ControlCiclo == 1)
                {
                    estado = true;
                    Usuario = "";
                    Contra = "";
                    //Aqui van a ir las ventas totales de ese vendedor
                    Console.Clear();
                }
                else
                {
                    estado = false;
                    Console.WriteLine("aDiOs xdxdxd");
                    Console.ReadKey();
                }
            }        
        }
    }
}