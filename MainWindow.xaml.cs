using System.Collections;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Resolvers;

namespace WPF_MainPlayerTeam
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Initialize Global Variables
        public ObservableCollection<Player> players;
        public ObservableCollection<Team> teams;

        public MainWindow()
        {
            InitializeComponent(); // App Starts
            Preload(); // Run the 'Preload' Method I created below


            // update ListBox data with the following data
            //lbPlayers.ItemsSource = players;
            //lbTeams.ItemsSource = teams;

        }

        void Preload()
        {
            // New Instance of Objects
            ObservableCollection<Player> players = new ObservableCollection<Player>();
            ObservableCollection<Team> teams = new ObservableCollection<Team>();

            // Aggregate Data Created
            players.Add(new Player("Steph Curry", "Golden State Warriors", 30));
            players.Add(new Player("Bander Saleh", "Slopestyle - Team", 1));
            players.Add(new Player("Josiah Blee", "Slopestyle - Team", 2));
            players.Add(new Player("Sam Asken", "Slopestyle - Team", 3));
            players.Add(new Player("Jake Dotston", "Big Air - Team", 1));
            players.Add(new Player("Chloe Kim", "Superpipe - Team", 1));

            

        }
        private void btnNewPlayer_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnNewTeam_Click(object sender, RoutedEventArgs e)
        {

        }

        private void lbPlayers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void lbTeams_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

    }
}