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
using GalacticTycoon.Buildings;
using GalacticTycoon.Galaxy;
using GalacticTycoon.Player;

namespace GameControl {
    /// <summary>
    /// Logika interakcji dla klasy GalaxyMap.xaml
    /// </summary>
    public partial class GalaxyMap : UserControl {
        private PlanetSystem planetarySystem;
        private Planet selectedPlanet;
        private Player player;

        public GalaxyMap() {
            InitializeComponent();
            CreatePlanetarySystem();
        }

        private void CreatePlanetarySystem() {
            planetarySystem = new PlanetSystem("System Planetarny 1");
            for (int i = 1; i <= 10; i++) {
                var planet = new Planet($"Planeta {i}") {
                    Description = $"Opis Planety {i}",
                    Buildings = new List<Building> {
                new Farm(),
                new Hotel(),
                new GalacticShipyard(),
                new Mine(),
                new SpacePort()
            }
                };
                planetarySystem.AddPlanet(planet);
            }

            // Przypisz planety do przycisków
            PlanetButton1.DataContext = planetarySystem.Planets[0];
            PlanetButton2.DataContext = planetarySystem.Planets[1];
            PlanetButton3.DataContext = planetarySystem.Planets[2];
            PlanetButton4.DataContext = planetarySystem.Planets[3];
            PlanetButton5.DataContext = planetarySystem.Planets[4];
            PlanetButton6.DataContext = planetarySystem.Planets[5];
            PlanetButton7.DataContext = planetarySystem.Planets[6];
            PlanetButton8.DataContext = planetarySystem.Planets[7];
            PlanetButton9.DataContext = planetarySystem.Planets[8];
            PlanetButton10.DataContext = planetarySystem.Planets[9];
        }

        private void PlanetClick(object sender, RoutedEventArgs e) {
            if (sender is FrameworkElement element && element.DataContext is Planet planet) {
                selectedPlanet = planet;
                ShowPlanetDetails(planet);
            }
        }

        private void ShowPlanetDetails(Planet planet) {
            var dialog = new UpgradeBuildingDialog(planet.Name, planet.Buildings);
            dialog.Owner = Window.GetWindow(this);
            if (dialog.ShowDialog() == true && dialog.SelectedBuilding != null) {
                if (dialog.SelectedBuilding.Level == 0) {
                    dialog.SelectedBuilding.Upgrade();
                    MessageBox.Show(
                        $"Zbudowano: {dialog.SelectedBuilding.Name}",
                        "Akcja", MessageBoxButton.OK, MessageBoxImage.Information);
                } else {
                    dialog.SelectedBuilding.Upgrade();
                    MessageBox.Show(
                        $"Rozbudowano: {dialog.SelectedBuilding.Name} do poziomu {dialog.SelectedBuilding.Level}",
                        "Akcja", MessageBoxButton.OK, MessageBoxImage.Information);
                }


            }
        }
    }
}
