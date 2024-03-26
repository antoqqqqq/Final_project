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
using Final_project.ViewModels.Windows;
using Final_project.Views.Windows;

namespace Final_project
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public LoginViewModel ViewModel { get; set; }
        public Login()
        {
            InitializeComponent();
            this.DataContext = ViewModel = new LoginViewModel();
        }

    }
}
