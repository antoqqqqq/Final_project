using Final_project.Ado_NET.DAO.Dialog;
using System.Data;
using System.Windows;

namespace Final_project.Views.Dialog
{
    /// <summary>
    /// Interaction logic for GroupShow.xaml
    /// </summary>
    public partial class InspectGroup : Window
    {
        string id=string.Empty;
        BL_InspectGroup bl = new BL_InspectGroup();
        public InspectGroup(string studentid, string Thesisid)
        {
            InitializeComponent();
            id = studentid;
            dgrThesis.ItemsSource = bl.getGroupCreated(Thesisid).DefaultView   ;
        }

        private void btnThesis_Register_Click(object sender, RoutedEventArgs e)
        {
            if (dgrThesis.SelectedItem!= null)
            {
                var selectedItem = dgrThesis.SelectedItem as DataRowView;
                Register_Thesis register_Thesis = new Register_Thesis(id);
                register_Thesis.txtThesisID.Text = this.txtThesisID.Text;
                register_Thesis.txtteacher.Text = this.txtteacher.Text;
                register_Thesis.txtThesisname.Text = this.txtThesisname.Text;
                register_Thesis.txtNumberofpartner.Text = this.txtNumberofpartner.Text;
                register_Thesis.txtTechnology.Text = this.txtTechnology.Text;
                register_Thesis.cbbCategory.Text = this.cbbCategory.Text;
                register_Thesis.txtGroupName.Text = selectedItem.Row.ItemArray[0].ToString();
                register_Thesis.txtTechnology.IsReadOnly = true;
                register_Thesis.txtThesisID.IsReadOnly = true;
                register_Thesis.txtThesisname.IsReadOnly = true;
                register_Thesis.txtGroupName.IsReadOnly = true;
                register_Thesis.txtNumberofpartner.IsReadOnly = true;
                register_Thesis.txtteacher.IsReadOnly = true;
                register_Thesis.cbbCategory.IsReadOnly = true;
                register_Thesis.ShowDialog();
            }else { MessageBox.Show("Seclect 1 group to join"); }
        }

        private void btnThesis_CreateGroup_Click(object sender, RoutedEventArgs e)
        {
            Register_Thesis register_Thesis = new Register_Thesis(id);
            register_Thesis.txtThesisID.Text = this.txtThesisID.Text;
            register_Thesis.txtteacher.Text = this.txtteacher.Text;
            register_Thesis.txtThesisname.Text = this.txtThesisname.Text;
            register_Thesis.txtNumberofpartner.Text = this.txtNumberofpartner.Text;
            register_Thesis.txtTechnology.Text = this.txtTechnology.Text;
            register_Thesis.cbbCategory.Text = this.cbbCategory.Text;
            register_Thesis.txtTechnology.IsReadOnly = true;
            register_Thesis.txtThesisID.IsReadOnly = true;
            register_Thesis.txtThesisname.IsReadOnly = true;
            register_Thesis.txtNumberofpartner.IsReadOnly = true;
            register_Thesis.txtteacher.IsReadOnly = true;
            register_Thesis.cbbCategory.IsReadOnly = true;
            register_Thesis.ShowDialog();
        }

        private void Closebtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
