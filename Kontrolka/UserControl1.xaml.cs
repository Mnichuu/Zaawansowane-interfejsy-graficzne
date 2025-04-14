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
using System.Collections.Generic;
using GalacticTycoon.Galaxy;
using GalacticTycoon.Player;

namespace Kontrolka;

public partial class UserControl1 : UserControl
{
    private Player _player;
    public UserControl1(Player player)
    {
        InitializeComponent();
        _player = player;
    }

    private void Button_Click(object sender, RoutedEventArgs e) {
        PlanetListBox.Items.Clear();

        foreach (var planet in _player.OwnedPlanets) {
            PlanetListBox.Items.Add(planet.Name);
        }
    }
}

