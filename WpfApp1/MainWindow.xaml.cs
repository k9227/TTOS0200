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

namespace WpfApp1
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string nimi = txtNimi.Text;
            txtKenttä.Text = nimi;
        }

        private void btnSuurenna_Click(object sender, RoutedEventArgs e)
        {
            txtKenttä.FontSize = txtKenttä.FontSize + 1;
        }

        private void cmbVarit_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBoxItem li = (ListBoxItem)cmbVarit.SelectedItem;
            string vari = li.Content.ToString();
            //string vari = cmbVarit.SelectedValue.ToString();
            txtKenttä.Text = vari;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString(vari);
            txtKenttä.Foreground = brush;
        }
    }
}
