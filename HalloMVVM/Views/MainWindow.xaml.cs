using System.Windows;

namespace HalloMVVM.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //DataContext = new ViewModels.MainWindowViewModel();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var vm = DataContext as ViewModels.MainWindowViewModel;

            vm.WelcomeText = "Der neue Text aus dem Code Behind!!";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            new MainWindow().Show();
        }
    }
}
