using System.Windows;

namespace OwnUserControls
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

        private void LoginView_LoginClicked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Username: {loginView.Username} - Password: {loginView.Password}");
        }
    }
}
