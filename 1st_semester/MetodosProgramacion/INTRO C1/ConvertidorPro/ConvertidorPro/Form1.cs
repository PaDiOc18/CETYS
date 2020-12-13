using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvertidorPro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*Procedimiento Decimal a Binario*/
        void ConvertirDecimalABinario()
        {
            int num;
            int sobrante;
            string binario;
            binario = " ";
            num = int.Parse(textBox1.Text);
            while (num > 0)
            {
                sobrante = num % 2;
                if (sobrante == 0)
                {
                    binario = "0" + binario;
                }
                else if (sobrante == 1)
                {
                    binario = "1" + binario;
                }
                num = num / 2;
            }
            textBox2.Text = binario;
        }
        /*Procedimiento Decimal a Hexadecimal*/
        void ConvertirDecimalAHexadecimal()
        {
            int num;
            int sobrante;
            string hexadecimal;
            hexadecimal = " ";
            num = int.Parse(textBox1.Text);
            while (num > 0)
            {
                sobrante = num % 16;
                if (sobrante == 0)
                {
                    hexadecimal = "0" + hexadecimal;
                }
                else if (sobrante == 1)
                {
                    hexadecimal = "1" + hexadecimal;
                }
                else if (sobrante == 2)
                {
                    hexadecimal = "2" + hexadecimal;
                }
                else if (sobrante == 3)
                {
                    hexadecimal = "3" + hexadecimal;
                }
                else if (sobrante == 4)
                {
                    hexadecimal = "4" + hexadecimal;
                }
                else if (sobrante == 5)
                {
                    hexadecimal = "5" + hexadecimal;
                }
                else if (sobrante == 6)
                {
                    hexadecimal = "6" + hexadecimal;
                }
                else if (sobrante == 7)
                {
                    hexadecimal = "7" + hexadecimal;
                }
                else if (sobrante == 7)
                {
                    hexadecimal = "7" + hexadecimal;
                }
                else if (sobrante == 8)
                {
                    hexadecimal = "8" + hexadecimal;
                }
                else if (sobrante == 9)
                {
                    hexadecimal = "9" + hexadecimal;
                }
                else if (sobrante == 10)
                {
                    hexadecimal = "A" + hexadecimal;
                }
                else if (sobrante == 11)
                {
                    hexadecimal = "B" + hexadecimal;
                }
                else if (sobrante == 12)
                {
                    hexadecimal = "C" + hexadecimal;
                }
                else if (sobrante == 13)
                {
                    hexadecimal = "D" + hexadecimal;
                }
                else if (sobrante == 14)
                {
                    hexadecimal = "E" + hexadecimal;
                }
                else if (sobrante == 15)
                {
                    hexadecimal = "F" + hexadecimal;
                }
                num = num / 16;
            }
            textBox2.Text = hexadecimal;
        }
        /*Decimal a Decimal*/
        void ConvertirDecimalaDecimal()
        {
            if (rbDecimal1.Checked == true && rbDecimal2.Checked == true)
            {
                string cadena;
                cadena = Convert.ToString(textBox1.Text);
                textBox2.Text = cadena;
            }
        }
    /*Procedimiento Binario a Decimal*/
    void ConvertirBinarioaDecimal()
        {
            string binario;
            string invertido;
            double potencia;
            double res;
            double Decimal;
            Decimal = 0;
            res = 0;
            potencia = 0;
            invertido = "";
            binario = "";
            binario = Convert.ToString(textBox1.Text);
            char[] array = binario.ToCharArray();
            array = array.Reverse().ToArray();
            for (int i = 0; i < array.Length; i++)
            {
                char letter = array[i].ToUpper();
                if (letter == '1')
                {
                    potencia = Math.Pow(2, i);
                    res = potencia * 1;
                }
                else if (letter == '0')
                {
                    potencia = Math.Pow(2, i);
                    res = potencia * 0;
                }

                invertido = invertido + letter;
                Decimal = Decimal + res;
            }
            textBox2.Text = Convert.ToString(Decimal);
        }
        /*Procedimiento Binario a Hexadecimal*/
        void ConvertirBinarioAHexadecimal()
        {
            string binario;
            string invertido;
            double potencia;
            double res;
            double Decimal;
            Decimal = 0;
            res = 0;
            potencia = 0;
            invertido = "";
            binario = "";
            binario = Convert.ToString(textBox1.Text);
            char[] array = binario.ToCharArray();
            array = array.Reverse().ToArray();
            for (int i = 0; i < array.Length; i++)
            {
                char letter = array[i];
                if (letter == '1')
                {
                    potencia = Math.Pow(2, i);
                    res = potencia * 1;
                }
                else
                {
                    potencia = Math.Pow(2, i);
                    res = potencia * 0;
                }
                invertido = invertido + letter;
                Decimal = Decimal + res;
            }
            int num;
            int sobrante;
            string hexadecimal;
            hexadecimal = " ";
            num = Convert.ToInt32(Decimal);
            while (num > 0)
            {
                sobrante = num % 16;
                if (sobrante == 0)
                {
                    hexadecimal = "0" + hexadecimal;
                }
                else if (sobrante == 1)
                {
                    hexadecimal = "1" + hexadecimal;
                }
                else if (sobrante == 2)
                {
                    hexadecimal = "2" + hexadecimal;
                }
                else if (sobrante == 3)
                {
                    hexadecimal = "3" + hexadecimal;
                }
                else if (sobrante == 4)
                {
                    hexadecimal = "4" + hexadecimal;
                }
                else if (sobrante == 5)
                {
                    hexadecimal = "5" + hexadecimal;
                }
                else if (sobrante == 6)
                {
                    hexadecimal = "6" + hexadecimal;
                }
                else if (sobrante == 7)
                {
                    hexadecimal = "7" + hexadecimal;
                }
                else if (sobrante == 7)
                {
                    hexadecimal = "7" + hexadecimal;
                }
                else if (sobrante == 8)
                {
                    hexadecimal = "8" + hexadecimal;
                }
                else if (sobrante == 9)
                {
                    hexadecimal = "9" + hexadecimal;
                }
                else if (sobrante == 10)
                {
                    hexadecimal = "A" + hexadecimal;
                }
                else if (sobrante == 11)
                {
                    hexadecimal = "B" + hexadecimal;
                }
                else if (sobrante == 12)
                {
                    hexadecimal = "C" + hexadecimal;
                }
                else if (sobrante == 13)
                {
                    hexadecimal = "D" + hexadecimal;
                }
                else if (sobrante == 14)
                {
                    hexadecimal = "E" + hexadecimal;
                }
                else if (sobrante == 15)
                {
                    hexadecimal = "F" + hexadecimal;
                }
                num = num / 16;
            }
            textBox2.Text = hexadecimal;
        }
        /*Procedimiento Binario a Binario*/
        void ConvertirBinarioABinario()
        {
            string cadena;
            cadena = Convert.ToString(textBox1.Text);
            textBox2.Text = cadena;
        }
        /*Procedimiento Hexadecimal a Decimal*/
        void ConvertirHexadecimalaDecimal()
        {
            string Hexadecimal;
            string invertido;
            double potencia;
            double res;
            double Decimal;
            Decimal = 0;
            res = 0;
            potencia = 0;
            invertido = "";
            Hexadecimal = "";
            Hexadecimal = Convert.ToString(textBox1.Text);
            char[] array = Hexadecimal.ToCharArray();
            array = array.Reverse().ToArray();
            for (int i = 0; i < array.Length; i++)
            {
                char letter = array[i];
                if (letter == '0')
                {
                    potencia = Math.Pow(16, i);
                    res = potencia * 0;
                }
                else if(letter == '1')
                {
                    potencia = Math.Pow(16, i);
                    res = potencia * 1;
                }
                else if(letter == '2')
                {
                    potencia = Math.Pow(16, i);
                    res = potencia * 2;
                }
                else if (letter == '3')
                {
                    potencia = Math.Pow(16, i);
                    res = potencia * 3;
                }
                else if (letter == '4')
                {
                    potencia = Math.Pow(16, i);
                    res = potencia * 4;
                }
                else if (letter == '5')
                {
                    potencia = Math.Pow(16, i);
                    res = potencia * 5;
                }
                else if (letter == '6')
                {
                    potencia = Math.Pow(16, i);
                    res = potencia * 6;
                }
                else if (letter == '7')
                {
                    potencia = Math.Pow(16, i);
                    res = potencia * 7;
                }
                else if (letter == '8')
                {
                    potencia = Math.Pow(16, i);
                    res = potencia * 8;
                }
                else if (letter == '9')
                {
                    potencia = Math.Pow(16, i);
                    res = potencia * 9;
                }
                else if (letter == 'A' || letter == 'a')
                {
                    potencia = Math.Pow(16, i);
                    res = potencia * 10;
                }
                else if (letter == 'B' || letter == 'b')
                {
                    potencia = Math.Pow(16, i);
                    res = potencia * 11;
                }
                else if (letter == 'C' || letter == 'c')
                {
                    potencia = Math.Pow(16, i);
                    res = potencia * 12;
                }
                else if (letter == 'D' || letter == 'd')
                {
                    potencia = Math.Pow(16, i);
                    res = potencia * 13;
                }
                else if (letter == 'E' || letter == 'e')
                {
                    potencia = Math.Pow(16, i);
                    res = potencia * 14;
                }
                else if (letter == 'F' || letter == 'f')
                {
                    potencia = Math.Pow(16, i);
                    res = potencia * 15;
                }
                invertido = invertido + letter;
                Decimal = Decimal + res;
            }
            textBox2.Text = Convert.ToString(Decimal);
        }
        /*Procedimiento Hexadecimal a Binario*/
        void ConvertirHexadecimalaBinario()
        {
            string Hexadecimal;
            string invertido;
            double potencia;
            double res;
            double Decimal;
            Decimal = 0;
            res = 0;
            potencia = 0;
            invertido = "";
            Hexadecimal = "";
            Hexadecimal = Convert.ToString(textBox1.Text);
            char[] array = Hexadecimal.ToCharArray();
            array = array.Reverse().ToArray();
            for (int i = 0; i < array.Length; i++)
            {
                char letter = array[i];
                if (letter == '0')
                {
                    potencia = Math.Pow(16, i);
                    res = potencia * 0;
                }
                else if (letter == '1')
                {
                    potencia = Math.Pow(16, i);
                    res = potencia * 1;
                }
                else if (letter == '2')
                {
                    potencia = Math.Pow(16, i);
                    res = potencia * 2;
                }
                else if (letter == '3')
                {
                    potencia = Math.Pow(16, i);
                    res = potencia * 3;
                }
                else if (letter == '4')
                {
                    potencia = Math.Pow(16, i);
                    res = potencia * 4;
                }
                else if (letter == '5')
                {
                    potencia = Math.Pow(16, i);
                    res = potencia * 5;
                }
                else if (letter == '6')
                {
                    potencia = Math.Pow(16, i);
                    res = potencia * 6;
                }
                else if (letter == '7')
                {
                    potencia = Math.Pow(16, i);
                    res = potencia * 7;
                }
                else if (letter == '8')
                {
                    potencia = Math.Pow(16, i);
                    res = potencia * 8;
                }
                else if (letter == '9')
                {
                    potencia = Math.Pow(16, i);
                    res = potencia * 9;
                }
                else if (letter == 'A' || letter == 'a')
                {
                    potencia = Math.Pow(16, i);
                    res = potencia * 10;
                }
                else if (letter == 'B' || letter == 'b')
                {
                    potencia = Math.Pow(16, i);
                    res = potencia * 11;
                }
                else if (letter == 'C' || letter == 'c')
                {
                    potencia = Math.Pow(16, i);
                    res = potencia * 12;
                }
                else if (letter == 'D' || letter == 'd')
                {
                    potencia = Math.Pow(16, i);
                    res = potencia * 13;
                }
                else if (letter == 'E' || letter == 'e')
                {
                    potencia = Math.Pow(16, i);
                    res = potencia * 14;
                }
                else if (letter == 'F' || letter == 'f')
                {
                    potencia = Math.Pow(16, i);
                    res = potencia * 15;
                }

                invertido = invertido + letter;
                Decimal = Decimal + res;
            }
            int num;
            num = Convert.ToInt32(Decimal);
            int sobrante;
            string binario;
            binario = " ";

            while (num > 0)
            {
                sobrante = num % 2;
                if (sobrante == 0)
                {
                    binario = "0" + binario;
                }
                else
                {
                    binario = "1" + binario;
                }
                num = num / 2;
            }
            textBox2.Text = binario;
        }
        /*Procedimiento Hexadecimal a Binario*/
        void ConvertirHexadecimalaHexadecimal()
        {
            string cadena;
            cadena = Convert.ToString(textBox1.Text);
            textBox2.Text = cadena;
        }
            public void btnConvertir_Click(object sender, EventArgs e)
        {
            /*Decimal a Binario*/
            if (rbDecimal1.Checked == true && rbBinario2.Checked == true)
            {
                ConvertirDecimalABinario();
            }

            /*Decimal a Hexadecimal*/
            if (rbDecimal1.Checked == true && rbHexa2.Checked == true)
            {   
                ConvertirDecimalAHexadecimal();
            }
            /*Decimal a Decimal*/
            if (rbDecimal1.Checked == true && rbDecimal2.Checked == true)
            {
                ConvertirDecimalaDecimal();
            }
            /*Binario a Decimal*/
            if (rbBinario1.Checked == true && rbDecimal2.Checked == true)
            {
                ConvertirBinarioaDecimal();
                
            }
            /*Binario a Hexadecimal*/
            if (rbBinario1.Checked == true && rbHexa2.Checked == true)
            {
               ConvertirBinarioAHexadecimal();
            }
            /*Binario a Binario*/
            if (rbBinario1.Checked == true && rbBinario2.Checked == true)
            {
                ConvertirBinarioABinario();
            }
            /*Hexadecimal a Decimal*/
            if (rbHexa1.Checked == true && rbDecimal2.Checked == true)
            {
                ConvertirHexadecimalaDecimal();
            }
            /*Hexadecimal a Binario*/
            if (rbHexa1.Checked == true && rbBinario2.Checked == true)
            {
                ConvertirHexadecimalaBinario();
            }
            /*Hexadecimal a Binario*/
            if (rbHexa1.Checked == true && rbHexa2.Checked == true)
            {
                ConvertirHexadecimalaHexadecimal();
            }
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        /*Hecho por: Diaz Ochoa Pablo*/
    }
}
