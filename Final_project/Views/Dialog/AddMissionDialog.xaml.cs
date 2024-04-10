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

namespace Final_project.Views.Dialog
{
    /// <summary>
    /// Interaction logic for AddMissionDialog.xaml
    /// </summary>
    public partial class AddMissionDialog : Window
    {
        public AddMissionDialog(/*string thesisid,string studentid,string teacherid*/)
        {
            InitializeComponent();
            //txtStudentid.Text = studentid;
            //txtteacherid.Text = teacherid;
            //txtThesisID.Text = thesisid;
        }

        private void Closebtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Mainwindow_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        private void btnAddMission_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
