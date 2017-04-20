using System.Windows;
using System.Windows.Controls;

namespace OwnUserControls
{
    /// <summary>
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView : UserControl
    {
        public LoginView()
        {
            InitializeComponent();
        }

        public string Username
        {
            get { return UsernameTextBox.Text; }
            set { UsernameTextBox.Text = value; }
        }

        public string Password
        {
            get { return PasswordPasswordBox.Password; }
            set { PasswordPasswordBox.Password = value; }
        }

        public event RoutedEventHandler LoginClicked
        {
            add { LoginButton.Click += value; }
            remove { LoginButton.Click -= value; }
        }
    }
}
