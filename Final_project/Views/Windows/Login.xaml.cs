using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Final_project.Views.Windows;

namespace Final_project
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Border_mouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.ChangedButton ==MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void PackIcon_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void btnlogin_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void btnquit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
