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

namespace WPFdemo2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Auto> autot; //muuttujat on käytettävisää kaikissa luokan metoideissa ja tapahtumankäsittelijöissä
        private const string polku = @"D:\\k9227\\kuveja\\";
        public MainWindow()
        {
            //tänne koodi joka suoritetaan ikkunan avauksen luonnissa
            InitializeComponent();
            NaytaKuva("autotalli.png");
            //pyydetään BL-kerrokselta autot, ja näytetään ne käyttäjälle
            autot = Autotalli.HaeAutot();
        }

        private void btnHaeAutot_Click(object sender, RoutedEventArgs e)
        {    
            dgAutot.ItemsSource = autot;            
        }
        private void NaytaKuva(string url)
        {
            try
            {
                if (string.IsNullOrEmpty(url))
                {
                    url = "puuttuu.png";
                }
                //lisätään kuvatiedostojen vakiopolku
                url = polku + url;
                //kuvan näyttö
                BitmapImage pic = new BitmapImage();
                pic.BeginInit();
                pic.UriSource = new Uri(url);
                pic.EndInit();
                imgAutot.Stretch = Stretch.Fill;
                imgAutot.Source = pic;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);                
            }
        }

        private void dgAutot_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //huom, olemme itse populoineet DataGridin Auto-olioilla, joten kukin DataGridin jäsen/alkio on Auto-olio
            object obj = dgAutot.SelectedItem;
            if(obj != null)
            {
                Auto valittu = (Auto)obj;
                NaytaKuva(valittu.URL);
            }
        }

        private void btnHaeAudit_Click(object sender, RoutedEventArgs e)
        {
            //hakee vain AUdit
            var result = autot.Where(m => m.Merkki.Contains("Audi"));
            dgAutot.ItemsSource = result;
        }
    }
}
