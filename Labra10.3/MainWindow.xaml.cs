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

namespace Tehtava3
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
            int frameWidth;
            int width;
            int height;
            int.TryParse(txbFrameWidth.Text.ToString(), out frameWidth);
            int.TryParse(txbHeight.Text.ToString(), out height);
            int.TryParse(txbWidth.Text.ToString(), out width);
            if (300 <= height && height <= 3000 && 300 <= width && width <= 3000)
            {
                txtWholeArea.Text = (width * height / 10).ToString("0 cm^2");
                txtGlassArea.Text = ((width - frameWidth * 2) * (height - frameWidth * 2) / 10).ToString("0 cm^2");
                txtPerimeter.Text = ((width * 2 + height * 2) / 10).ToString("0 cm");
                visualisedWindow.Width = width / 10;
                visualisedWindow.Height = height / 10;
                visualisedWindow.StrokeThickness = frameWidth / 10;
                txtError.Text = "";
            }
            else
            {
                txtError.Text = "Width & height values must be between 300 and 3000 millimetres !";
            }
        }

        private void txbWidth_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
