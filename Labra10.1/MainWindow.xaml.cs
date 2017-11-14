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

namespace Labra10
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();  
        }
        private void btnTrucks_Click(object sender, RoutedEventArgs e)
        {
            int trucks = int.Parse(txbTruck.Text);
            trucks++;
            txbTruck.Text = trucks.ToString();
        }

        private void btnCars_Click(object sender, RoutedEventArgs e)
        {
            int cars = int.Parse(txbCars.Text);
            cars++;
            txbCars.Text = cars.ToString();
        }
    }
}
