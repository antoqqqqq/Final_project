using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Final_project.ViewModels.Windows
{

    public class MainWindowViewModel :BaseViewModels
    {
        #region
        public ICommand AccountCommand { get; set; }
        public ICommand CheckThesisCommand { get; set; }
        public ICommand LogoutCommand { get; set; }
        public ICommand ShowThesisCommand { get; set;}
        public ICommand QuitCommand { get; set;}

        #endregion
        public MainWindowViewModel() { 
            AccountCommand =new RelayCommand<Window>(ExecuteAccountCommand);
            CheckThesisCommand = new RelayCommand<Window>(ExecuteCheckThesisCommand);
            LogoutCommand =new RelayCommand<Window>(ExecuteLogoutCommand);
            ShowThesisCommand = new RelayCommand<Window>(ExecuteShowThesisCommand);
            QuitCommand = new RelayCommand<Window>(ExecuteQuitCommand);
        }
        private void ExecuteAccountCommand(Window window) {

        }
        private void ExecuteCheckThesisCommand(Window window) {

        }
        private void ExecuteLogoutCommand(Window window) {

        }
        private void ExecuteShowThesisCommand(Window window) {

        }
        private void ExecuteQuitCommand(Window window)
{
    window.Close();
}
    }
}

