using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace hockey_nhl
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            Players.Add(new Player("Greg Adams", "188 cm", StatusOptions.Injured, PositionOptions.LeftWing));
            Players.Add(new Player("Scott Daniels", "191 cm", StatusOptions.Active, PositionOptions.LeftWing));
            Players.Add(new Player("Doug Bodger", "188 cm", StatusOptions.Active, PositionOptions.Back));
            Players.Add(new Player("Mike Commodore", "193 cm", StatusOptions.Active, PositionOptions.Back));
            Players.Add(new Player("Matt Anderson", "180 cm", StatusOptions.Active, PositionOptions.RightWing));
            Players.Add(new Player("Rich Chernomaz", "173 cm", StatusOptions.Active, PositionOptions.RightWing));
            Players.Add(new Player("Tim Lenardon", "185 cm", StatusOptions.Active, PositionOptions.Center));
            Players.Add(new Player("Jim O'Brien", "188 cm", StatusOptions.Injured, PositionOptions.Center));
            Players.Add(new Player("Rod Pelley", "183 cm", StatusOptions.Minors, PositionOptions.Center));
            Players.Add(new Player("Bobby Holík", "193 cm", StatusOptions.Active, PositionOptions.Goalie));
            Players.Add(new Player("Randy McKay", "188 cm", StatusOptions.Injured, PositionOptions.Goalie));

            this.DataContext = this;

            PlayersBox.ItemsSource = Players;
            ActualBox.ItemsSource = ActualPlayers;
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            NewPlayer = new Player(string.Empty, string.Empty, StatusOptions.Active, PositionOptions.Center);
            Players.Add(NewPlayer);

            NHLRoster nrw = new NHLRoster();
            nrw.DataContext = NewPlayer;
            nrw.Show();
            // this.Close();
        }

        private void Mod_Click(object sender, RoutedEventArgs e)
        {
            // Get the selected Player(item)
            EditedPlayer = (Player)PlayersBox.SelectedItem;

            if (EditedPlayer == null)
            {
                EditedPlayer = (Player)ActualBox.SelectedItem;
            }

            if (EditedPlayer == null)
            {
                MessageBox.Show("Nem jelölt ki játékost.");
                return;
            }

            NHLRoster nrw = new NHLRoster();

            // A felugró ablakban egy játékos a DataContext, és ezen játékos tulajdonságon keresztül érhető el a főablakból
            nrw.DataContext = EditedPlayer;
            nrw.Show();
        }

        private ObservableCollection<Player> players = new ObservableCollection<Player>();
        private ObservableCollection<Player> actualPlayers = new ObservableCollection<Player>();

        // Az összes játékos ObservableCollectionája, közülük kerülnek ki a rostertagok, PlayersBox írja ki
        internal ObservableCollection<Player> Players
        {
            get
            {
                return players;
            }

            set
            {
                players = value;
            }
        }

        // Roster játékosok, ActualBox írja ki
        internal ObservableCollection<Player> ActualPlayers
        {
            get
            {
                return actualPlayers;
            }

            set
            {
                actualPlayers = value;
            }
        }

        internal Player SelectedPlayer { get; set; }

        internal Player EditedPlayer { get; set; }

        internal Player NewPlayer { get; set; }

        private void MoveFromPlayersToActual_Click(object sender, RoutedEventArgs e)
        {
            // Get the selected Player(item)
            SelectedPlayer = (Player)PlayersBox.SelectedItem;

            byte positionCount = 1;

            foreach (Player p in ActualPlayers)
            {
                if (SelectedPlayer.Position == p.Position)
                {
                    positionCount++;
                    if (p.Position == PositionOptions.Back && positionCount > 2)
                    {
                        MessageBox.Show("Már van két védő. Nem adhat hozzá többet.");
                        return;
                    }
                    if (p.Position != PositionOptions.Back && positionCount > 1)
                    {
                        MessageBox.Show("Ebből a státuszból már van egy, nem adhat hozzá többet.");
                        return;
                    }
                }
            }

            ActualPlayers.Add(SelectedPlayer);
            Players.Remove(SelectedPlayer);

        }

        private void MoveFromActualToPlayers_Click(object sender, RoutedEventArgs e)
        {
            // Get the selected Player(item)
            SelectedPlayer = (Player)ActualBox.SelectedItem;

            Players.Add(SelectedPlayer);
            ActualPlayers.Remove(SelectedPlayer);
        }

        private void Remove_Click(object sender, RoutedEventArgs e)
        {
            SelectedPlayer = (Player)PlayersBox.SelectedItem;

            if (SelectedPlayer == null)
            {
                SelectedPlayer = (Player)ActualBox.SelectedItem;
            }

            if (SelectedPlayer == null)
            {
                MessageBox.Show("Nem jelölt ki játékost.");
                return;
            }

            Players.Remove(SelectedPlayer);
        }
    }
}
