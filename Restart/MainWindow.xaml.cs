using System;
using System.Globalization;
using System.Windows;

namespace Restart
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var c = CultureInfo.CurrentCulture;
            if (c.LCID == 1053)
            {
                Question.Content = "Vill du verkligen starta om?";
                RestartButton.Content = "Starta om";
                CancelButton.Content = "Avbryt";
            }
        }

        private void Restart_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("shutdown.exe", "-r -t 0");
            Environment.Exit(0);
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
