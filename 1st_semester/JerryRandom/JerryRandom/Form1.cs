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

namespace JerryRandom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex=0;
        }
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        { }
        Random NumAleatorio = new Random();
        string[] Imagenes = new string[28] { "Adolfo.jpg", "Alec.jpg", "Alejandro.jpg", "Carlos.jpg", "David.jpg", "Diego.jpg", "el 08.jpg", "Fausto.jpg", "Grauyi.jpg", "Isaac Reyes.jpg", "Isaac Sanchez.jpg", "Isaac.jpg", "Juampy.jpg", "Kevin Huerta.jpg", "Kevin.jpg", "Lola.jpg", "Manolo.jpg", "Mejia.jpg", "Miguel.jpg", "Mizael.jpg", "Nestor.jpg", "Oscar.jpg", "Pablo.jpg", "Rubs.jpg", "Sando.jpg", "Silvia.jpg", "Smith.jpg", "Xavier.jpg" };
        string[] ArregloNombres = new string[28] { "Adolfo", "Alec", "Alejandro", "Carlos", "David", "Diego", "el 08", "Fausto", "Angel", "Isaac Reyes", "Isaac Sanchez", "Isaac", "Juampy", "Kevin Huerta", "Kevin", "Lola", "Manolo", "Mejia", "Miguel", "Mizael", "Nestor", "Oscar", "Pablo", "Rubs", "Sando", "Silvia", "Smith", "Xavier" };
        public int NumRandomVerificado()
        {
            int ValorRegresar = 0;
            if (Anticiclo() == 28)
            {
                timer1.Enabled = false;
                timer2.Enabled = false;
                timer3.Enabled = false;
            }
            else
            {
            hola:
                int Num = NumAleatorio.Next(0, 28);
                if (checkedListBox1.GetItemChecked(Num) == false)
                {
                    ValorRegresar = Num;
                }
                else
                {
                    goto hola;
                }
            }
            return ValorRegresar;
        }
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
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer("SM.wav");
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                player1.Play();
                pictureBox1.Width = 400; pictureBox1.Height = 400;
                pictureBox1.Visible = true; pictureBox2.Visible = false; pictureBox3.Visible = false; pictureBox4.Visible = false;
                label1.Visible = true;  label3.Visible = false;  label6.Visible = false;
                label8.Visible = false; 
                timer1.Enabled = true;
                if (Anticiclo() == 28)
                {
                    player1.Stop();
                    timer1.Enabled = false;
                    MessageBox.Show("Desmarca las casillas Por favor");

                }
                else { timer1.Enabled = true; }
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                player1.Play();
                pictureBox1.Width = 152; pictureBox1.Height = 140;
                pictureBox1.Visible = true; pictureBox2.Visible = true; pictureBox3.Visible = false; pictureBox4.Visible = false;
                label1.Visible = true;  label3.Visible = true;  label6.Visible = false;
                label8.Visible = false; 
                timer2.Enabled = true;               
                if (Anticiclo() == 28)
                {
                    player1.Stop();
                    timer2.Enabled = false;
                    MessageBox.Show("Desmarca las casillas Por favor");
                }
                else if(Anticiclo() >= 27)
                {
                    player1.Stop();
                    timer2.Enabled = false;
                    MessageBox.Show("Desmarca mínimo 2 casillas Por favor");
                }
                    else { timer2.Enabled = true; }
            }
            else if(comboBox1.SelectedIndex == 2)
            {
                player1.Play();
                pictureBox1.Visible = true; pictureBox2.Visible = true; pictureBox3.Visible = true; pictureBox4.Visible = true;
                label1.Visible = true;  label3.Visible = true;  label6.Visible = true;
                label8.Visible = true; 
                if (Anticiclo() == 28)
                {
                    player1.Stop();
                    timer3.Enabled = false;
                    MessageBox.Show("Desmarca las casillas Por favor");
                }
                else if (Anticiclo() >= 25)
                {
                    player1.Stop();
                    timer3.Enabled = false;
                    MessageBox.Show("Desmarca mínimo 4 casillas Por favor");
                }
                    else { timer3.Enabled = true; }
            }
            else { MessageBox.Show("Selecciona un numero"); }
        }
        int DuraTimer = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            DuraTimer++;
            int a = NumRandomVerificado();
            pictureBox1.Image = Image.FromFile(Imagenes[a]);
            label1.Text = ArregloNombres[a];
            if (DuraTimer == 30)
            {
                player1.Stop();
                timer1.Enabled = false;
                DuraTimer = 0;
                timer4.Enabled = true;
            }
        }
        int DuraTimer2 = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            DuraTimer2++;
            int a = NumRandomVerificado(); int b = NumRandomVerificado();
            if (a == b)
            {
                while (b == a)
                {
                    if (Anticiclo() == 28)
                    {
                        timer2.Enabled = false;
                        player1.Stop();
                        break;
                    }
                    else
                    { b = NumRandomVerificado(); }                    
                }
            }
            pictureBox1.Image = Image.FromFile(Imagenes[a]); pictureBox2.Image = Image.FromFile(Imagenes[b]);
            label1.Text = ArregloNombres[a]; 
            label3.Text = ArregloNombres[b]; 
            if (DuraTimer2 == 30)
            {
                timer2.Enabled = false;
                DuraTimer2 = 0;
                player1.Stop();
            }
        }
        int DuraTimer3 = 0;
        private void timer3_Tick(object sender, EventArgs e)
        {
            //Mete numeros en un arreglo y compararlos 
            DuraTimer3++;
            int a = NumRandomVerificado(); int b = NumRandomVerificado(); int c = NumRandomVerificado(); int d = NumRandomVerificado();
            int[] CuatroNumeros = new int[4];
            CuatroNumeros[0] = a; CuatroNumeros[1] = b; CuatroNumeros[2] =c; CuatroNumeros[3] = d;
            if (DuraTimer3 == 30)
            {
                timer3.Enabled = false;
                player1.Stop();
                DuraTimer3 = 0;
                CicloAntijeje:
                for (int i = 0; i < CuatroNumeros.Length; i++)
                {
                    int conta = 0;
                    for (int j = 0; j < CuatroNumeros.Length; j++)
                    {
                        if (CuatroNumeros[i] == CuatroNumeros[j])
                        {
                            conta = conta + 1;
                        }
                    }
                    if (conta >1)
                    {
                        CuatroNumeros[i] = NumRandomVerificado();
                        goto CicloAntijeje;
                    }
                }          
            }
            pictureBox1.Image = Image.FromFile(Imagenes[CuatroNumeros[0]]); pictureBox2.Image = Image.FromFile(Imagenes[CuatroNumeros[1]]);
            pictureBox3.Image = Image.FromFile(Imagenes[CuatroNumeros[2]]); pictureBox4.Image = Image.FromFile(Imagenes[CuatroNumeros[3]]);
            label1.Text = ArregloNombres[CuatroNumeros[0]]; 
            label3.Text = ArregloNombres[CuatroNumeros[1]]; 
            label6.Text = ArregloNombres[CuatroNumeros[2]]; 
            label8.Text = ArregloNombres[CuatroNumeros[3]]; 
        }
        int Duratimer4;
        private void timer4_Tick(object sender, EventArgs e)
        {
            Duratimer4++;
            if (Duratimer4 == 4)
            {
                pictureBox1.Image = Image.FromFile("Surprise.jpg");
                System.Media.SoundPlayer player2 = new System.Media.SoundPlayer("SurpriseM.wav");
                player2.Play();
            }
            else if (Duratimer4 == 7)
            {
                int h = NumRandomVerificado();
                pictureBox1.Image = Image.FromFile(Imagenes[h]);
                label1.Text = ArregloNombres[h];
                timer4.Enabled = false;
                Duratimer4 = 0;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ArregloNombres.Length; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }
        }
    }
}
