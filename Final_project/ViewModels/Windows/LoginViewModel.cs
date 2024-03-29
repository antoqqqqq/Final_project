using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Final_project.Views.Windows;

namespace Final_project.ViewModels.Windows
{
    public class LoginViewModel :BaseViewModels
    {
        #region
        public ICommand LoginCommand { get; set; }
        public ICommand QuitCommand { get; set; }
        #endregion
        public LoginViewModel() { 
            LoginCommand = new RelayCommand<Window>(ExecuteLoginCommand);
            QuitCommand = new RelayCommand<Window>(ExecuteQuitCommand);
        }

        private void ExecuteQuitCommand(Window window)
        {
            window.Close();
        }

        private void ExecuteLoginCommand(Window window)
        {
            MainWindow mainWindow = new MainWindow();
            window.ShowDialog();
        }
    }
}
