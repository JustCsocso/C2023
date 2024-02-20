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
        bool betoltott=false;
        public MainWindow()
        {
            InitializeComponent();

            this.betoltott = true;
        }

        double[] ertekek = new double[4] { 1, 1, 1, 1 };
        private void slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if(betoltott)
            {
                ertekek[0] = slider.Value;

                image.Opacity = (1 - ertekek[0]) * ertekek[1];
                image1.Opacity = ertekek[0] * ertekek[3];
            }
            
        }

        private void slider1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if(betoltott)
            {
                ertekek[1] = slider1.Value;
                image1.Opacity = (1 - ertekek[0]) * ertekek[1];
                image1_Copy.Opacity = (1 - ertekek[1]) * ertekek[2];
            }
            
        }

        private void slider_Copy_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (betoltott)
            {
                ertekek[2] = slider_Copy.Value;
                image1_Copy.Opacity = (1 - ertekek[1]) * ertekek[2];
                image_Copy.Opacity = (1 - ertekek[2]) * ertekek[3];
            }

        }

        private void slider1_Copy_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (betoltott)
            {
                ertekek[3] = slider1_Copy.Value;
                ertekek[3]=((Slider)sender).Value;

                image_Copy.Opacity = (1 - ertekek[2]) * ertekek[3];
                image.Opacity = (1 - ertekek[3]) * ertekek[0];
            }

        }
    }
    
}
