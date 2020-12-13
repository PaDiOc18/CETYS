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
                pictureBox1.Image = Image.FromFile("InicioImagen.jpg");
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
                pictureBox1.Image = Image.FromFile("InicioImagen.jpg");
                pictureBox2.Image = Image.FromFile("InicioImagen.jpg");
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
                pictureBox1.Image = Image.FromFile("InicioImagen.jpg");
                pictureBox2.Image = Image.FromFile("InicioImagen.jpg");
                label1.Visible = true; label10.Visible = true; label3.Visible = true; label4.Visible = true; label5.Visible = false; label6.Visible = false; label11.Visible = false;
                pictureBox1.Visible = true; pictureBox2.Visible = true; pictureBox3.Visible = true; pictureBox4.Visible = true; pictureBox5.Visible = false; pictureBox6.Visible = false; pictureBox7.Visible = false;
            }
        }

        //Verificar si no está marcada la casilla
        public bool VerificarLaCasilla(int N)
        {
            return checkedListBox1.GetItemChecked(N);
        }

        //Random de las imagenes de uno
        int tiempo = 0; int R = 0; int v = 0;
        public void timer1_Tick(object sender, EventArgs e)
        {
            R = G.Next(0,28);
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
                if (VerificarLaCasilla(R) == false)
                {
                    label9.Text = ArregloNombres[R];
                    pictureBox1.Image = Image.FromFile(Imagenes[R]);
                }
                else
                {
                }
            }
        }

        //Contar cuantos items están seleccionados
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
            int Aux = Anticiclo();
            tiempo3++;
            textBox1.Text = "Tiempo " + tiempo3;
            if (tiempo3 == 40)
            {
                timer3.Enabled = false;
                tiempo3 = 0;
                int v1 = G.Next(0, 28);
                int v2 = G.Next(0, 28);
                int v3 = G.Next(0, 28);
                int v4 = G.Next(0, 28);
                //Comparacion 1 
                bool estado = true;
                while (estado == true)
                {
                    if (v1 == v2)
                    {
                        v1 = G.Next(0, 28);
                    }
                    else if (v1 == v3)
                    {
                        v1 = G.Next(0, 28);
                    }
                    else if (v1 == v4)
                    {
                        v1 = G.Next(0, 28);
                    }
                    else
                    {
                        if (VerificarLaCasilla(v1) == true)
                        {
                            v1 = v2;
                        }
                        else
                        {
                            estado = false;
                            break;
                        }
                    }
                }
                //Comparacion 2 
                bool estado2 = true;
                while (estado2 == true)
                {
                    if (v2 == v1)
                    {
                        v2 = G.Next(0, 28);
                    }
                    else if (v2 == v3)
                    {
                        v2 = G.Next(0, 28);
                    }
                    else if (v2 == v4)
                    {
                        v2 = G.Next(0, 28);
                    }
                    else
                    {
                        if (VerificarLaCasilla(v2) == true)
                        {
                            v2 = v1;
                        }
                        else
                        {
                            estado2 = false;
                            break;
                        }
                    }
                }
                //Comparacion 3 
                bool estado3 = true;
                while (estado3 == true)
                {
                    if (v3 == v1)
                    {
                        v3 = G.Next(0, 28);
                    }
                    else if (v3 == v2)
                    {
                        v3 = G.Next(0, 28);
                    }
                    else if (v3 == v4)
                    {
                        v3 = G.Next(0, 28);
                    }
                    else
                    {
                        if (VerificarLaCasilla(v3) == true)
                        {
                            v3 = v1;
                        }
                        else
                        {
                            estado3 = false;
                            break;
                        }
                    }
                }
                //Comparacion 4 
                bool estado4 = true;
                while (estado4 == true)
                {
                    if (v4 == v1)
                    {
                        v4 = G.Next(1, 11);
                    }
                    else if (v4 == v3)
                    {
                        v4 = G.Next(1, 11);
                    }
                    else if (v4 == v2)
                    {
                        v4 = G.Next(1, 11);
                    }
                    else
                    {
                        if (VerificarLaCasilla(v4) == true)
                        {
                            v4 = v1;
                        }
                        else
                        {
                            estado4 = false;
                            break;
                        }
                    }
                }
                label1.Text = v1.ToString();
                label2.Text = v2.ToString();
                label3.Text = v3.ToString();
                label4.Text = v4.ToString();
                pictureBox1.Image = Image.FromFile(Imagenes[v1]);
                label9.Text = ArregloNombres[v1];
                pictureBox2.Image = Image.FromFile(Imagenes[v2]);
                label10.Text = ArregloNombres[v2];
                pictureBox3.Image = Image.FromFile(Imagenes[v3]);
                label3.Text = ArregloNombres[v3];
                pictureBox4.Image = Image.FromFile(Imagenes[v4]);
                label4.Text = ArregloNombres[v4];
            }
            else
            {
                r1 = G.Next(0, 28);
                r2 = G.Next(0, 28);
                r3 = G.Next(0, 28);
                r4 = G.Next(0, 28);
                while (VerificarLaCasilla(r1) == true)
                {
                    r1 = G.Next(0, 28);
                }
                while (VerificarLaCasilla(r2) == true)
                {
                    r2 = G.Next(0, 28);
                }
                while (VerificarLaCasilla(r3) == true)
                {
                    r3 = G.Next(0, 28);
                }
                while (VerificarLaCasilla(r4) == true)
                {
                    r4 = G.Next(0, 28);
                }
                pictureBox1.Image = Image.FromFile(Imagenes[r1]);
                label9.Text = ArregloNombres[r1];
                pictureBox2.Image = Image.FromFile(Imagenes[r2]);
                label10.Text = ArregloNombres[r2];
                pictureBox3.Image = Image.FromFile(Imagenes[r3]);
                label3.Text = ArregloNombres[r3];
                pictureBox4.Image = Image.FromFile(Imagenes[r4]);
                label4.Text = ArregloNombres[r4];
            }
        }

    }
}