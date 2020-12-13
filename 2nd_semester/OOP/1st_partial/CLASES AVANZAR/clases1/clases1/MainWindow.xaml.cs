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

namespace clases1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        persona[] personas = new persona[10];
        int cuantas = 0;
        int IndiceEmpleados = 1;
        // es una variable de la clase 
        // el constructor indica las reglas de lo que es indispensable para crear una persona

        public MainWindow()
        {
            InitializeComponent();
            //j = new persona("Pablo", "Díaz", new DateTime(1999,09,27));
            //persona x = new persona("fofo", "Mauricio", "Romero", new DateTime(1999, 12, 01));
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            string Nom = txtNombre.Text;
            string Apater = txtAP.Text;
            string Amater = txtAM.Text;
            DateTime fechita = (DateTime)DP.SelectedDate;
            if (rbAgregarAlumno.IsChecked == true)
            {
                int Matricula = int.Parse(txtMatricula.Text);
                string Carrera = txtCarrera.Text;
                int Semestre = int.Parse(txtSemestre.Text);
                Alumno a = new Alumno(Matricula, Carrera, Semestre, Nom, Apater, Amater, fechita);
                //persona p = new persona(Nom, Apater, Amater, fechita);
                //personas[cuantas] = p;
                personas[cuantas] = a;
                cuantas++;
                txtMatricula.Text = ""; txtCarrera.Text = ""; txtSemestre.Text = "";
            }
            else if (rbAgregarDocente.IsChecked == true)
            {
                double sueldo = double.Parse(txtSueldo.Text);
                string Materias = txtMaterias.Text;
                int Tipo = int.Parse(txtTipo.Text);
                int Nivel = int.Parse(txtNivel.Text);
                DateTime fechaIngreso = DateTime.Now;
                Docente d = new Docente(Materias, Nivel, Tipo, IndiceEmpleados, sueldo, Nom, fechaIngreso, Apater, Amater, fechita);
                //persona p = new persona(Nom, Apater, Amater, fechita);
                //personas[cuantas] = p;
                personas[cuantas] = d;
                cuantas++;
                IndiceEmpleados++;
                txtSueldo.Text = "";
                txtMaterias.Text = "";
                txtTipo.Text = "";
                txtNivel.Text = "";
            }
            else if (rbAdministrativo.IsChecked == true)
            {
                double sueldo = double.Parse(txtSueldo.Text);
                string departamento = txtDepartamento.Text;
                string turno = txtTurno.Text;
                DateTime fechaIngreso = DateTime.Now;
                Administrativo admin = new Administrativo(departamento, turno, IndiceEmpleados, sueldo, Nom, fechaIngreso, Apater, Amater, fechita);
                //persona p = new persona(Nom, Apater, Amater, fechita);
                //personas[cuantas] = p;
                personas[cuantas] = admin;
                cuantas++;
                IndiceEmpleados++;
                txtSueldo.Text = "";
                txtMaterias.Text = "";
                txtTipo.Text = "";
                txtNivel.Text = "";
                txtDepartamento.Text = "";
                txtTurno.Text = "";
            }
            else
            {
                MessageBox.Show("Favor de seleccionar una opción");
            }
            listwiewjeje.ItemsSource = personas;
            listwiewjeje.Items.Refresh();
            txtNombre.Text = ""; txtAM.Text = ""; txtAP.Text = ""; DP = null;
            txtMatricula.Text = ""; 

        }

        private void BtnBorrar_Click(object sender, RoutedEventArgs e)
        {
            string eliminar = txtBorrar.Text;
            for (int i = 0; i < 10; i++)
            {
                if (eliminar == personas[i].apellidopaterno)
                {
                    personas[i].apellidopaterno = "";
                    personas[i].nombre = "";
                    listwiewjeje.Items.Refresh();
                    break;
                }
            }

        }
    }
}
