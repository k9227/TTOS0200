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

namespace Tehtava1
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            string input = "";
            if ((bool)checkBox.IsChecked)
            {
                input += " " + checkBox.Content.ToString();
            }
            if ((bool)checkBox1.IsChecked)
            {
                input += " " + checkBox1.Content.ToString();
            }
            if ((bool)checkBox2.IsChecked)
            {
                input += " " + checkBox2.Content.ToString();
            }
            if ((bool)checkBox3.IsChecked)
            {
                input += " " + checkBox3.Content.ToString();
            }
            if ((bool)checkBox4.IsChecked)
            {
                input += " " + checkBox4.Content.ToString();
            }

            textBlock.Text = input;
        }
    }
}
