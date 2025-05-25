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

namespace ZIG11_APP {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        private GenericTypesDemo demo = new();
        public List<string> Types { get; } = new() { "queue", "vector", "list", "map", "set", "dictionary" };

        public MainWindow() {
            InitializeComponent();
            DataContext = this;
            OperationComboBox.SelectedIndex = 0;
            OutputBox.Text = demo.GetAllContents();
        }

        private void ExecuteButton_Click(object sender, RoutedEventArgs e) {
            string type = TypeComboBox.SelectedItem as string;
            string operation = (OperationComboBox.SelectedItem as ComboBoxItem)?.Content as string;
            string key = KeyBox.Text;
            string value = ValueBox.Text;

            if (string.IsNullOrWhiteSpace(type) || string.IsNullOrWhiteSpace(operation) || string.IsNullOrWhiteSpace(key)) {
                MessageBox.Show("Uzupełnij wszystkie wymagane pola.");
                return;
            }

            if (operation == "Dodaj") {
                demo.AddToType(type, key, (type == "map" || type == "dictionary") ? value : null);
            } else if (operation == "Usuń") {
                demo.RemoveFromType(type, key);
            }

            OutputBox.Text = demo.GetAllContents();
        }
    }
}