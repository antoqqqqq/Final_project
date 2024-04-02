using Final_project.ViewModels.Windows;
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
using System.Windows.Shapes;

namespace Final_project.Views.Windows
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int role;
        public MainWindow()
        {
            InitializeComponent();
        }


        private void Mainwindow_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        private void btnlogout_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnaccountcontrol_Click(object sender, RoutedEventArgs e)
        {
            AccountInfomation.Visibility = Visibility.Visible;
            CheckThesisUC.Visibility = Visibility.Hidden;
            CheckDuringThesisUC.Visibility = Visibility.Hidden;
            ThesisStudentUC.Visibility = Visibility.Hidden;
            ThesisTeacherUC.Visibility = Visibility.Hidden;
        }

        private void btnThesiscontrol_Click(object sender, RoutedEventArgs e)
        {
            if(role== 0) {
                AccountInfomation.Visibility = Visibility.Hidden;
                CheckThesisUC.Visibility = Visibility.Visible;
                CheckDuringThesisUC.Visibility = Visibility.Hidden;
                ThesisStudentUC.Visibility = Visibility.Hidden;
                ThesisTeacherUC.Visibility = Visibility.Hidden;
            } else
            {
                AccountInfomation.Visibility = Visibility.Hidden;
                CheckThesisUC.Visibility = Visibility.Hidden;
                CheckDuringThesisUC.Visibility = Visibility.Visible;
                ThesisStudentUC.Visibility = Visibility.Hidden;
                ThesisTeacherUC.Visibility = Visibility.Hidden;
            }

        }

        private void btnThesis_Click(object sender, RoutedEventArgs e)
        {

            if (role == 0)
            {
                AccountInfomation.Visibility = Visibility.Hidden;
                CheckThesisUC.Visibility = Visibility.Hidden;
                CheckDuringThesisUC.Visibility = Visibility.Hidden;
                ThesisStudentUC.Visibility = Visibility.Hidden;
                ThesisTeacherUC.Visibility = Visibility.Visible;
            }
            else
            {
                AccountInfomation.Visibility = Visibility.Hidden;
                CheckThesisUC.Visibility = Visibility.Hidden;
                CheckDuringThesisUC.Visibility = Visibility.Hidden;
                ThesisStudentUC.Visibility = Visibility.Visible;
                ThesisTeacherUC.Visibility = Visibility.Hidden;
            }
        }
        public void initialControl()
        {

        }

        private void ThesisTeacherUC_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
