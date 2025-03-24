using System.ComponentModel;
using System.Windows;
namespace ZIG02;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window {
    public MainWindow() {
        InitializeComponent();
    }

    private void BUTTONEK_Click(object sender, RoutedEventArgs e) {
        try {
            int a = int.Parse(TextBox_A.Text);
            int b = int.Parse(TextBox_B.Text);
            int c = int.Parse(TextBox_C.Text);

            Wynik.Content = ZIG01.Zadanie01.potega(a, b, c).ToString();
        } catch (WarningException ex) {
            MessageBox.Show(ex.Message, "Ostrzeżenie", MessageBoxButton.OK, MessageBoxImage.Warning);
        } catch (Exception ex) {
            MessageBox.Show("Wystąpił nieoczekiwany błąd: " + ex.Message, "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
        }

    }

    private void BUTTONEK1_Click(object sender, RoutedEventArgs e) {
        try {
            double r = double.Parse(TextBox_poleKola.Text);

            Wynik1.Content = ZIG01.Zadanie01.poleKola(r).ToString();
        } catch (Exception ex) {
            MessageBox.Show("Wystąpił nieoczekiwany błąd: " + ex.Message, "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
        }

    }
    private void BUTTONEK2_Click(object sender, RoutedEventArgs e) {
        try {
            string[] input = TextBox_Tablica.Text.Split(',');
            int[] tablica = Array.ConvertAll(input, int.Parse);

            int a = int.Parse(TextBox_A2.Text);

            var wynik = ZIG01.Zadanie01.zapiszWTablicy(tablica, a);
            Wynik2.Content = string.Join(", ", wynik);
        } catch (Exception ex) {
            MessageBox.Show("Wystąpił nieoczekiwany błąd: " + ex.Message, "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }

    private void BUTTONEK3_Click(object sender, RoutedEventArgs e) {
        try {
            int liczba = int.Parse(TextBox_sumaCyfr.Text);

            Wynik3.Content = ZIG01.Zadanie01.sumaCyfr(liczba);
        } catch (Exception ex) {
            MessageBox.Show("Wystąpił nieoczekiwany błąd: " + ex.Message, "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }

    private void BUTTONEK4_Click(object sender, RoutedEventArgs e) {
        try {
            string[] input = TextBox_Tablica.Text.Split(',');
            int[] tablica = Array.ConvertAll(input, int.Parse);

            int index1 = int.Parse(TextBox_index1.Text);
            int index2 = int.Parse(TextBox_index2.Text);
            int warunek = int.Parse(TextBox_warunek.Text);

            var wynik = ZIG01.Zadanie01.zamienElementy(tablica, index1, index2, warunek);
            Wynik4.Content = string.Join(", ", wynik);
        } catch (WarningException ex) {
            MessageBox.Show(ex.Message, "Ostrzeżenie", MessageBoxButton.OK, MessageBoxImage.Warning);
        } catch (Exception ex) {
            MessageBox.Show("Wystąpił nieoczekiwany błąd: " + ex.Message, "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }

}