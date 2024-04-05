using Final_project.Ado_NET.DAO.Dialog;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
    /// Interaction logic for AddThesisDialog.xaml
    /// </summary>
    public partial class AddThesisDialog : Window
    {
        BL_AddThesisDialog db= new BL_AddThesisDialog();
        private string error = string.Empty;

        public AddThesisDialog()
        {
            InitializeComponent();
        }

        private void Closebtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Mainwindow_MouseMove(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void btnAddThesis_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                db.addNewRow(InputThesisUC.txtThesisID.Text, InputThesisUC.txtThesisname.Text,
                    InputThesisUC.txtteacher.Text,InputThesisUC.cbbCategory.Text,
                    InputThesisUC.txtTechnology.Text,InputThesisUC.txtNumberofpartner.Text,
                    InputThesisUC.txtRequire.Text,InputThesisUC.txtFunction.Text, ref error);
            }
            catch (SqlException)
            {
                MessageBox.Show(error);
            }
        }
    }
}
