using System;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using nonogram.MVVM.View;
using nonogram.MVVM.ViewModel;

namespace nonogram
{
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string email = EmailTextBox.Text;
            string password = PasswordBox.Password;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Kérem adja meg a felhasználó nevét és jelszavát.", "Bejelentkezés", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (IsValidUser(email, password, out string fullName, out int tokens))
            {
                MessageBox.Show("Sikeres bejelentkezés!", "Bejelentkezés", MessageBoxButton.OK, MessageBoxImage.Information);
                MainWindow mainWindow = new MainWindow();
                MainViewModel mainViewModel = (MainViewModel)mainWindow.DataContext;
                mainViewModel.UserFullName = fullName;
                mainViewModel.UserTokens = tokens;
                mainWindow.Show();
                this.Close(); // Bezárjuk a LoginWindow-t
            }
            else
            {
                MessageBox.Show("Hibás e-mail vagy jelszó!", "Bejelentkezés", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void ForgotPasswordButton_Click(object sender, RoutedEventArgs e)
        {
            ForgotPasswordWindow forgotPasswordWindow = new ForgotPasswordWindow();
            forgotPasswordWindow.ShowDialog();
        }

        private void OpenRegistrationWindow_Click(object sender, RoutedEventArgs e)
        {
            RegistrationWindow registrationWindow = new RegistrationWindow();
            registrationWindow.ShowDialog();
        }

        private bool IsValidUser(string email, string password, out string fullName, out int tokens)
        {
            fullName = null;
            tokens = 0;
            var lines = File.ReadAllLines("users.csv");
            foreach (var line in lines.Skip(1))
            {
                var parts = line.Split(',');
                if (parts.Length >= 5 && parts[2] == email && parts[3] == password)
                {
                    fullName = $"{parts[0]} {parts[1]}";
                    tokens = int.Parse(parts[4]);
                    return true;
                }
            }
            return false;
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                LoginButton_Click(sender, e);
            }
        }

        private void PasswordBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                LoginButton_Click(sender, e);
            }
        }
    }
}
