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

namespace Resources
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

        private void StaticResourceChangeValue(object sender, RoutedEventArgs e)
        {
            var brush = Resources["defaultBackgroundColor"] as SolidColorBrush;

            // neu in C#7
            //if (brush == null)
            if (brush is null)
                return;

            //brush.Color = Colors.DarkBlue;
            brush.Color = Color.FromRgb(0xC8, 0x89, 0xA0);
            //brush.Color = Color.FromRgb(255, 45, 0);

            // auch neu in C# 7
            var value = 0b0010_0110_0011;
            value = 1_000_000_000;
        }

        private void StaticResourceChangeInstance(object sender, RoutedEventArgs e)
        {
            var brush = Brushes.Cornsilk;
            Resources["defaultBackgroundColor"] = brush;
        }

        private void DynamicResourceOtherType(object sender, RoutedEventArgs e)
        {
            var brush = new RadialGradientBrush(Colors.Wheat, Colors.Red);
            Resources["defaultBackgroundColor"] = brush;
        }
    }
}
