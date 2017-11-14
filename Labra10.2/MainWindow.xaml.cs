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

namespace Tehtava2
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

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           ListBoxItem li = (ListBoxItem)cmbFromCurrency.SelectedItem;
            string currency = li.Content.ToString();
            if (currency == "USD")
            {
                txtToCurrency.Text = "EUR";
            }
            if(currency == "EUR")
            {
                txtToCurrency.Text = "USD";
            }
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            double rate = 0.8997;
            double number;
            double.TryParse(txbInput.Text.ToString(),out number);            
            double output=0;
            if (txtToCurrency.Text == "USD")
            {
                output=number / rate;
            }
            if (txtToCurrency.Text == "EUR")
            {
                output = number * rate;
            }
            string value = output.ToString("0.00");
            txtOutput.Text = value;
        }        
    }
}
