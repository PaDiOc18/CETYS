using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomSuperFacil
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            label1.Visible = false; label2.Visible = false; label3.Visible = false; label4.Visible = false; label5.Visible = false; label6.Visible = false; label7.Visible = false;
            pictureBox1.Visible = false; pictureBox2.Visible = false; pictureBox3.Visible = false; pictureBox4.Visible = false; pictureBox5.Visible = false; pictureBox6.Visible = false; pictureBox7.Visible = false;
        }

        public void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                timer1.Enabled = true;
                pictureBox1.Image = Image.FromFile("InicioImagen.jpg");
                pictureBox1.Width = 450;
                pictureBox1.Height = 450;
                label1.Visible = true; label2.Visible = false; label3.Visible = false; label4.Visible = false; label5.Visible = false; label6.Visible = false; label7.Visible = false;
                pictureBox1.Visible = true; pictureBox2.Visible = false; pictureBox3.Visible = false; pictureBox4.Visible = false; pictureBox5.Visible = false; pictureBox6.Visible = false; pictureBox7.Visible = false;
            }
            if (comboBox1.SelectedIndex == 1)
            {
                timer2.Enabled = true;
                pictureBox1.Width = 191;
                pictureBox1.Height = 137;
                pictureBox1.Image = Image.FromFile("InicioImagen.jpg");
                pictureBox2.Image = Image.FromFile("InicioImagen.jpg");
                label1.Visible = true; label2.Visible = true; label3.Visible = false; label4.Visible = false; label5.Visible = false; label6.Visible = false; label7.Visible = false;
                pictureBox1.Visible = true; pictureBox2.Visible = true; pictureBox3.Visible = false; pictureBox4.Visible = false; pictureBox5.Visible = false; pictureBox6.Visible = false; pictureBox7.Visible = false;
            }
            if (comboBox1.SelectedIndex == 2)
            {
                label1.Visible = true; label2.Visible = true; label3.Visible = true; label4.Visible = true; label5.Visible = false; label6.Visible = false; label7.Visible = false;
                pictureBox1.Visible = true; pictureBox2.Visible = true; pictureBox3.Visible = true; pictureBox4.Visible = true; pictureBox5.Visible = false; pictureBox6.Visible = false; pictureBox7.Visible = false;
            }
            if (comboBox1.SelectedIndex == 3)
            {
                label1.Visible = true; label2.Visible = true; label3.Visible = true; label4.Visible = true; label5.Visible = true; label6.Visible = true; label7.Visible = true;
                pictureBox1.Visible = true; pictureBox2.Visible = true; pictureBox3.Visible = true; pictureBox4.Visible = true; pictureBox5.Visible = true; pictureBox6.Visible = true; pictureBox7.Visible = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        //Random 1 persona
        int DuracionTimer = 0, Aux = 0;
        public void timer1_Tick(object sender, EventArgs e)
        {
            int P = GenerarNumRandom();
            Randomizar(P,pictureBox1,label1);
            DuracionTimer++;
            //Termina el timer y sale la última foto
            if (DuracionTimer == 50)
            {
                timer1.Enabled = false;
                DuracionTimer = 0;
                //timer4.Enabled = true;
            }
        }

        //Randomizar imagenes 
        string[] Imagenes = new string[28] { "Adolfo.jpg", "Alec.jpg", "Alejandro.jpg", "Carlos.jpg", "David.jpg", "Diego.jpg" , "el 08.jpg", "Fausto.jpg","Grauyi.jpg","Isaac Reyes.jpg","Isaac Sanchez.jpg","Isaac.jpg","Juampy.jpg", "Kevin Huerta.jpg", "Kevin.jpg", "Lola.jpg", "Manolo.jpg","Mejia.jpg","Miguel.jpg","Mizael.jpg","Nestor.jpg","Oscar.jpg","Pablo.jpg","Rubs.jpg","Sando.jpg","Silvia.jpg","Smith.jpg","Xavier.jpg"};
        string[] ArregloNombres = new string[28] { "Adolfo", "Alec", "Alejandro", "Carlos", "David", "Diego", "el 08", "Fausto", "Angel", "Isaac Reyes", "Isaac Sanchez", "Isaac", "Juampy", "Kevin Huerta", "Kevin", "Lola", "Manolo", "Mejia", "Miguel", "Mizael", "Nestor", "Oscar", "Pablo", "Rubs", "Sando", "Silvia", "Smith", "Xavier" };

        public void Randomizar(int P, PictureBox pic, Label etiqueta)
        {
            Aux = VerificarLaCasilla(P);
            if (Aux == 1)
            {
                etiqueta.Text = ArregloNombres[P];
                pic.Image = Image.FromFile(Imagenes[P]);
            }         
            else
            { }
        }

        //Verificar si no está marcada la casilla
        public int VerificarLaCasilla(int N)
        {
            if (checkedListBox1.GetItemChecked(N) == false)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        //Generar un Número Random
        public int GenerarNumRandom()
        {
            int num = 0;
            Random G = new Random();
            num = G.Next(0,27);
            return num;
        }

        //Evitar la repeticion de 2 imagenes
        int Valor = 0;
        public int EvitarRepeticion2(int n1,int n2, PictureBox pic1, PictureBox pic2, Label Etiqueta)
        {
            Random averque = new Random();
            Valor = 0;
            if (pictureBox1.Image == pictureBox2.Image)
            {
                while (n1 == n2)
                {
                    if (Anticiclo() == 28)
                    {
                        MessageBox.Show("Ya están todos seleccionados amigo");
                        timer1.Enabled = false;
                        break;
                    }
                    n2 = averque.Next(0, 27);
                    if (VerificarLaCasilla(n2) == 1)
                    {
                        Valor = n2;
                        pic2.Image = Image.FromFile(Imagenes[Valor]);
                        Etiqueta.Text = ArregloNombres[Valor];
                    }
                    else { }
                }
                Valor = 0;
            }
            else
            {
            }
            return Valor;
        }

        //Randomizar Imagenes 2
        int Sumar = 0;
        public void timer2_Tick(object sender, EventArgs e)
        {
            int k = GenerarNumRandom(); 
            int h = GenerarNumRandom();
            Randomizar(h,pictureBox1,label1);
            Randomizar(k,pictureBox2,label2);
            Sumar++;
            if (Sumar == 60)
            {
                timer2.Enabled = false;
                EvitarRepeticion2(k,h,pictureBox1,pictureBox2,label2);
                //pictureBox2.Image = Image.FromFile(Imagenes[ox]);
                //label2.Text = ArregloNombres[ox];
                Sumar = 0;
            }

        }

        //Timer auxiliar elemento sorpresa
        int aumento = 0;
        public void timer4_Tick(object sender, EventArgs e)
        {
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

    }
}
