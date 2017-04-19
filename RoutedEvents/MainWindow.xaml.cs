using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace RoutedEvents
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly ObservableCollection<Item> _items = new ObservableCollection<Item>();

        public MainWindow()
        {
            InitializeComponent();
            EventsDataGrid.ItemsSource = _items;
        }

        private void ClearButton_Clicked(object sender, RoutedEventArgs e)
        {
            _items.Clear();
        }

        private void RedBorder_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            var border = sender as Border;
            _items.Add(new Item { Eventname = "PreviewMouseDown", AuslösendesElement = border?.Name });
        }

        private void RedBorder_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var border = sender as Border;
            _items.Add(new Item { Eventname = "MouseDown", AuslösendesElement = border?.Name });
        }

        private void StackPanel_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            var stackPanel = sender as StackPanel;
            _items.Add(new Item { Eventname = "PreviewMouseDown", AuslösendesElement = stackPanel?.Name });
        }

        private void StackPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var stackPanel = sender as StackPanel;
            _items.Add(new Item { Eventname = "MouseDown", AuslösendesElement = stackPanel?.Name });
        }

        private void GreenBorder_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            var border = sender as Border;
            _items.Add(new Item { Eventname = "PreviewMouseDown", AuslösendesElement = border?.Name });
        }

        private void GreenBorder_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var border = sender as Border;
            _items.Add(new Item { Eventname = "MouseDown", AuslösendesElement = border?.Name });
        }

        private void Grid_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            var grid = sender as Grid;
            _items.Add(new Item { Eventname = "PreviewMouseDown", AuslösendesElement = grid?.Name });
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var grid = sender as Grid;
            _items.Add(new Item { Eventname = "MouseDown", AuslösendesElement = grid?.Name });
        }

        private void BlueBorder_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            e.Handled = true;

            var border = sender as Border;
            _items.Add(new Item { Eventname = "PreviewMouseDown", AuslösendesElement = border?.Name });
        }
    }
}
