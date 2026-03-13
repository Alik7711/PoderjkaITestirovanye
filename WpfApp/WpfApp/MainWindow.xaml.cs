using System.Windows;

namespace WpfApp
{
    public partial class MainWindow : Window
    {
        private AuthService _authService;

        public MainWindow()
        {
            InitializeComponent();
            _authService = new AuthService();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string username = UsernameTextBox.Text;
            string password = PasswordBox.Password;

            if (_authService.Authenticate(username, password))
            {
                MessageTextBlock.Text = "Успешная авторизация!";
                MessageTextBlock.Foreground = System.Windows.Media.Brushes.Green;
            }
            else
            {
                MessageTextBlock.Text = "Неправильный логин или пароль.";
                MessageTextBlock.Foreground = System.Windows.Media.Brushes.Red;
            }
        }
    }
}