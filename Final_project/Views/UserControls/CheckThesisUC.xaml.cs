using Final_project.Ado_NET.DAO.UserControls;
using Final_project.Views.Dialog;
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

namespace Final_project.Views.UserControls
{
    /// <summary>
    /// Interaction logic for CheckThesisUC.xaml
    /// </summary>
    public partial class CheckThesisUC : UserControl
    {
        public string teacherid = string.Empty;
        string error =string.Empty;
        BL_CheckThesisUC db = new BL_CheckThesisUC(); 
        BL_ThesisTeacherUC bL_ThesisTeacherUC = new BL_ThesisTeacherUC();
        public CheckThesisUC()
        {
            InitializeComponent();
            foreach (var item in bL_ThesisTeacherUC.getCategory())
            {
                cbbcategory.Items.Add(item);
            }
        }

        private void btnCheckRegisterThesis_Click(object sender, RoutedEventArgs e)
        {
            CheckThesisDialog checkThesisDialog = new CheckThesisDialog(teacherid);
            checkThesisDialog.ShowDialog();
            dgrThesisinfo.ItemsSource = db.getThesisDuring(teacherid).DefaultView;
        }

        private void btnCreateTaskThesis_Click(object sender, RoutedEventArgs e)
        {
            AddMissionDialog addMissionDialog = new AddMissionDialog();
            addMissionDialog.ShowDialog();
        }

        private void btnCheckMeetingThesis_Click(object sender, RoutedEventArgs e)
        {

        }

        private void UserControl_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            dgrThesisinfo.ItemsSource = db.getThesisDuring(teacherid).DefaultView;
        }
    }
}
