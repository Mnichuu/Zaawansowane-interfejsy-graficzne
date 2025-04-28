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

namespace GameControl;

/// <summary>
/// Interaction logic for UserControl1.xaml
/// </summary>
public partial class UserControl1 : UserControl {
    private Player _player;
    public UserControl1(Player player) {
        InitializeComponent();
        _player = player;
    }
     private void LoadPlayerInfo() {
        PlayerNameText.Text = $"Gracz: {_player.Name}";
        CreditsText.Text = $"Kredyty: {_player.GalacticCredits}";
        PlanetCountText.Text = $"Przejête planety: {_player.OwnedPlanets.Count}";

        PlanetListBox.Items.Clear();
        foreach (var planet in _player.OwnedPlanets) {
            PlanetListBox.Items.Add(planet.Name);
        }
    }

    private void PlanetListBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
        if (PlanetListBox.SelectedItem is string selectedPlanetName) {
            var selectedPlanet = _player.OwnedPlanets.Find(p => p.Name == selectedPlanetName);
            if (selectedPlanet != null) {
                SelectedPlanetNameText.Text = $"Planeta: {selectedPlanet.Name}";
                BuildingCountText.Text = $"Budynki: {selectedPlanet.Buildings.Count}";
            }
        }
    }

    private void BuildBuildingButton_Click(object sender, RoutedEventArgs e) {
        MessageBox.Show("Budowanie budynku...");
    }

    private void UpgradeBuildingButton_Click(object sender, RoutedEventArgs e) {
        MessageBox.Show("Ulepszanie budynku...");
    }

}

