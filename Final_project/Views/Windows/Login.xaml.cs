using System.Windows;
using System.Windows.Input;
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
        int Role = 2;
        string id = string.Empty;
        private void btnlogin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtUsername.Text) && !string.IsNullOrWhiteSpace(txtPassword.Password))
                {
                    if (!string.IsNullOrEmpty(db.CheckLogin(txtUsername.Text, txtPassword.Password, ref err)))
                    {
                        Role = int.Parse(db.CheckLogin(txtUsername.Text, txtPassword.Password, ref err));
                        id=db.getid(txtUsername.Text,Role,ref err);
                    }
                    else
                    {
                        err = "username and login error";
                        MessageBox.Show(err);
                    }

                    if (Role == 0)
                    {
                        Views.Windows.MainWindow mainWindow = new MainWindow(txtUsername.Text, Role.ToString());
                        mainWindow.AccountInfomation.Visibility = Visibility.Hidden;
                        mainWindow.CheckThesisUC.Visibility = Visibility.Hidden;
                        mainWindow.CheckDuringThesisUC.Visibility = Visibility.Hidden;
                        mainWindow.ThesisStudentUC.Visibility = Visibility.Hidden;
                        mainWindow.ThesisTeacherUC.Visibility = Visibility.Visible;
                        this.Hide();
                        mainWindow.ShowDialog();
                        this.Show();
                        setdefauld();
                    }
                    else if (Role == 1)
                    {
                        MainWindow mainWindow = new MainWindow(txtUsername.Text, Role.ToString());
                        mainWindow.AccountInfomation.Visibility = Visibility.Hidden;
                        mainWindow.CheckThesisUC.Visibility = Visibility.Hidden;
                        mainWindow.CheckDuringThesisUC.Visibility = Visibility.Hidden;
                        mainWindow.ThesisStudentUC.Visibility = Visibility.Visible;
                        mainWindow.ThesisTeacherUC.Visibility = Visibility.Hidden;
                        this.Hide();
                        mainWindow.ShowDialog();
                        this.Show();
                        setdefauld();
                    }
                }
                else { err = "enter full username and login";
                    MessageBox.Show(err);
                }
            } catch { MessageBox.Show(err); }


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
        private void setdefauld()
        {
            this.txtUsername.Text = "";
            this.txtPassword.Password = "";
            Role = 2;
            this.id =string.Empty;
        }
    }
}
