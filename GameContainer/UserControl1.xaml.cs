using GalacticTycoon.Events;
using GalacticTycoon.Galaxy;
using GalacticTycoon.Player;
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

namespace GameContainer {
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl {
        private EventDeck _eventDeck;
        private Player _player;

        public UserControl1() {
            InitializeComponent();
            _eventDeck = new EventDeck();
            _player = new Player("Gracz 1");
            PlayerName.Text = _player.Name;
            PlayerCredits.Text = _player.GalacticCredits.ToString();
            PlayerCards.Text = _player.EventCards.Count.ToString();
        }
        // Obs�uga przycisku "Podr�uj"
        private void TravelButton_Click(object sender, RoutedEventArgs e) {
            MessageBox.Show("Podr�ujesz do wybranego uk�adu.");
        }

        // Obs�uga przycisku "Przejmij"
        private void TakeOverButton_Click(object sender, RoutedEventArgs e) {
            MessageBox.Show("Przejmujesz wybran� planet�.");
        }

        // Obs�uga przycisku "Buduj"
        private void BuildButton_Click(object sender, RoutedEventArgs e) {
            MessageBox.Show("Budujesz na wybranej planecie.");
        }

        // Obs�uga przycisku "Rozbuduj"
        private void UpgradeButton_Click(object sender, RoutedEventArgs e) {
            MessageBox.Show("Rozbudowujesz budynek na wybranej planecie.");
        }

        // Obs�uga przycisku "Losuj Kart�"
        private void DrawCardButton_Click(object sender, RoutedEventArgs e) {
            _eventDeck.AddCard(new PirateAttackCard());
            _eventDeck.AddCard(new DefenseAgainstPiratesCard());
            _eventDeck.AddCard(new GalacticTicketCard());
            _eventDeck.AddCard(new TaxCard());
            
            var card = _eventDeck.DrawCard();
            _player.EventCards.Add(card);
            
            if (card != null) {
                MessageBox.Show($"Wylosowano kart�: {card.Name}");
            } else {
                MessageBox.Show("Nie uda�o si� wylosowa� karty.");
            }
        }

    }

}
