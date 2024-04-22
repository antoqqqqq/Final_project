using Final_project.Ado_NET.DAO.Dialog;
using Final_project.Ado_NET.DAO.UserControls;
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

namespace Final_project.Views.Dialog
{
    /// <summary>
    /// Interaction logic for CheckThesisDialog.xaml
    /// </summary>
    public partial class CheckThesisDialog : Window
    {
        BL_CheckThesisDialog db = new BL_CheckThesisDialog();
        string teacher =string.Empty;
        private string error=string.Empty;

        public CheckThesisDialog(string teacherid)
        {
            InitializeComponent();
            dgrThesis.ItemsSource= db.getRegister(teacherid).DefaultView;
            teacher = teacherid;
        }

        private void Closebtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnAddThesis_Click(object sender, RoutedEventArgs e)
        {
            if (dgrThesis.SelectedItem != null)
            {
                var selectedItem = dgrThesis.SelectedItem as DataRowView;
                if(!db.AgreeThesis(selectedItem[0].ToString(), teacher, selectedItem[3].ToString(), selectedItem[4].ToString(), ref error)){
                    MessageBox.Show(error);
                }
            }
            else { MessageBox.Show("Select 1 register to comfirm"); }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (dgrThesis.SelectedItem != null)
                {
                    var selectedItem = dgrThesis.SelectedItem as DataRowView;
                    if (!db.RejectThesis(selectedItem[0].ToString(), teacher, selectedItem[3].ToString(), selectedItem[4].ToString(), ref error))
                    {
                        MessageBox.Show(error);
                    }
                }
                else { error="Select 1 register to reject"; }
            }
            catch (Exception) { MessageBox.Show(error); }
        }
    }
}
