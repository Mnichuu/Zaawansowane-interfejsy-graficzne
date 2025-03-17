using System.ComponentModel;
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
using ZIG01;
namespace ZIG02;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void BUTTONEK_Click(object sender, RoutedEventArgs e)
    {
        try
        {
            int a = int.Parse(TextBox_A.Text);
            int b = int.Parse(TextBox_B.Text);
            int c = int.Parse(TextBox_C.Text);

            Wynik1.Content = ZIG01.Zadanie01.potega(a, b, c).ToString();
        }
        catch (WarningException ex)
        {
            MessageBox.Show(ex.Message, "Ostrzeżenie", MessageBoxButton.OK, MessageBoxImage.Warning);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Wystąpił nieoczekiwany błąd: " + ex.Message, "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
        }

    }
}