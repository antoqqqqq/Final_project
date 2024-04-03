using System.Windows.Controls;
using Final_project.Views.Dialog;
using Final_project.Ado_NET.DAO.UserControls;
using MaterialDesignThemes.Wpf;
using static MaterialDesignThemes.Wpf.Theme;

namespace Final_project.Views.UserControls
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class ThesisTeacherUC : UserControl
    {
        BL_ThesisTeacherUC bL_ThesisTeacherUC = new BL_ThesisTeacherUC();

        public ThesisTeacherUC()
        {
            InitializeComponent();
            dgrThesis.ItemsSource = bL_ThesisTeacherUC.getThesis().DefaultView;
        }


        private void AddThesisbtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            AddThesisDialog addThesisDialog = new AddThesisDialog();
            addThesisDialog.ShowDialog();
        }

        private void UpdateThesisbtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            
            UpdateThesisDialog updateThesisDialog = new UpdateThesisDialog();
            updateThesisDialog.ShowDialog();
        }

        private void DeleteThesisbtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {

        }

        private void btnsearch_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (txtsearchCategory.Text != "")
            {

            }
        }
    }
}
