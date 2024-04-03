using System;
using System.Collections.Generic;
using System.Data;
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
using Final_project.Views.UserControls;
using Final_project.DAO.Windows;
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
        BL_Login db = new BL_Login();
        string err =string.Empty;
        int Role;
        string username = string.Empty;
        private void btnlogin_Click(object sender, RoutedEventArgs e)
        {
<<<<<<< HEAD
            try
=======
            this.Hide();
            MainWindow mainWindow = new MainWindow();
            mainWindow.role = 1;
            if (mainWindow.role == 0)
>>>>>>> e1c60e7bc1db901804d87489331aa0e4cf8ab45a
            {
                Role =int.Parse(db.CheckLogin(txtUsername.Text, txtPassword.Password, ref err));
            } catch (Exception ex) { err = ex.Message; }
            if (Role==0)
            {
                this.Hide();
                Views.Windows.MainWindow mainWindow = new Views.Windows.MainWindow();
                mainWindow.role = Role;
                    mainWindow.AccountInfomation.Visibility = Visibility.Hidden;
                    mainWindow.CheckThesisUC.Visibility = Visibility.Hidden;
                    mainWindow.CheckDuringThesisUC.Visibility = Visibility.Hidden;
                    mainWindow.ThesisStudentUC.Visibility = Visibility.Hidden;
                    mainWindow.ThesisTeacherUC.Visibility = Visibility.Visible;
                mainWindow.username=txtUsername.Text;

                mainWindow.ShowDialog();
                this.Show();
                this.txtUsername.Text = "";
                this.txtPassword.Password = "";
            }
            else if(Role == 1)
            {
                this.Hide();
                Views.Windows.MainWindow mainWindow = new Views.Windows.MainWindow();
                mainWindow.role = 1;
                mainWindow.AccountInfomation.Visibility = Visibility.Hidden;
                mainWindow.CheckThesisUC.Visibility = Visibility.Hidden;
                mainWindow.CheckDuringThesisUC.Visibility = Visibility.Hidden;
                mainWindow.ThesisStudentUC.Visibility = Visibility.Visible;
                mainWindow.ThesisTeacherUC.Visibility = Visibility.Hidden;
                mainWindow.ShowDialog();
                this.Show();
                this.txtUsername.Text = "";
                this.txtPassword.Password = "";
                mainWindow.username = txtUsername.Text;
            }
            else { MessageBox.Show(err); }

        }

        private void btnquit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void LoginWindow_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }
    }
}
