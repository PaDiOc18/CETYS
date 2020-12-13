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
using Newtonsoft.Json;
using System.IO;
using System.Xml.Serialization;


namespace Serializacion
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<EquipoNBA> ListaEquiposNBA = new List<EquipoNBA>();
        public MainWindow()
        {
            InitializeComponent();

            EquipoNBA GoldenState = new EquipoNBA();
            GoldenState.Coach = "Steve Kerr";
            GoldenState.Asistente = "Mike Brown";
            GoldenState.Ciudad = "Oakland, California";
            GoldenState.Propietario = "Clayton Bennet";
            GoldenState.NombreEquipo = "Golden State";
            GoldenState.ListaJugadores.Add("Stephen Curry");
            GoldenState.ListaJugadores.Add("Kevin Durant");
            GoldenState.ListaJugadores.Add("Draymond Green");
            GoldenState.ListaJugadores.Add("Klay Thompson");
            GoldenState.ListaJugadores.Add("DeMarcus Cousins");
            ListaEquiposNBA.Add(GoldenState);

            EquipoNBA OklahomaCity = new EquipoNBA();
            OklahomaCity.Coach = "Billy Donovan";
            OklahomaCity.Asistente = "Bob Beyer";
            OklahomaCity.NombreEquipo = "Oklahoma City Thunder";
            OklahomaCity.Ciudad = "Oklahoma";
            OklahomaCity.Propietario = "Clay Bennett";
            OklahomaCity.ListaJugadores.Add("Russell Westbrook");
            OklahomaCity.ListaJugadores.Add("Paul George");
            OklahomaCity.ListaJugadores.Add("Steven Adams");
            OklahomaCity.ListaJugadores.Add("André Roberson");
            OklahomaCity.ListaJugadores.Add("Markieff Morris");
            ListaEquiposNBA.Add(OklahomaCity);

            EquipoNBA BostonCeltics = new EquipoNBA();
            BostonCeltics.Coach = "Brad Stevens";
            BostonCeltics.Asistente = "Jamie Young";
            BostonCeltics.Ciudad = "Boston (Massachusets)";
            BostonCeltics.Propietario = "Boston Basketball Partners L.L.C.";
            BostonCeltics.NombreEquipo = "Boston Celtics";
            BostonCeltics.ListaJugadores.Add("Kyrie Irving");
            BostonCeltics.ListaJugadores.Add("Marcus Smart");
            BostonCeltics.ListaJugadores.Add("Jayson Tatum");
            BostonCeltics.ListaJugadores.Add("Marcus Morris");
            BostonCeltics.ListaJugadores.Add("Aron Baynes");
            ListaEquiposNBA.Add(BostonCeltics);

            EquipoNBA HoustonRockets = new EquipoNBA();
            HoustonRockets.Coach = "Mike D'Antoni";
            HoustonRockets.Asistente = "Jeff Bzdelik";
            HoustonRockets.Ciudad = "Houston (Texas)";
            HoustonRockets.Propietario = "Tilman Fertitta";
            HoustonRockets.NombreEquipo = "Houston Rockets";
            HoustonRockets.ListaJugadores.Add("James Harden");
            HoustonRockets.ListaJugadores.Add("Chris Paul");
            HoustonRockets.ListaJugadores.Add("Eric Gordon");
            HoustonRockets.ListaJugadores.Add("Clint Capela");
            HoustonRockets.ListaJugadores.Add("Kenneth Faried");
            ListaEquiposNBA.Add(HoustonRockets);

            EquipoNBA MilwaukeeBucks = new EquipoNBA();
            MilwaukeeBucks.Coach = "Mike Budenholzer";
            MilwaukeeBucks.Asistente = "Darvin Ham";
            MilwaukeeBucks.Ciudad = "Milwaukee (Wisconsin)";
            MilwaukeeBucks.Propietario = "Wesley Edens & Marc Lasry";
            MilwaukeeBucks.NombreEquipo = "Milwaukee Bucks";
            MilwaukeeBucks.ListaJugadores.Add("G. Antetokounmpo");
            MilwaukeeBucks.ListaJugadores.Add("Eric Bledsoe");
            MilwaukeeBucks.ListaJugadores.Add("Malcolm Brogdon");
            MilwaukeeBucks.ListaJugadores.Add("Brook Lopez");
            MilwaukeeBucks.ListaJugadores.Add("Khris Middleton");
            ListaEquiposNBA.Add(MilwaukeeBucks);

            EquipoNBA Lakers = new EquipoNBA();
            Lakers.Coach = "Luke Walton";
            Lakers.Asistente = "Jesse Mermuys";
            Lakers.Ciudad = "Los Angeles (California)";
            Lakers.Propietario = "Buss Family";
            Lakers.NombreEquipo = "Los Angeles Lakers";
            Lakers.ListaJugadores.Add("Lebron James");
            Lakers.ListaJugadores.Add("Rajon Rondo");
            Lakers.ListaJugadores.Add("Brandon Ingram");
            Lakers.ListaJugadores.Add("Lance Stephenson");
            Lakers.ListaJugadores.Add("Kyle Kuzma");
            ListaEquiposNBA.Add(Lakers);

            EquipoNBA Portland = new EquipoNBA();
            Portland.Coach = "Terry Stotts";
            Portland.Asistente = "David Vanterpool";
            Portland.Ciudad = "Portland (Oregon)";
            Portland.Propietario = "Paul Allen";
            Portland.NombreEquipo = "Los Angeles Lakers";
            Portland.ListaJugadores.Add("Damian Lillard");
            Portland.ListaJugadores.Add("Seth Curry");
            Portland.ListaJugadores.Add("Enes Kanter");
            Portland.ListaJugadores.Add("Moe Harkless");
            Portland.ListaJugadores.Add("Evan Turner");
            ListaEquiposNBA.Add(Portland);

            EquipoNBA Minnesota = new EquipoNBA();
            Minnesota.Coach = "Ryan Saunders";
            Minnesota.Asistente = "Larry Greer";
            Minnesota.Ciudad = "Minneapolis (Minnesota)";
            Minnesota.Propietario = "Glen Taylor";
            Minnesota.NombreEquipo = "Minnesota Timberwolves";
            Minnesota.ListaJugadores.Add("Derrick Rose");
            Minnesota.ListaJugadores.Add("Jeff Teague");
            Minnesota.ListaJugadores.Add("Josh Okogie");
            Minnesota.ListaJugadores.Add("Dario Saric");
            Minnesota.ListaJugadores.Add("Taj Gibson");
            ListaEquiposNBA.Add(Minnesota);

            EquipoNBA Dallas = new EquipoNBA();
            Dallas.Coach = "Rick Carlisle";
            Dallas.Asistente = "Stephen Silas";
            Dallas.Ciudad = "Dallas (Texas)";
            Dallas.Propietario = "Mark Cuban";
            Dallas.NombreEquipo = "Dallas Mavericks";
            Dallas.ListaJugadores.Add("Luka Doncic");
            Dallas.ListaJugadores.Add("Tim Hardaway Jr.");
            Dallas.ListaJugadores.Add("Dirk Nowitzki");
            Dallas.ListaJugadores.Add("Kristaps Porzingis");
            Dallas.ListaJugadores.Add("Daryl Macon");
            ListaEquiposNBA.Add(Dallas);

            EquipoNBA Toronto = new EquipoNBA();
            Toronto.Coach = "Nick Nurse";
            Toronto.Asistente = "Adrian Griffin";
            Toronto.Ciudad = "Toronto (Ontario)";
            Toronto.Propietario = "Maple Leaf Sports & Entertainmente, Ltd. (MLSE)";
            Toronto.NombreEquipo = "Toronto Raptors";
            Toronto.ListaJugadores.Add("Kyle Lowry");
            Toronto.ListaJugadores.Add("Danny Green");
            Toronto.ListaJugadores.Add("Kawhi Leonard");
            Toronto.ListaJugadores.Add("Pascal Siakam");
            Toronto.ListaJugadores.Add("Serge Ibaka");
            ListaEquiposNBA.Add(Toronto);

            int numequipos = 0;
            foreach (var item in ListaEquiposNBA)
            {
                File.AppendAllText("EquipillosNBA.json", "EQUIPO DE LA NBA #" + numequipos + "\n");
                string NomEquipo = JsonConvert.SerializeObject(item.NombreEquipo);
                File.AppendAllText("EquipillosNBA.json", "Nombre del Equipo:" + NomEquipo + "\n");
                string coach = JsonConvert.SerializeObject(item.Coach);
                File.AppendAllText("EquipillosNBA.json", "Coach:" + coach + "\n");
                string asistente = JsonConvert.SerializeObject(item.Asistente);
                File.AppendAllText("EquipillosNBA.json", "Asistente: "+ asistente + "\n");
                string ciudad = JsonConvert.SerializeObject(item.Ciudad);
                File.AppendAllText("EquipillosNBA.json", "Ciudad: " + ciudad + "\n");
                string propietario = JsonConvert.SerializeObject(item.Propietario);
                File.AppendAllText("EquipillosNBA.json", "Propietario: " + propietario + "\n");
                string jugadores = JsonConvert.SerializeObject(item.ListaJugadores);
                File.AppendAllText("EquipillosNBA.json", "Jugadores: " + jugadores + "\n");
                numequipos++;
            }

            //foreach (var item in ListaEquiposNBA)
            //{
            //    string contenido = JsonConvert.SerializeObject(item);
            //    File.AppendAllText("EquipillosNBA.json", contenido + "\n");
            //}

            XmlSerializer xmlserializador = new XmlSerializer(typeof(EquipoNBA));
            Stream elstream = new FileStream("EquiposNBA.eqnba", FileMode.OpenOrCreate);
            foreach (var Equipo in ListaEquiposNBA)
            {
                xmlserializador.Serialize(elstream, Equipo);
            }
            elstream.Close();
        }
    }
}
