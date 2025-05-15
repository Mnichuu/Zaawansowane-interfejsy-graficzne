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

namespace GameControl {
    /// <summary>
    /// Logika interakcji dla klasy GalaxyMap.xaml
    /// </summary>
    public partial class GalaxyMap : UserControl {
        private PlanetSystem planetarySystem;

        public GalaxyMap() {
            InitializeComponent();
            CreatePlanetarySystem();
        }

        private void CreatePlanetarySystem() {
            planetarySystem = new PlanetSystem("System Planetarny 1");

            // Tworzenie 10 planet
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
        }

        private void PlanetClick(object sender, RoutedEventArgs e) {
            if (sender is FrameworkElement element && element.DataContext is Planet planet) {
                ShowBuildableItems(planet);
            }
        }

        private static void ShowBuildableItems(Planet planet) {
            var buildableItems = planet.Buildings;

            // Wyświetlenie listy budynków w oknie dialogowym
            var message = $"Budynki na {planet.Name}:\n";
            foreach (var building in buildableItems) {
                message += $"- {building.Name} (Poziom: {building.Level})\n";
            }

            MessageBox.Show(message, $"Budynki na {planet.Name}", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
