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
        public CheckThesisUC()
        {
            InitializeComponent();
        }

        private void btnCheckRegisterThesis_Click(object sender, RoutedEventArgs e)
        {
            CheckThesisDialog checkThesisDialog = new CheckThesisDialog();
            checkThesisDialog.ShowDialog();
        }
    }
}
