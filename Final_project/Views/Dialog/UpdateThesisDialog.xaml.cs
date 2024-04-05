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
    /// Interaction logic for UpdateThesisDialog.xaml
    /// </summary>
    public partial class UpdateThesisDialog : Window
    {
        BL_UpdateThesisDialog db=new BL_UpdateThesisDialog();
        private string err=string.Empty;

        public UpdateThesisDialog()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnUpdateThesis_Click(object sender, RoutedEventArgs e)
        {
            db.EditThesis(UCinputthesis.txtThesisID.Text,UCinputthesis.txtThesisname.Text,
                UCinputthesis.txtteacher.Text,UCinputthesis.cbbCategory.Text,
                UCinputthesis.txtTechnology.Text,UCinputthesis.txtNumberofpartner.Text,
                UCinputthesis.txtRequire.Text,UCinputthesis.txtFunction.Text, ref err);
        }
    }
}
