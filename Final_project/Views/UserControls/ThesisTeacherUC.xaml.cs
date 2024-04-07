using System.Windows.Controls;
using Final_project.Views.Dialog;
using Final_project.Ado_NET.DAO.UserControls;
using MaterialDesignThemes.Wpf;
using static MaterialDesignThemes.Wpf.Theme;
using System.Data;
using System.Windows;

namespace Final_project.Views.UserControls
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class ThesisTeacherUC : UserControl
    {
        BL_ThesisTeacherUC bL_ThesisTeacherUC = new BL_ThesisTeacherUC();
        private string err=string.Empty;

        public ThesisTeacherUC()
        {
            InitializeComponent();
            dgrThesis.ItemsSource = bL_ThesisTeacherUC.getThesis().DefaultView;
        }


        private void AddThesisbtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            AddThesisDialog addThesisDialog = new AddThesisDialog();
            addThesisDialog.ShowDialog();
            initialcontrol();
        }

        private void UpdateThesisbtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (dgrThesis.SelectedItem != null)
            {
                var selectedItem = dgrThesis.SelectedItem as DataRowView;
                UpdateThesisDialog updateThesisDialog = new UpdateThesisDialog();
                updateThesisDialog.UCinputthesis.txtThesisID.Text = selectedItem.Row.ItemArray[0].ToString();//get information
                updateThesisDialog.UCinputthesis.txtThesisname.Text = selectedItem.Row.ItemArray[1].ToString();//get information
                updateThesisDialog.UCinputthesis.txtteacher.Text = selectedItem.Row.ItemArray[2].ToString();//get information
                updateThesisDialog.UCinputthesis.cbbCategory.Text = selectedItem.Row.ItemArray[3].ToString();//get information
                updateThesisDialog.UCinputthesis.txtTechnology.Text = selectedItem.Row.ItemArray[4].ToString();//get information
                updateThesisDialog.UCinputthesis.txtNumberofpartner.Text = selectedItem.Row.ItemArray[5].ToString();//get information
                updateThesisDialog.UCinputthesis.txtRequire.Text = selectedItem.Row.ItemArray[6].ToString();//get information
                updateThesisDialog.UCinputthesis.txtFunction.Text = selectedItem.Row.ItemArray[6].ToString();//get information
                updateThesisDialog.ShowDialog();
                initialcontrol();
            } else { MessageBox.Show("select thesis want to change"); }
        }

        private void DeleteThesisbtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (dgrThesis.SelectedItem != null)
            {
                var selectedItem = dgrThesis.SelectedItem as DataRowView;
                //get information
                if (!bL_ThesisTeacherUC.deleteThesis(selectedItem.Row.ItemArray[0].ToString(),ref err))
                {
                    MessageBox.Show(err);
                }
                else
                {
                    MessageBox.Show("delete completed");
                }
                
                initialcontrol();
            }
            else { MessageBox.Show("select thesis want to delete"); }
            initialcontrol();
        }

        private void btnsearch_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (txtsearchCategory.Text != "")
            {

            }
        }
        private void initialcontrol()
        {
            dgrThesis.ItemsSource = bL_ThesisTeacherUC.getThesis().DefaultView;
        }
    }
}
