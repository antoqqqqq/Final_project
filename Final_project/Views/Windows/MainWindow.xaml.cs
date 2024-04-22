using Final_project.Ado_NET.DAO.UserControls;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;

namespace Final_project.Views.Windows
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int role;
        string id = string.Empty;
        BL_AccountInformation db = new BL_AccountInformation();
        List<string> info = new List<string>();
        string err=string.Empty;
        public MainWindow(string Username,string role)
        {
            InitializeComponent();
            try
            {
                this.id = db.getid(Username, int.Parse(role), ref err);
                this.role = int.Parse(role);
                if (int.Parse(role)==0)
                {
                    ThesisTeacherUC.teacherid = this.id;
                }else if (int.Parse(role)==1)
                {
                    ThesisStudentUC.Studentid = this.id;
                }
                initialControl(this.role, this.id);
            } catch (Exception) { MessageBox.Show(err); }

        }


        private void Mainwindow_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        private void btnlogout_Click(object sender, RoutedEventArgs e)
        {
            role = 2;
            id = string.Empty;
            Close();
        }

        private void btnaccountcontrol_Click(object sender, RoutedEventArgs e)
        {
            if (role ==0)
            {
                AccountInfomation.Visibility = Visibility.Visible;
                CheckThesisUC.Visibility = Visibility.Hidden;
                ThesisTeacherUC.Visibility = Visibility.Hidden;
            }else  if(role == 1)
            {
                AccountInfomation.Visibility = Visibility.Visible;
                CheckDuringThesisUC.Visibility = Visibility.Hidden;
                ThesisStudentUC.Visibility = Visibility.Hidden;
            }        

            
            initialControl(this.role, this.id);
        }

        private void btnThesiscontrol_Click(object sender, RoutedEventArgs e)
        {
            if(role== 0) {
                AccountInfomation.Visibility = Visibility.Hidden;
                CheckThesisUC.Visibility = Visibility.Visible;
                ThesisTeacherUC.Visibility = Visibility.Hidden;
            } else
            {
                AccountInfomation.Visibility = Visibility.Hidden;
                CheckDuringThesisUC.Visibility = Visibility.Visible;
                ThesisStudentUC.Visibility = Visibility.Hidden;
            }

        }

        private void btnThesis_Click(object sender, RoutedEventArgs e)
        {

            if (role == 0)
            {
                AccountInfomation.Visibility = Visibility.Hidden;
                CheckThesisUC.Visibility = Visibility.Hidden;
                ThesisTeacherUC.Visibility = Visibility.Visible;
            }
            else
            {
                AccountInfomation.Visibility = Visibility.Hidden;
                CheckDuringThesisUC.Visibility = Visibility.Hidden;
                ThesisStudentUC.Visibility = Visibility.Visible;
            }
        }
        public void initialControl(int role,string id)
        {
            try
            {
                info = db.GetAccouninformation(role, id, ref err);
            } catch  (Exception)  { MessageBox.Show(err); }
            if (role == 1) {
                ThesisStudentUC.Studentid = info[0];
            } else if(role ==0 )
            {
                CheckThesisUC.teacherid = info[0];
            }
            if(role == 0) {
                CheckThesisUC.teacherid = info[0];
                ThesisTeacherUC.teacherid = info[0];
            }
            AccountInfomation.txtID.Text = info[0];
            AccountInfomation.txtname.Text = info[1];
            AccountInfomation.txtemail.Text = info[2];            
            txbHello.Text = "Hello " + info[1];
        }


    }
}
