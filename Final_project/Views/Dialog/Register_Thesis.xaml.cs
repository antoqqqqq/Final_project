using Final_project.Ado_NET.DAO.Dialog;
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
    /// Interaction logic for Register_Thesis.xaml
    /// </summary>
    public partial class Register_Thesis : Window
    {
        string studentID = string.Empty;
        string error = string.Empty;
        BL_RegisterThesis db = new BL_RegisterThesis();
        public Register_Thesis(string id)
        {
            InitializeComponent();
            studentID = id;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            
            if (db.addNewRow(txtThesisID.Text,txtteacher.Text, studentID, txtGroupName.Text,ref error))
            {
                MessageBox.Show("register Thesis success");
                this.Close();
            } else { MessageBox.Show(error); }
        }
        private void initialControl()
        {
            
        }

        private void Window_Scroll(object sender, System.Windows.Controls.Primitives.ScrollEventArgs e)
        {

        }
    }
}
