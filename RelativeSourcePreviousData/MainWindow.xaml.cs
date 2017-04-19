using System.Collections.Generic;
using System.Windows;

namespace RelativeSourcePreviousData
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            dataView.ItemsSource = GetData();
        }

        /// <summary>
        /// Simuliert einen Datenbankzugriff.
        /// </summary>
        private IEnumerable<Item> GetData()
        {
            return new List<Item>
            {
                new Item { Value = 70 },
                new Item { Value = 57 },
                new Item { Value = 35 },
                new Item { Value = 10 },
                new Item { Value = 99 },
                new Item { Value = 86 },
                new Item { Value = 36 },
                new Item { Value = 37 },
                new Item { Value = 74 },
                new Item { Value = 47 },
                new Item { Value = 46 },
                new Item { Value = 26 },
                new Item { Value = 98 },
                new Item { Value = 85 },
                new Item { Value = 27 },
                new Item { Value = 62 },
                new Item { Value = 47 },
                new Item { Value = 10 },
                new Item { Value = 00 },
                new Item { Value = 19 }
            };
        }
    }
}
