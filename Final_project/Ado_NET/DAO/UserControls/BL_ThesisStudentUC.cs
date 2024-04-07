using Final_project.DBConnection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_project.Ado_NET.DAO.UserControls
{
    public class BL_ThesisStudentUC
    {
        string tablename = "Thesis";
        string primarycl = "username";
        string password_ = "password_";
        string role = "role_";
        DBconnection db = new DBconnection();
        private string error = string.Empty;

        public BL_ThesisStudentUC()
        {

        }
        public DataTable getThesis()
        {
            DataTable dt = new DataTable();
            dt.Clear();
            DataSet ds = db.ExecuteQueryDataSet("select * from " + tablename, CommandType.Text);
            dt = ds.Tables[0];
            return dt;
        }

    }
}
