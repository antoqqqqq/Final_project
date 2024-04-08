using Final_project.DBConnection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using static MaterialDesignThemes.Wpf.Theme;
using static MaterialDesignThemes.Wpf.Theme.ToolBar;

namespace Final_project.Ado_NET.DAO.UserControls
{

    class BL_ThesisTeacherUC
    {
        string tablename = "Thesis";
        string category = "Category";
        string primarycl = "username";
        string password_ = "password_";
        string role = "role_";
        DBconnection db = new DBconnection();
        private string error =string.Empty;

        public BL_ThesisTeacherUC() {
            
        }
        public DataTable getThesis()
        {
            DataTable dt = new DataTable();
            dt.Clear();
            DataSet ds = db.ExecuteQueryDataSet("select * from " + tablename, CommandType.Text);
            dt = ds.Tables[0];
            return dt;
        }        
        public List<string> getCategory()
        {
            List<string> list = db.GetColumn("select * from " + category, "category", CommandType.Text, ref error);
            return list;
        }
        public bool deleteThesis(string thesisid,ref string error)
        {
            string sqlString = "DELETE FROM " + tablename + " WHERE thesis_id = '" + thesisid+"'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref error);
        }
    }
}
