using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows;

namespace nonogram.MVVM.View
{
    public partial class RegistrationWindow : Window
    {
        public RegistrationWindow()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            string lastName = LastNameTextBox.Text;
            string firstName = FirstNameTextBox.Text;
            string email = EmailTextBox.Text;
            string password = PasswordBox.Password;

            if (string.IsNullOrWhiteSpace(lastName) || string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Minden mező kitöltése kötelező!", "Regisztráció", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (!IsValidPassword(password))
            {
                MessageBox.Show("A jelszónak legalább 8 karakter hosszúnak kell lennie, tartalmaznia kell legalább 1 nagybetűt és 1 számot.", "Regisztráció", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (UserExists(email))
            {
                MessageBox.Show("A felhasználó már létezik!", "Regisztráció", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            int tokens = 50;
            string csvLine = $"{lastName},{firstName},{email},{password},{tokens}";

            string filePath = "users.csv";
            if (!File.Exists(filePath))
            {
                File.WriteAllText(filePath, "LastName,FirstName,Email,Password,Tokens\n");
            }
            File.AppendAllText(filePath, csvLine + Environment.NewLine);

            MessageBox.Show("Sikeres regisztráció! 50 tokent kaptál.", "Regisztráció", MessageBoxButton.OK, MessageBoxImage.Information);
            this.Close();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private bool IsValidPassword(string password)
        {
            if (password.Length < 8)
                return false;
            if (!password.Any(char.IsUpper))
                return false;
            if (!password.Any(char.IsDigit))
                return false;
            return true;
        }

        private bool UserExists(string email)
        {
            string filePath = "users.csv";
            if (!File.Exists(filePath))
            {
                return false;
            }

            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines.Skip(1))
            {
                var parts = line.Split(',');
                if (parts.Length >= 3 && parts[2] == email)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
