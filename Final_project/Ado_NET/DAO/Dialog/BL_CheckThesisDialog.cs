using ControlzEx.Standard;
using Final_project.DBConnection;
using Final_project.Views.UserControls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
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
        string tableIfo = "Thesis_info";
        string tablestudent = "Student";
        string tablenotificate = "Notificate";
        string primarycl = "username";
        string password_ = "password_";
        string role = "role_";
        DBconnection db = new DBconnection();
        private string error = string.Empty;
        DateTime result;
        public BL_CheckThesisDialog()
        {

        }
        public DataTable getRegister(string teacherid)
        {
            DataTable dt = new DataTable();
            dt.Clear();
            DataSet ds = db.ExecuteQueryDataSet("select "+tablename+".thesis_id,"+tableThesis+ ".topic," + tableThesis+ ".category,"+ tablestudent+ ".name, "+ tablestudent+ ".student_id " + "from "  + tablename+" join "
                +tableThesis +" on "+tablename+ ".thesis_id ="+tableThesis+ ".thesis_id  join Student on Thesis_register.student_id = Student.student_id where "+ tablename+".teacher_id='"+ teacherid+"'", CommandType.Text);
            dt = ds.Tables[0];
            return dt;

        }
        public bool AgreeThesis(string thesisid, string teacherid, string studentid, ref string error)
        {
            DateTime date = DateTime.Now;
            string sqlString = 
                "DELETE FROM " + tablename + " WHERE thesis_id = '" + thesisid +"' And student_id='"+studentid+ "'\n" +
                 "INSERT INTO " + tableIfo + "(thesis_id, teacher_id, student_id) VALUES('" + thesisid + "', '" + teacherid + "', '" + studentid + "')\n" +
                 "INSERT INTO " + tablenotificate + " VALUES ('" + studentid + "','" + teacherid + "'," + "TRY_CONVERT(DATETIME, '" +date.ToString()+"', 102)" + ",'Teacher agree your register in" + thesisid + "')";
            return db.QueryCanbeRollback(sqlString,CommandType.Text,ref error);
        }
        public bool RejectThesis(string thesisid, string teacherid, string studentid, ref string error)
        {
            DateTime date = DateTime.Now;
            string sqlString = "DELETE FROM " + tablename + " WHERE thesis_id = '" + thesisid + "'\n" +
                 "INSERT INTO " + tablenotificate + " VALUES ('" + studentid + "','" + teacherid + "'," + "TRY_CONVERT(DATETIME, '" + date.ToString() + "', 102)" + ",'Teacher agree your register in" + thesisid + "')";
            return db.QueryCanbeRollback(sqlString,CommandType.Text,ref error);
        }
    }
}
