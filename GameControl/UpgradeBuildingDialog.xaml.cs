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
using System.Windows.Shapes;
using GalacticTycoon.Buildings;

namespace GameControl {
    /// <summary>
    /// Logika interakcji dla klasy UpgradeBuildingDialog.xaml
    /// </summary>
    public partial class UpgradeBuildingDialog : Window {
        public Building SelectedBuilding { get; private set; }

        public UpgradeBuildingDialog(string planetName, List<Building> buildings) {
            InitializeComponent();
            PlanetNameText.Text = $"Planeta: {planetName}";
            BuildingsList.ItemsSource = buildings;
        }

        private void UpgradeButton_Click(object sender, RoutedEventArgs e) {
            if (sender is Button btn && btn.DataContext is Building building) {
                SelectedBuilding = building;
                DialogResult = true;
                Close();
            }
        }
    }
}
