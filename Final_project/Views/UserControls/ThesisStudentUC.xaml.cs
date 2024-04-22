using Final_project.Ado_NET.DAO.UserControls;
using Final_project.Views.Dialog;
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

namespace Final_project.Views.UserControls
{
    /// <summary>
    /// Interaction logic for ThesisStudentUC.xaml
    /// </summary>
    public partial class ThesisStudentUC : UserControl
    {
        private int pagenumber;
        private int maxpage=5;
        public string Studentid= string.Empty;
        BL_ThesisStudentUC db = new BL_ThesisStudentUC();
        public ThesisStudentUC()
        {
            InitializeComponent();
            //btnprevius.IsEnabled = false;
            //pagenumber = int.Parse(txbPageNumber.Text);
            dgrThesis.ItemsSource = db.getThesis().DefaultView;
        }

        private void btnThesis_Register_Click(object sender, RoutedEventArgs e)
        {
            if (dgrThesis.SelectedItem != null)
            {
                var selectedItem = dgrThesis.SelectedItem as DataRowView;
                InspectGroup GroupShow = new InspectGroup(Studentid, selectedItem.Row.ItemArray[0].ToString());
                GroupShow.txtThesisID.Text = selectedItem.Row.ItemArray[0].ToString();//get information
                GroupShow.txtThesisname.Text = selectedItem.Row.ItemArray[1].ToString();//get information
                GroupShow.txtteacher.Text = selectedItem.Row.ItemArray[2].ToString();//get information
                GroupShow.cbbCategory.Text = selectedItem.Row.ItemArray[3].ToString();//get information
                GroupShow.txtTechnology.Text = selectedItem.Row.ItemArray[4].ToString();//get information
                GroupShow.txtNumberofpartner.Text = selectedItem.Row.ItemArray[5].ToString();//get information
                GroupShow.txtThesisID.IsReadOnly = true;
                GroupShow.txtThesisname.IsReadOnly = true;
                GroupShow.txtteacher.IsReadOnly = true;
                GroupShow.cbbCategory.IsReadOnly = true;
                GroupShow.txtTechnology.IsReadOnly = true;
                GroupShow.txtNumberofpartner.IsReadOnly = true;
                GroupShow.ShowDialog();
            }
            else { MessageBox.Show("select thesis want to change"); }
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
