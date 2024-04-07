using Final_project.DBConnection;
using Final_project.Views.UserControls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;

namespace Final_project.Ado_NET.DAO.Dialog
{
    public class BL_CheckThesisDialog
    {

        string tablename = "Thesis_register";
        string tableThesis = "Thesis";
        string tablestudent = "Student";
        string primarycl = "username";
        string password_ = "password_";
        string role = "role_";
        DBconnection db = new DBconnection();
        private string error = string.Empty;

        public BL_CheckThesisDialog()
        {

        }
        public DataTable getRegister()
        {

            DataTable dt = new DataTable();
            dt.Clear();
            DataSet ds = db.ExecuteQueryDataSet("select "+tablename+".thesis_id,"+tableThesis+ ".topic," + tableThesis+ ".category,"+ tablestudent+ ".name " + "from "  + tablename+" join "+tableThesis +" on "+tablename+ ".thesis_id ="+tableThesis+ ".thesis_id  join Student on Thesis_register.student_id = Student.student_id ", CommandType.Text);
            dt = ds.Tables[0];
            return dt;

        }
        public bool checkThesis(string thesisid, ref string error)
        {
            string sqlString = "DELETE FROM " + tablename + " WHERE thesis_id = '" + thesisid + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref error);
        }
    }
}
