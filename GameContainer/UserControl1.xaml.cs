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
        public UserControl1() {
            InitializeComponent();
        }
        // Obs³uga przycisku "Podró¿uj"
        private void TravelButton_Click(object sender, RoutedEventArgs e) {
            MessageBox.Show("Podró¿ujesz do wybranego uk³adu.");
        }

        // Obs³uga przycisku "Przejmij"
        private void TakeOverButton_Click(object sender, RoutedEventArgs e) {
            MessageBox.Show("Przejmujesz wybran¹ planetê.");
        }

        // Obs³uga przycisku "Buduj"
        private void BuildButton_Click(object sender, RoutedEventArgs e) {
            MessageBox.Show("Budujesz na wybranej planecie.");
        }

        // Obs³uga przycisku "Rozbuduj"
        private void UpgradeButton_Click(object sender, RoutedEventArgs e) {
            MessageBox.Show("Rozbudowujesz budynek na wybranej planecie.");
        }

        // Obs³uga przycisku "Losuj Kartê"
        private void DrawCardButton_Click(object sender, RoutedEventArgs e) {
            MessageBox.Show("Losujesz kartê z talii.");
        }
    }

}
