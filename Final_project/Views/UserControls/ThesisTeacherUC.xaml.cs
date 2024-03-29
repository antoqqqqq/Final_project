using System.Windows.Controls;
using Final_project.Views.Dialog;
using MaterialDesignThemes.Wpf;

namespace Final_project.Views.UserControls
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class ThesisTeacherUC : UserControl
    {
        public ThesisTeacherUC()
        {
            InitializeComponent();
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
    }
}
