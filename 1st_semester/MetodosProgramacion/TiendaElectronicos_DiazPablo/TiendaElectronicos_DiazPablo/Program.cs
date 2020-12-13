using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaElectronicos_DiazPablo
{
    class Program
    {
        public struct Aparatos
        {
            public int CP;
            public string DES;
            public int CAN;
            public double COSU;
            public double DESCUENTO;
            public double DESCUENTOMULTIPLICACION;
            public int CONTROLDESCUENTO;
            public double PRECIOCONDESCUENTO;
            public int VENTAS;
        }
        static void Main()
        {
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
            aparatos[55].DES = "Apple iPhone Xs 128GB Blanco";
            aparatos[56].DES = "Apple iPhone Xs 128GB Gris";
            aparatos[57].DES = "Samsung Galaxy Note 8 64gb Negro";
            aparatos[58].DES = "Samsung Galaxy Note 5 32gb Blanco";
            aparatos[59].DES = "HTC 10 Negro";
            aparatos[0].DESCUENTOMULTIPLICACION = 0.25;
            aparatos[1].DESCUENTOMULTIPLICACION = 0.75;
            aparatos[2].DESCUENTOMULTIPLICACION = 0.50;
            Random Numero = new Random();
            int num2 =0, num3=0;
            //Ingresar Clave del Producto
            for (int i = 0; i < aparatos.Length; i++)
            {
                aparatos[i].CP = i;
            }
            //Ingresar Cantidad
            for (int i = 0; i < aparatos.Length; i++)
            {
                num2 = Numero.Next(1, 50);
                aparatos[i].CAN = num2;
            }
            //Ingresar Precio
            for (int i = 0; i < aparatos.Length; i++)
            {
                num3 = Numero.Next(2500, 14000);
                aparatos[i].COSU = num3;
            }
            bool estado = true;
            int resp = 0;
            int op = 0;
            int contadordescuentos = 0;
            double ACUMVENTAS = 0, ACUMDESCUENTOS = 0, VAux = 0, VAux2=0;
            while (estado == true)
            {
                Console.WriteLine("Tienda de Electronica Chida");
                Console.WriteLine("1-. Mostrar Artículos");
                Console.WriteLine("2-. Aplicar Descuentos");
                Console.WriteLine("3-. Ver Promociones");
                Console.WriteLine("4-. Comprar ");
                Console.WriteLine("5-. Ver ventas");
                Console.WriteLine("6-. Salir");
                op = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (op)
                {
                    case 1:
                        for (int i = 0; i < 25; i++)
                        {
                            int m = 0;
                            m = Numero.Next(0, 60);
                            if (aparatos[m].PRECIOCONDESCUENTO != 0)
                            {
                                Console.WriteLine("Clave del producto: " + aparatos[m].CP);
                                Console.WriteLine("Descripción del producto: " + aparatos[m].DES);
                                Console.WriteLine("Cantidad del producto: " + aparatos[m].CAN);
                                Console.WriteLine("Cantidad de descuento: " + (aparatos[m].DESCUENTO) * 100 + "%");
                                Console.WriteLine("Costo del producto sin descuento: " + aparatos[m].COSU.ToString("$"+"##,###.##"));
                                Console.WriteLine("Costo del producto con descuento: " + aparatos[m].PRECIOCONDESCUENTO.ToString("$"+"##,###.##"));
                                Console.WriteLine(" ");

                            }
                            else
                            {
                                Console.WriteLine("Clave del producto: " + aparatos[m].CP);
                                Console.WriteLine("Descripción del producto: " + aparatos[m].DES);
                                Console.WriteLine("Cantidad del producto: " + aparatos[m].CAN);
                                Console.WriteLine("Costo del producto: " + aparatos[m].COSU.ToString("$" +"##,###.##"));
                                Console.WriteLine(" ");
                            }
                        }
                        break;
                    case 2:
                        int cde = 0;
                        double aux = 0;
                        for (int i = 0; i < 10; i++)
                        {
                            int MultiDes= 0, AQuienLeToque=0;
                            MultiDes = Numero.Next(0,3);
                            AQuienLeToque = Numero.Next(0,60);
                            if (aparatos[AQuienLeToque].CONTROLDESCUENTO != 1)
                            {
                                aparatos[AQuienLeToque].CONTROLDESCUENTO = 1;
                                aparatos[AQuienLeToque].DESCUENTO = aparatos[MultiDes].DESCUENTOMULTIPLICACION;
                                aux = aparatos[AQuienLeToque].DESCUENTO * aparatos[AQuienLeToque].COSU;
                                aparatos[AQuienLeToque].PRECIOCONDESCUENTO = aparatos[AQuienLeToque].COSU - aux;
                                contadordescuentos = contadordescuentos + 1;
                                cde = cde + 1;
                            }
                            else
                            {
                            }
                        }
                        Console.WriteLine("Descuentos Aplicados con Éxito");
                        Console.WriteLine("Los descuentos aplicados fueron: " + cde);
                        Console.WriteLine("Los descuentos totales son: " + contadordescuentos);
                        break;
                    case 3:
                        for (int i = 0; i < aparatos.Length; i++)
                        {
                            if (aparatos[i].CONTROLDESCUENTO == 1)
                            {
                                Console.WriteLine("Clave del producto: " + aparatos[i].CP);
                                Console.WriteLine("Descripción del producto: " + aparatos[i].DES);
                                Console.WriteLine("Cantidad del producto: " + aparatos[i].CAN);
                                Console.WriteLine("Descuento: " + (aparatos[i].DESCUENTO) * 100 + "%");
                                Console.WriteLine("Costo del producto sin descuento: " + aparatos[i].COSU.ToString("$"+"##,###.##"));
                                Console.WriteLine("Costo del producto con descuento: " + aparatos[i].PRECIOCONDESCUENTO.ToString("$"+"##,###.##"));
                                Console.WriteLine(" ");
                            }
                        }
                        break;
                    case 4:
                        int NumComprando = 0, CanProducto = 0;
                        NumComprando = Numero.Next(0,60);
                        CanProducto = Numero.Next(1,6);
                        double aux2 = 0;
                        for (int i = 0; i < aparatos.Length; i++)
                        {
                            if (aparatos[NumComprando].CP == i)
                            {
                                if (aparatos[NumComprando].CAN >= CanProducto)
                                {
                                    if (aparatos[NumComprando].PRECIOCONDESCUENTO != 0)
                                    {
                                        Console.WriteLine("Comprando " + CanProducto + " productos de el producto: " + aparatos[NumComprando].CP);
                                        Console.WriteLine("Descripcion: " + aparatos[NumComprando].DES);
                                        Console.WriteLine("Cantidad en existencia: " + aparatos[NumComprando].CAN);
                                        Console.WriteLine("Este artículo cuenta con " + aparatos[NumComprando].DESCUENTO*100 +"% de descuento!!");
                                        Console.WriteLine("Precio sin descuento: " + aparatos[NumComprando].COSU.ToString("$" + "##,###.##"));
                                        Console.WriteLine("Precio con descuento: " + aparatos[NumComprando].PRECIOCONDESCUENTO.ToString("$" + "##,###.##"));
                                        aux2 = CanProducto * aparatos[NumComprando].PRECIOCONDESCUENTO;
                                        Console.WriteLine("Precio Total: " + aux2.ToString("$" + "##,###.##"));
                                        aparatos[NumComprando].CAN = aparatos[NumComprando].CAN - CanProducto;
                                        aparatos[NumComprando].VENTAS = aparatos[NumComprando].VENTAS + CanProducto;
                                        if (aparatos[NumComprando].CAN < 0)
                                        {
                                            Console.WriteLine("No hay productos suficientes");
                                            aparatos[NumComprando].CAN = aparatos[NumComprando].CAN + CanProducto;
                                            aparatos[NumComprando].VENTAS = aparatos[NumComprando].VENTAS - CanProducto;
                                        }
                                        Console.WriteLine("En bodega quedan: " + aparatos[NumComprando].CAN);
                                    }
                                    else
                                    {

                                        Console.WriteLine("Comprando " + CanProducto + " productos de el producto: " + aparatos[NumComprando].CP);
                                        Console.WriteLine("Descripcion: " + aparatos[NumComprando].DES);
                                        Console.WriteLine("Cantidad en existencia: " + aparatos[NumComprando].CAN);
                                        Console.WriteLine("Este artículo no cuenta con descuento :( ");
                                        Console.WriteLine("Precio Unitario: " + aparatos[NumComprando].COSU.ToString("$" + "##,###.##"));
                                        aux2 = CanProducto * aparatos[NumComprando].COSU;
                                        Console.WriteLine("Precio Total: " + aux2.ToString("$" + "##,###.##"));
                                        aparatos[NumComprando].CAN = aparatos[NumComprando].CAN - CanProducto;
                                        aparatos[NumComprando].VENTAS = aparatos[NumComprando].VENTAS + CanProducto;
                                        if (aparatos[NumComprando].CAN < 0)
                                        {
                                            Console.WriteLine("No hay productos suficientes");
                                            aparatos[NumComprando].CAN = aparatos[NumComprando].CAN + CanProducto;
                                            aparatos[NumComprando].VENTAS = aparatos[NumComprando].VENTAS - CanProducto;
                                        }
                                        Console.WriteLine("En bodega quedan: " + aparatos[NumComprando].CAN);

                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Comprando " + CanProducto + " productos de el producto: " + aparatos[NumComprando].CP);
                                    Console.WriteLine("Descripcion: " + aparatos[NumComprando].DES);
                                    Console.WriteLine("Cantidad en existencia: " + aparatos[NumComprando].CAN);
                                    Console.WriteLine("Precio Unitario: " + aparatos[NumComprando].PRECIOCONDESCUENTO.ToString("$" + "##,###.##"));
                                    Console.WriteLine("No hay suficientes productos en la bodega, llora plox");
                                }

                            }
                            
                        }
                        break;
                    case 5:
                        Console.WriteLine("VENTAS REALIZADAS");
                        for (int i = 0; i < aparatos.Length; i++)
                        {
                            if (aparatos[i].VENTAS != 0)
                            {
                                if (aparatos[i].CONTROLDESCUENTO == 1)
                                {
                                    Console.WriteLine("Clave del producto: " + aparatos[i].CP);
                                    Console.WriteLine("Descripción del producto: " + aparatos[i].DES);
                                    Console.WriteLine("Cantidad del producto: " + aparatos[i].CAN);
                                    Console.WriteLine("Cantidad de descuento: " + (aparatos[i].DESCUENTO) * 100 + "%");
                                    Console.WriteLine("Costo del producto sin descuento: " + aparatos[i].COSU.ToString("$" + "##,###.##"));
                                    Console.WriteLine("Costo del producto con descuento: " + aparatos[i].PRECIOCONDESCUENTO.ToString("$" + "##,###.##"));
                                    Console.WriteLine("VENTAS TOTALES: " + aparatos[i].VENTAS);
                                    Console.WriteLine(" ");
                                    VAux = aparatos[i].COSU - aparatos[i].PRECIOCONDESCUENTO;
                                    VAux2 = VAux2 + VAux;
                                    ACUMVENTAS = ACUMVENTAS + (aparatos[i].VENTAS * aparatos[i].PRECIOCONDESCUENTO);
                                }
                                else
                                {
                                    Console.WriteLine("Clave del producto: " + aparatos[i].CP);
                                    Console.WriteLine("Descripción del producto: " + aparatos[i].DES);
                                    Console.WriteLine("Cantidad del producto: " + aparatos[i].CAN);
                                    Console.WriteLine("Cantidad de descuento: " + (aparatos[i].DESCUENTO) * 100 + "%");
                                    Console.WriteLine("Costo del producto: " + aparatos[i].COSU.ToString("$" + "##,###.##"));
                                    Console.WriteLine("VENTAS TOTALES: " + aparatos[i].VENTAS);
                                    Console.WriteLine(" ");
                                    ACUMVENTAS = ACUMVENTAS + (aparatos[i].VENTAS * aparatos[i].COSU);

                                    
                                }
                                
                            }
                            
                            ACUMDESCUENTOS = ACUMDESCUENTOS + VAux;                         
                           
                        }
                        Console.WriteLine("Total de descuentos es: " + VAux2.ToString("$" + "##,###.##"));
                        Console.WriteLine("Total de ventas es: " + ACUMVENTAS.ToString("$" + "##,###.##"));
                       
                        break;
                    case 6:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opción no encontrada, Cerrando Programa, Adios xdxdxdxdxd");
                        Console.ReadKey();
                        Environment.Exit(0);
                        break;
                }
                Console.WriteLine("Quieres regresar al Menú?");
                Console.WriteLine("1-.Si            2-.No");
                resp = int.Parse(Console.ReadLine());
                if (resp ==1)
                {
                    estado = true;
                    Console.Clear();
                }
                else
                {
                    estado = false;
                    Console.WriteLine("----> FIN del Programa");
                    Console.ReadKey();
                }

            }
            Console.ReadKey();
        }
    }
}