using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace RandomFacil
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            PictureBox[] Imagenes = new PictureBox[28];
            Imagenes[0].Image = Image.FromFile("hoLA");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                timer1.Enabled = true;
                timer1.Interval = 50;
                ReproducirMusica();
                pictureBox1.Visible = true;
                label1.Visible = true;
                label2.Visible = false;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                label1.Visible = false;
                label2.Visible = true;
            }

        }

        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();
        public void ReproducirMusica()
        {   ///Cambiar Ruta de diferente computadora        
            player1.SoundLocation = "C:/Users/Pablo Diaz/Desktop/PROGRAMAS C# METODOS DE PROGRAMACION/RandomFacil/RandomFacil/Resources/Ninja.wav";
            player1.Play();
            if (timer1.Enabled == false)
            {
                player1.Stop();
            }
        }

        System.Media.SoundPlayer player2 = new System.Media.SoundPlayer();
        public void ReproducirMusica2()
        {   ///Cambiar Ruta de diferente computadora        
            player2.SoundLocation = "C:/Users/Pablo Diaz/Desktop/PROGRAMAS C# METODOS DE PROGRAMACION/RandomFacil/RandomFacil/Resources/Dexter Surprise Motherfucker.wav";
            player2.Play();
            player2.Load();
        }

        int i = 0, TT = 0;
        string[] ArregloImagenes = new string[28];
        string[] ArregloNombres = new string[28] { "Adolfo", "Alec", "Alejandro", "Carlos", "Christian", "David", "Diego", "Jorgito", "Fausto", "Ángel", "Isaac Reyes", "Isaac Sanchez", "Isaac", "Juampy", "Kevin Huerta", "Kevin", "Lola", "Manolo", "Miguel", "Mizael", "Nestor", "Oscar", "Pablo", "Ruben", "Sando", "Silvia", "Smith", "Jorge" };

        public void timer1_Tick(object sender, EventArgs e)
        {
            TT++;
            i = Randomsini();
            ElegirPersona();
        }

        int q = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            q++;
            if (q == 3)
            {
                pictureBox2.Visible = true;
                ReproducirMusica2();

            }
            if (q == 6)
            {
                timer2.Enabled = false;
                pictureBox2.Visible = false;
                q = 0;
                i = Randomsini();
                label1.Text = ArregloNombres[i];

            }
        }

        static int Randomsini()
        {
            int Num = 0;
            Random Numero = new Random();
            Num = Numero.Next(0, 27);
            return Num;
        }

        int k = 0;
        private void timer3_Tick(object sender, EventArgs e)
        {
            k++;
            timer3.Interval = 100;
            if (k > 28)
            {
                k = 0;
            }

        }

      
        public void ElegirPersona()
        {
            if (i == 0)
            {
                ArregloNombres[0] = "Adolfo";
                label1.Text = ArregloNombres[0];
                //ArregloImagenes[0] = Properties.Resources.Adolfo;
                pictureBox1.Image = Properties.Resources.Adolfo; //Image.FromFile(ArregloImagenes[i]);
            }
            else if (i == 1)
            {
                ArregloNombres[1] = "Alec";
                label1.Text = ArregloNombres[1];
                //ArregloImagenes[1] = "C:/Users/Pablo Diaz/Desktop/PROGRAMAS C# METODOS DE PROGRAMACION/RandomFacil/RandomFacil/Resources/Alec.jpg";
                pictureBox1.Image = Properties.Resources.Alec;
            }
            else if (i == 2)
            {
                ArregloNombres[2] = "Alejandro";
                label1.Text = ArregloNombres[2];
                //ArregloImagenes[2] = "C:/Users/Pablo Diaz/Desktop/PROGRAMAS C# METODOS DE PROGRAMACION/RandomFacil/RandomFacil/Resources/Alejandro.jpg";
                pictureBox1.Image = Properties.Resources.Alejandro;
            }
            else if (i == 3)
            {
                ArregloNombres[3] = "Carlos";
                label1.Text = ArregloNombres[3];
                //ArregloImagenes[3] = "C:/Users/Pablo Diaz/Desktop/PROGRAMAS C# METODOS DE PROGRAMACION/RandomFacil/RandomFacil/Resources/Carlos.jpg";
                pictureBox1.Image = Properties.Resources.Carlos;
            }
            else if (i == 4)
            {
                ArregloNombres[4] = "Christian";
                label1.Text = ArregloNombres[4];
                //ArregloImagenes[4] = "C:/Users/Pablo Diaz/Desktop/PROGRAMAS C# METODOS DE PROGRAMACION/RandomFacil/RandomFacil/Resources/Christian.jpg";
                pictureBox1.Image = Properties.Resources.Christian;
            }
            else if (i == 5)
            {
                ArregloNombres[5] = "David";
                label1.Text = ArregloNombres[5];
                //ArregloImagenes[5] = "C:/Users/Pablo Diaz/Desktop/PROGRAMAS C# METODOS DE PROGRAMACION/RandomFacil/RandomFacil/Resources/David.jpg";
                pictureBox1.Image = Properties.Resources.David;
            }
            else if (i == 6)
            {
                ArregloNombres[6] = "Diego";
                label1.Text = ArregloNombres[6];
                //ArregloImagenes[6] = "C:/Users/Pablo Diaz/Desktop/PROGRAMAS C# METODOS DE PROGRAMACION/RandomFacil/RandomFacil/Resources/Diego.jpg";
                pictureBox1.Image = Properties.Resources.Diego;
            }
            else if (i == 7)
            {
                ArregloNombres[7] = "Jorgito";
                label1.Text = ArregloNombres[7];
                //ArregloImagenes[7] = "C:/Users/Pablo Diaz/Desktop/PROGRAMAS C# METODOS DE PROGRAMACION/RandomFacil/RandomFacil/Resources/el 08.jpg";
                pictureBox1.Image = Properties.Resources.el_08;
            }
            else if (i == 8)
            {
                ArregloNombres[8] = "Fausto";
                label1.Text = ArregloNombres[8];
                //ArregloImagenes[8] = "C:/Users/Pablo Diaz/Desktop/PROGRAMAS C# METODOS DE PROGRAMACION/RandomFacil/RandomFacil/Resources/Fausto.jpg";
                pictureBox1.Image = Properties.Resources.Fausto;
            }
            else if (i == 9)
            {
                ArregloNombres[9] = "Ángel";
                label1.Text = ArregloNombres[9];
                //ArregloImagenes[9] = "C:/Users/Pablo Diaz/Desktop/PROGRAMAS C# METODOS DE PROGRAMACION/RandomFacil/RandomFacil/Resources/Grauyi.jpg";
                pictureBox1.Image = Properties.Resources.Grauyi;
            }
            else if (i == 10)
            {
                ArregloNombres[10] = "Isaac Reyes";
                label1.Text = ArregloNombres[10];
                //ArregloImagenes[10] = "C:/Users/Pablo Diaz/Desktop/PROGRAMAS C# METODOS DE PROGRAMACION/RandomFacil/RandomFacil/Resources/Isaac Reyes.jpg";
                pictureBox1.Image = Properties.Resources.Isaac_Reyes;
            }
            else if (i == 11)
            {
                ArregloNombres[11] = "Isaac Sanchez";
                label1.Text = ArregloNombres[11];
                //ArregloImagenes[11] = "C:/Users/Pablo Diaz/Desktop/PROGRAMAS C# METODOS DE PROGRAMACION/RandomFacil/RandomFacil/Resources/Isaac Sanchez.jpg";
                pictureBox1.Image = Properties.Resources.Isaac_Sanchez;
            }
            else if (i == 12)
            {
                label1.Text = "Issac";
                //ArregloImagenes[12] = "C:/Users/Pablo Diaz/Desktop/PROGRAMAS C# METODOS DE PROGRAMACION/RandomFacil/RandomFacil/Resources/Isaac.jpg";
                pictureBox1.Image = Properties.Resources.Isaac;
            }
            else if (i == 13)
            {
                ArregloNombres[13] = "Juampy";
                label1.Text = ArregloNombres[13];
                //ArregloImagenes[13] = "C:/Users/Pablo Diaz/Desktop/PROGRAMAS C# METODOS DE PROGRAMACION/RandomFacil/RandomFacil/Resources/Juampy.jpg";
                pictureBox1.Image = Properties.Resources.Juampy;
            }
            else if (i == 14)
            {
                ArregloNombres[14] = "Kevin Huerta";
                label1.Text = ArregloNombres[14];
                //ArregloImagenes[14] = "C:/Users/Pablo Diaz/Desktop/PROGRAMAS C# METODOS DE PROGRAMACION/RandomFacil/RandomFacil/Resources/Kevin Huerta.jpg";
                pictureBox1.Image = Properties.Resources.Kevin_Huerta;
            }
            else if (i == 15)
            {
                ArregloNombres[15] = "Kevin García";
                label1.Text = ArregloNombres[15];
                //ArregloImagenes[15] = "C:/Users/Pablo Diaz/Desktop/PROGRAMAS C# METODOS DE PROGRAMACION/RandomFacil/RandomFacil/Resources/Kevin.jpg";
                pictureBox1.Image = Properties.Resources.Kevin;
            }
            else if (i == 16)
            {
                ArregloNombres[16] = "Lola";
                label1.Text = ArregloNombres[16];
                //ArregloImagenes[16] = "C:/Users/Pablo Diaz/Desktop/PROGRAMAS C# METODOS DE PROGRAMACION/RandomFacil/RandomFacil/Resources/Lola.jpg";
                pictureBox1.Image = Properties.Resources.Lola;
            }
            else if (i == 17)
            {
                ArregloNombres[17] = "Manolo";
                label1.Text = ArregloNombres[17];
                //ArregloImagenes[17] = "C:/Users/Pablo Diaz/Desktop/PROGRAMAS C# METODOS DE PROGRAMACION/RandomFacil/RandomFacil/Resources/Manolo.jpg";
                pictureBox1.Image = Properties.Resources.Manolo;
            }
            else if (i == 18)
            {
                ArregloNombres[18] = "Miguel";
                label1.Text = ArregloNombres[18];
                //ArregloImagenes[18] = "C:/Users/Pablo Diaz/Desktop/PROGRAMAS C# METODOS DE PROGRAMACION/RandomFacil/RandomFacil/Resources/Miguel.jpg";
                pictureBox1.Image = Properties.Resources.Miguel;
            }
            else if (i == 19)
            {
                ArregloNombres[19] = "Mizael";
                label1.Text = ArregloNombres[19];
                //ArregloImagenes[19] = "C:/Users/Pablo Diaz/Desktop/PROGRAMAS C# METODOS DE PROGRAMACION/RandomFacil/RandomFacil/Resources/Mizael.jpg";
                pictureBox1.Image = Properties.Resources.Mizael;
            }
            else if (i == 20)
            {
                ArregloNombres[20] = "Nestor";
                label1.Text = ArregloNombres[20];
                //ArregloImagenes[20] = "C:/Users/Pablo Diaz/Desktop/PROGRAMAS C# METODOS DE PROGRAMACION/RandomFacil/RandomFacil/Resources/Nestor.jpg";
                pictureBox1.Image = Properties.Resources.Nestor;
            }
            else if (i == 21)
            {
                ArregloNombres[21] = "Oscar";
                label1.Text = ArregloNombres[21];
                //ArregloImagenes[21] = "C:/Users/Pablo Diaz/Desktop/PROGRAMAS C# METODOS DE PROGRAMACION/RandomFacil/RandomFacil/Resources/Oscar.jpg";
                pictureBox1.Image = Properties.Resources.Oscar;
            }
            else if (i == 22)
            {
                ArregloNombres[22] = "Pablo";
                label1.Text = ArregloNombres[22];
                //ArregloImagenes[22] = "C:/Users/Pablo Diaz/Desktop/PROGRAMAS C# METODOS DE PROGRAMACION/RandomFacil/RandomFacil/Resources/Pablo.jpg";
                pictureBox1.Image = Properties.Resources.Pablo;
            }
            else if (i == 23)
            {
                ArregloNombres[23] = "Ruben";
                label1.Text = ArregloNombres[23];
                //ArregloImagenes[23] = "C:/Users/Pablo Diaz/Desktop/PROGRAMAS C# METODOS DE PROGRAMACION/RandomFacil/RandomFacil/Resources/Rubs.jpg";
                pictureBox1.Image = Properties.Resources.Rubs;
            }
            else if (i == 24)
            {
                ArregloNombres[24] = "Sando";
                label1.Text = ArregloNombres[24];
                //ArregloImagenes[24] = "C:/Users/Pablo Diaz/Desktop/PROGRAMAS C# METODOS DE PROGRAMACION/RandomFacil/RandomFacil/Resources/Sando.jpg";
                pictureBox1.Image = Properties.Resources.Sando;
            }
            else if (i == 25)
            {
                ArregloNombres[25] = "Silvia";
                label1.Text = ArregloNombres[25];
                //ArregloImagenes[25] = "C:/Users/Pablo Diaz/Desktop/PROGRAMAS C# METODOS DE PROGRAMACION/RandomFacil/RandomFacil/Resources/Silvia.jpg";
                pictureBox1.Image = Properties.Resources.Silvia;
            }
            else if (i == 26)
            {
                ArregloNombres[26] = "Smith";
                label1.Text = ArregloNombres[26];
                //ArregloImagenes[26] = "C:/Users/Pablo Diaz/Desktop/PROGRAMAS C# METODOS DE PROGRAMACION/RandomFacil/RandomFacil/Resources/Smith.jpg";
                pictureBox1.Image = Properties.Resources.Smith;
            }
            else if (i == 27)
            {
                ArregloNombres[27] = "Jorge";
                label1.Text = ArregloNombres[27];
                ArregloImagenes[27] = "Properties.Resources.Mejia";
                pictureBox1.Image = Properties.Resources.Mejia;
            }
            else
            {
                i = 0;
            }
            if (TT > 100)
            {
                timer1.Enabled = false;
                TT = 0;
                player1.Stop();
                timer2.Enabled = true;
                timer2.Interval = 1000;
            }
        }

    }
}
