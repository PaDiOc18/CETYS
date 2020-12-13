using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2doParcialJerryRandom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        string[] Imagenes = new string[28] { "Adolfo.jpg", "Alec.jpg", "Alejandro.jpg", "Carlos.jpg", "David.jpg", "Diego.jpg", "el 08.jpg", "Fausto.jpg", "Grauyi.jpg", "Isaac Reyes.jpg", "Isaac Sanchez.jpg", "Isaac.jpg", "Juampy.jpg", "Kevin Huerta.jpg", "Kevin.jpg", "Lola.jpg", "Manolo.jpg", "Mejia.jpg", "Miguel.jpg", "Mizael.jpg", "Nestor.jpg", "Oscar.jpg", "Pablo.jpg", "Rubs.jpg", "Sando.jpg", "Silvia.jpg", "Smith.jpg", "Xavier.jpg" };
        string[] ArregloNombres = new string[28] { "Adolfo", "Alec", "Alejandro", "Carlos", "David", "Diego", "el 08", "Fausto", "Angel", "Isaac Reyes", "Isaac Sanchez", "Isaac", "Juampy", "Kevin Huerta", "Kevin", "Lola", "Manolo", "Mejia", "Miguel", "Mizael", "Nestor", "Oscar", "Pablo", "Rubs", "Sando", "Silvia", "Smith", "Xavier" };
        string[] ArregloAuxiliar = new string[28] { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };

        Random G = new Random();
        //El boton we dxdxdxdx
        public void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                timer1.Enabled = true;
                int Aux = Anticiclo();
                //Si todos los items están seleccionados, Paramos
                if (Aux == 28)
                {
                    timer1.Enabled = false;
                    MessageBox.Show("Desmarca las casillas pedazo de Inutil xdxdxd");
                }
                pictureBox1.Width = 450;
                pictureBox1.Height = 450;
                label1.Visible = true; label10.Visible = false; label3.Visible = false; label4.Visible = false; label5.Visible = false; label6.Visible = false; label11.Visible = false;
                pictureBox1.Visible = true; pictureBox2.Visible = false; pictureBox3.Visible = false; pictureBox4.Visible = false; pictureBox5.Visible = false; pictureBox6.Visible = false; pictureBox7.Visible = false;
            }
            if (comboBox1.SelectedIndex == 1)
            {
                timer2.Enabled = true;
                int Aux = Anticiclo();
                //Si todos los items están seleccionados, Paramos
                if (Aux == 28)
                {
                    timer2.Enabled = false;
                    MessageBox.Show("Desmarca las casillas pedazo de Inutil xdxdxd");
                }
                pictureBox1.Width = 191;
                pictureBox1.Height = 137;
                label1.Visible = true; label10.Visible = true; label3.Visible = false; label4.Visible = false; label5.Visible = false; label6.Visible = false; label11.Visible = false;
                pictureBox1.Visible = true; pictureBox2.Visible = true; pictureBox3.Visible = false; pictureBox4.Visible = false; pictureBox5.Visible = false; pictureBox6.Visible = false; pictureBox7.Visible = false;
            }
            if (comboBox1.SelectedIndex == 2)
            {
                timer3.Enabled = true;
                int Aux = Anticiclo();
                //Si todos los items están seleccionados, Paramos
                if (Aux == 28)
                {
                    timer3.Enabled = false;
                    MessageBox.Show("Desmarca las casillas pedazo de Inutil xdxdxd");
                }
                pictureBox1.Width = 191;
                pictureBox1.Height = 137;
                label1.Visible = true; label10.Visible = true; label3.Visible = true; label4.Visible = true; label5.Visible = false; label6.Visible = false; label11.Visible = false;
                pictureBox1.Visible = true; pictureBox2.Visible = true; pictureBox3.Visible = true; pictureBox4.Visible = true; pictureBox5.Visible = false; pictureBox6.Visible = false; pictureBox7.Visible = false;
            }
        }

        //Verificar si no está marcada la casilla
        public bool VerificarLaCasilla(int N)
        {
            return checkedListBox1.GetItemChecked(N);
        }

        //Mandar un numero random que no este Checked
        public int MandarNumeroNoCheck()
        {
            int n = 0;
            Random rnd = new Random();
            n = rnd.Next(0,29);
            bool romperciclo = false;
            while (romperciclo == false)
            {
                if (VerificarLaCasilla(n) == true)
                {
                    n = rnd.Next(0,29);
                }
                else
                {
                    romperciclo = true;
                }
            }      
            return n;
        }

        //Random de las imagenes de uno
        int tiempo = 0; int R = 0; int v = 0;
        public void timer1_Tick(object sender, EventArgs e)
        {
            tiempo++;
            v = Anticiclo();
            textBox1.Text = "Tiempo " + tiempo;
            if (tiempo == 40)
            {
                timer1.Enabled = false;
                tiempo = 0;
            }
            else
            {
                R = G.Next(0, 28);
                if (VerificarLaCasilla(R) == true)
                {}
                else
                {
                    label9.Text = ArregloNombres[R];
                    pictureBox1.Image = Image.FromFile(Imagenes[R]);
                }
            }
        }

        //Contar cuantos items están seleccionados, evitar que se cicle
        int C1 = 0;
        public int Anticiclo()
        {
            C1 = 0;
            foreach (var item in checkedListBox1.CheckedItems)
            {
                C1++;
            }
            return C1;
        }

        //Random de las imagenes de parejas
        int R1 = 0; int R2 = 0; int tiempo2 = 0; int w = 0;
        public void timer2_Tick(object sender, EventArgs e)
        {
            int Aux = Anticiclo();
            tiempo2++;
            textBox1.Text = "Tiempo " + tiempo2;
                if (tiempo2 == 40)
                {
                    timer2.Enabled = false;
                    tiempo2 = 0;
                }
                else
                {
                    R1 = G.Next(0, 28);
                    R2 = G.Next(0, 28);
                    while (VerificarLaCasilla(R1) == true)
                    {
                        R1 = G.Next(0, 28);
                    }
                    while (VerificarLaCasilla(R2) == true)
                    {
                        R2 = G.Next(0, 28);
                    }
                    int m = NumeroDistinto(R1, R2);
                    pictureBox1.Image = Image.FromFile(Imagenes[R1]);
                    label9.Text = ArregloNombres[R1];
                    pictureBox2.Image = Image.FromFile(Imagenes[m]);
                    label10.Text = ArregloNombres[m];
                }
        }//Termina

        //Hacer que los números sean distintos de a 2
        int ValorAPasar = 0; 
        public int NumeroDistinto(int n1 , int n2)
        { 
            if (n2 == n1)
            {
                while (n2 == n1)
                {
                    n2 = G.Next(0, 28);
                    if (VerificarLaCasilla(n2) == false)
                    {
                        ValorAPasar = n2;
                    }
                    else
                    {
                        n2 = n1;
                    }
                }
                return ValorAPasar;
            }
            else
            {
                return n2;
            }        
        }

        //Random de a 4 
        int r1 = 0; int r2= 0; int r3 = 0; int r4 = 0;  int tiempo3 = 0; int k = 0;
        public void timer3_Tick(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}