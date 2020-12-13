using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _10Problemas
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnConfirmar_Click(object sender, RoutedEventArgs e)
        {
            if (rb1.IsChecked == true)
            {
                Problema1();
                lblDescripcion.Content = "Se agrega un número n y se te imprime los números primos del 2 al n";
            }
            else if (rb2.IsChecked == true)
            {
                Problema2();
                lblDescripcion.Content = "En base a la multas se va aumentando 5 o 10 dólares (65 y 90)";
            }
            else if (rb3.IsChecked == true)
            {
                Problema3();
                lblDescripcion.Content = "Si el string está balanceado es true, en caso contrario false";
            }
            else if (rb4.IsChecked == true)
            {
                Problema4();
                lblDescripcion.Content = "Formato Hexadecimal (color) a Decimal";
            }
            else if (rb5.IsChecked == true)
            {
                Problema5();
                lblDescripcion.Content = "SI el UPC es válidado true, caso contrario false";
            }
            else if (rb7.IsChecked == true)
            {
                Problema7();
                lblDescripcion.Content = "Imprime mayúsculas en cada primera letra de cada palabra";
            }
            else if (rb8.IsChecked == true)
            {
                Problema8();
                lblDescripcion.Content = "Te regresa un string de forma alfabética";
            }
            else if (rb99.IsChecked == true)
            {
                Problema9();
                lblDescripcion.Content = "Encripar un texto con el cifrado cesar";
            }
            else if (rb10.IsChecked == true)
            {
                Problema10();
                lblDescripcion.Content = "Desencriptar un texto con el cifrado cesar";
            }
            else
            {
                MessageBox.Show("Favor de seleccionar una opción");
            }
        }
        private void Problema1()
        {
            int n = int.Parse(txtCaja.Text);
            int Extension = n - 1;
            int[] ArregloPrimos = new int[Extension];
            int AsignarNumeros = 2;
            for (int i = 0; i < Extension; i++)//Indice de 0, donde ArregloPrimos[0]=2
            {
                ArregloPrimos[i] = AsignarNumeros;
                AsignarNumeros = AsignarNumeros + 1;
            }
            //Proceso
            bool[] MarcadoOnoMarcado = new bool[n + 1];
            for (int i = 0; i < Extension; i++)
            {
                for (int j = i + 1; j < Extension; j++)
                {
                    if (ArregloPrimos[j] % ArregloPrimos[i] == 0)
                    {
                        //Console.WriteLine("Número evaluado: " + ArregloPrimos[j] + " mod de: " + ArregloPrimos[i] + " el resultado es:"  + ArregloPrimos[i] % ArregloPrimos[j]);
                        MarcadoOnoMarcado[j] = true;
                    }
                }
            }
            //Imprimeme
            string change = "";
            for (int i = 0; i < Extension; i++)
            {
                if (MarcadoOnoMarcado[i] == false)
                {
                    change = change + ArregloPrimos[i].ToString() + ",";
                }
                else
                {

                }
            }
            lblRespuesta.Content = change;
        }

        private void Problema2()
        {
            int velocidad = int.Parse(txtCaja.Text);
            int TotalAPagar = 0;
            if (velocidad >= 65 && velocidad<90)
            {
                TotalAPagar = (velocidad - 65) * 5;
                TotalAPagar = TotalAPagar + 100;
            }
            else if (velocidad >= 90)
            {
                int suma = 100 + (90 - 65) * 5;
                TotalAPagar = (velocidad - 90) * 10;
                TotalAPagar = TotalAPagar + 200 + suma;
            }
            else
            {
                lblRespuesta.Content = "No merece multa";
            }
            lblRespuesta.Content = TotalAPagar.ToString(); 
        }

        private void Problema3()
        {
            string ElTexto = txtCaja.Text;
            string[] Letra = new string[ElTexto.Length];
            for (int i = 0; i < ElTexto.Length; i++)
            {
                Letra[i] = ElTexto[i].ToString();
            }
            int[] ContadorLetra = new int[ElTexto.Length];
            ////Imprimeme las letrinis
            //for (int i = 0; i < ElTexto.Length; i++)
            //{
            //    Console.WriteLine("[" + Letra[i] + "]");
            //}
            //Cuentame cada palabra
            int contador = 0;
            for (int i = 0; i < ElTexto.Length; i++)
            {
                for (int j = 0; j < ElTexto.Length; j++)
                {
                    if (Letra[i] == ElTexto[j].ToString())
                    {
                        contador = contador + 1;
                    }
                }
                ContadorLetra[i] = contador;
                contador = 0;
            }
            int dif = 0;
            //Comparame si alguno es diferente
            for (int i = 0; i < ElTexto.Length; i++)
            {
                for (int j = 0; j < ElTexto.Length; j++)
                {
                    if (ContadorLetra[i] == ContadorLetra[j])
                    {

                    }
                    else
                    {
                        dif = 1;
                        break;
                    }
                }
            }
            if (dif == 1)
            {
                lblRespuesta.Content = "No está en balance";
            }
            else
            {
                lblRespuesta.Content = "Está en balance";
            }
        }

        private void Problema4()
        {
            string ElTexto = txtCaja.Text;
            if (ElTexto.Length > 7)
            { Console.WriteLine("Número no aceptado"); }
            string CadenaTotal = ElTexto.Substring(1);
            string PrimerPar = CadenaTotal.Substring(0, 2);
            string SegundoPar = CadenaTotal.Substring(2, 2);
            string TercerPar = CadenaTotal.Substring(4, 2);
            lblRespuesta.Content = ("RGB: " + "(" + DecimalAHexadecimal(PrimerPar) + "," + DecimalAHexadecimal(SegundoPar) + "," + DecimalAHexadecimal(TercerPar) + ")");
           //Console.WriteLine("RGB: " + "(" + DecimalAHexadecimal(PrimerPar) + "," + DecimalAHexadecimal(SegundoPar) + "," + DecimalAHexadecimal(TercerPar) + ")");
        }
        static double DecimalAHexadecimal(string Hexadecimal)
        {
            double dicimal = 0;
            double res = 0;
            double potencia = 0;
            int k = 0;
            for (int i = Hexadecimal.Length - 1; i >= 0; i--)
            {
                //Console.WriteLine("Vez: " + i);
                char letter = Hexadecimal[i];
                //Console.WriteLine(letter);
                if (letter == '0')
                {
                    potencia = Math.Pow(16, k);
                    res = potencia * 0;
                }
                else if (letter == '1')
                {
                    potencia = Math.Pow(16, k);
                    res = potencia * 1;
                }
                else if (letter == '2')
                {
                    potencia = Math.Pow(16, k);
                    res = potencia * 2;
                }
                else if (letter == '3')
                {
                    potencia = Math.Pow(16, k);
                    res = potencia * 3;
                }
                else if (letter == '4')
                {
                    potencia = Math.Pow(16, k);
                    res = potencia * 4;
                }
                else if (letter == '5')
                {
                    potencia = Math.Pow(16, k);
                    res = potencia * 5;
                }
                else if (letter == '6')
                {
                    potencia = Math.Pow(16, k);
                    res = potencia * 6;
                }
                else if (letter == '7')
                {
                    potencia = Math.Pow(16, k);
                    res = potencia * 7;
                }
                else if (letter == '8')
                {
                    potencia = Math.Pow(16, k);
                    res = potencia * 8;
                }
                else if (letter == '9')
                {
                    potencia = Math.Pow(16, k);
                    res = potencia * 9;
                }
                else if (letter == 'A' || letter == 'a')
                {
                    potencia = Math.Pow(16, k);
                    res = potencia * 10;
                }
                else if (letter == 'B' || letter == 'b')
                {
                    potencia = Math.Pow(16, k);
                    res = potencia * 11;
                }
                else if (letter == 'C' || letter == 'c')
                {
                    potencia = Math.Pow(16, k);
                    res = potencia * 12;
                }
                else if (letter == 'D' || letter == 'd')
                {
                    potencia = Math.Pow(16, k);
                    res = potencia * 13;
                }
                else if (letter == 'E' || letter == 'e')
                {
                    potencia = Math.Pow(16, k);
                    res = potencia * 14;
                }
                else if (letter == 'F' || letter == 'f')
                {
                    potencia = Math.Pow(16, k);
                    res = potencia * 15;
                }
                k = k + 1;
                dicimal = dicimal + res;
                //Console.WriteLine(dicimal);
            }
            return dicimal;
        }

        private void Problema5()
        {
            //string NumeroUPC = "051000012517";
            string NumeroUPC = txtCaja.Text;
            int[] ArregloUPC = new int[NumeroUPC.Length];
            Console.WriteLine("Cantidad de números: " + NumeroUPC.Length);
            for (int i = 0; i < NumeroUPC.Length; i++)
            {
                ArregloUPC[i] = int.Parse(NumeroUPC[i].ToString());
            }
            Console.WriteLine(" ");
            //Paso b
            int acum1 = 0;
            for (int i = 0; i < NumeroUPC.Length; i = i + 2)
            {
                ArregloUPC[i] = ArregloUPC[i] * 3;
                acum1 = acum1 + ArregloUPC[i];
            }
            Console.WriteLine(" \n");
            //Paso c 
            int acum2 = 0;
            for (int i = 1; i < NumeroUPC.Length - 1; i = i + 2)
            {
                acum2 = acum2 + NumeroUPC[i];
            }
            //Paso c
            int acumTotal = acum1 + acum2;
            //Paso d
            double operacion = acumTotal % 10;
            double Doceavodigito = 0;
            if (operacion != 0)
            {
                Doceavodigito = 10 - operacion;
            }
            else
            {
                Doceavodigito = operacion;
            }
            if (ArregloUPC[11] == Doceavodigito)
            {
                lblRespuesta.Content= "Es válido";
            }
            else
            {
                lblRespuesta.Content = "Es inválido";
            }
        }

        private void Problema7()
        {
            string ElTexto = txtCaja.Text;
            ElTexto = ElTexto.ToLower();
            char[] LetraxLetra = ElTexto.ToCharArray();
            char[] abecedariomayuscula = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            char[] abecedariominuscula = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            char[] ArregloImprimir = new char[LetraxLetra.Length];
            int[] indexes = new int[LetraxLetra.Length];
            for (int i = 0; i < LetraxLetra.Length; i++)
            {
                for (int j = 0; j < abecedariominuscula.Length; j++)
                {
                    if (LetraxLetra[i] == abecedariominuscula[j])
                    {
                        indexes[i] = j;
                    }
                }
            }
            //for (int i = 0; i < LetraxLetra.Length; i++)
            //{
            //    Console.WriteLine(indexes[i]);
            //}
            LetraxLetra[0] = abecedariomayuscula[indexes[0]];
            for (int i = 1; i < LetraxLetra.Length; i++)
            {
                if (LetraxLetra[i] != ' ' && LetraxLetra[i - 1] == ' ')
                {
                    LetraxLetra[i] = abecedariomayuscula[indexes[i]];
                }
            }
            string change = "";
            for (int i = 0; i < LetraxLetra.Length; i++)
            {
                change=change + LetraxLetra[i].ToString();
            }
            lblRespuesta.Content = change;
        }

        private void Problema8()
        {
            string ElTexto = txtCaja.Text;
            char[] abecedario = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            ElTexto = ElTexto.ToUpper();
            char[] ArregloLetraxLetra = ElTexto.ToCharArray();
            int[] indexes = new int[ArregloLetraxLetra.Length];
            for (int i = 0; i < ArregloLetraxLetra.Length; i++)
            {
                for (int j = 0; j < abecedario.Length; j++)
                {
                    if (ArregloLetraxLetra[i] == abecedario[j])
                    {
                        indexes[i] = j;
                    }
                }
            }
            int aux = 0;
            for (int i = 0; i < indexes.Length; i++)
            {
                for (int j = 0; j < indexes.Length; j++)
                {
                    //Numero de Menor a Mayor
                    if (indexes[i] < indexes[j])
                    {
                        aux = indexes[i];
                        indexes[i] = indexes[j];
                        indexes[j] = aux;
                    }
                }
            }
            string change = "";
            for (int i = 0; i < ArregloLetraxLetra.Length; i++)
            {
                change=change +  abecedario[indexes[i]].ToString() + " ";
            }
            lblRespuesta.Content = change;
        }

        private void Problema9()
        {
            string Text = txtCaja.Text;
            Text.ToUpper();
            string[] palabras = Text.Split(' ');
            string ElTexto = "";
            for (int i = 0; i < palabras.Length; i++)
            {
                ElTexto = ElTexto + palabras[i];
            }
            char[] abecedario = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            ElTexto = ElTexto.ToUpper();
            char[] ArregloLetraxLetra = ElTexto.ToCharArray();
            char[] LetraxLetra = ElTexto.ToCharArray();
            int[] indexes = new int[ArregloLetraxLetra.Length];
            for (int i = 0; i < LetraxLetra.Length; i++)
            {
                for (int j = 0; j < abecedario.Length; j++)
                {
                    if (LetraxLetra[i] == abecedario[j])
                    {
                        indexes[i] = j;
                    }
                }
            }
            //for (int i = 0; i < LetraxLetra.Length; i++)
            //{
            //    Console.WriteLine(indexes[i]);
            //}
            int[] MensajeEncriptado = new int[indexes.Length];
            for (int i = 0; i < MensajeEncriptado.Length; i++)
            {
                MensajeEncriptado[i] = (indexes[i] + 4) % 26;
            }
            string change = "";
            for (int i = 0; i < MensajeEncriptado.Length; i++)
            {
                change= change+ abecedario[MensajeEncriptado[i]].ToString();

            }
            lblRespuesta.Content = change;
        }

        private void Problema10()
        {
            string ElTexto = txtCaja.Text;
            char[] abecedario = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            ElTexto = ElTexto.ToUpper();
            char[] ArregloLetraxLetra = ElTexto.ToCharArray();
            char[] LetraxLetra = ElTexto.ToCharArray();
            int[] indexes = new int[ArregloLetraxLetra.Length];
            for (int i = 0; i < LetraxLetra.Length; i++)
            {
                for (int j = 0; j < abecedario.Length; j++)
                {
                    if (LetraxLetra[i] == abecedario[j])
                    {
                        indexes[i] = j;
                    }
                }
            }
            //for (int i = 0; i < LetraxLetra.Length; i++)
            //{
            //    Console.WriteLine(indexes[i]);
            //}
            int[] MensajeDesencriptado = new int[indexes.Length];
            for (int i = 0; i < MensajeDesencriptado.Length; i++)
            {
                MensajeDesencriptado[i] = (indexes[i] - 4) % 26;
            }
            string change = "";
            for (int i = 0; i < MensajeDesencriptado.Length; i++)
            {
                change = change + abecedario[MensajeDesencriptado[i]].ToString();
            }
            lblRespuesta.Content = change;
        }

        //Estos no se borran
    }
}
