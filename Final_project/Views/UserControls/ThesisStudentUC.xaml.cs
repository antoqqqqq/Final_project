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
    /// Interaction logic for ThesisStudentUC.xaml
    /// </summary>
    public partial class ThesisStudentUC : UserControl
    {
        private int pagenumber;
        private int maxpage=5;

        public ThesisStudentUC()
        {
            InitializeComponent();
            //btnprevius.IsEnabled = false;
            //pagenumber = int.Parse(txbPageNumber.Text);
        }

        //private void btnforward_Click(object sender, RoutedEventArgs e)
        //{
        //    if (pagenumber >= 1 && pagenumber<maxpage-1)
        //    {
        //        btnprevius.IsEnabled = true;
        //        pagenumber++;
        //        txbPageNumber.Text = pagenumber.ToString();
        //    }else if (pagenumber == maxpage-1)
        //    {
        //        btnforward.IsEnabled = false;
        //        pagenumber++;
        //        txbPageNumber.Text = pagenumber.ToString();
        //    }
        //}

        //private void btnprevius_Click(object sender, RoutedEventArgs e)
        //{
        //    if (pagenumber > 2 )
        //    {
        //        btnforward.IsEnabled = true;
        //        pagenumber--;
        //        txbPageNumber.Text = pagenumber.ToString();
        //    }
        //    else if (pagenumber == 2)
        //    {
        //        btnprevius.IsEnabled = false;
        //        pagenumber--;
        //        txbPageNumber.Text = pagenumber.ToString();
        //    }
        //}
        //private void Thesis1_Loaded(object sender, RoutedEventArgs e)
        //{

        //}
    }
}
