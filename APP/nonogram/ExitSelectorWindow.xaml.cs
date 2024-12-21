using System;
using System.Windows;

namespace nonogram
{
    public partial class ExitSelectorWindow : Window
    {
        public ExitSelectorWindow()
        {
            InitializeComponent();

            Logout.Click += Logout_Click;
            Exit.Click += Exit_Click;

            this.Deactivated += ExitSelectorWindow_Deactivated;
        }

        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            // Megnyitjuk a LoginWindow-t
            LoginWindow loginWindow = new LoginWindow();
            loginWindow.Show();

            // Bezárjuk a MainWindow-t
            foreach (Window window in Application.Current.Windows)
            {
                if (window is MainWindow)
                {
                    window.Close();
                    break;
                }
            }

            this.Close();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();                 // This closes the whole application
        }

        private void ExitSelectorWindow_Deactivated(object sender, EventArgs e)
        {
            this.Close();                                   // If clicked by mistake, clicking outside the window brings back the user to the app
        }
    }
}
