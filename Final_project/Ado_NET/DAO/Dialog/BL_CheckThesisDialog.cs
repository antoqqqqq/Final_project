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
        string tablegroups = "groups";
        string tablegroupstudent = "student_group";
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
            DataSet ds = db.ExecuteQueryDataSet("select "+tablename+".thesis_id,"+tableThesis+ ".topic," + tableThesis
                + ".category,"+ tablename + ".student,"+ tablename + ".group_id " + "from "  + tablename+" join "
                +tableThesis +" on "+tablename+ ".thesis_id ="+tableThesis+ ".thesis_id  "+" where " + tablename+".teacher_id='"+ teacherid+"'", CommandType.Text);
            dt = ds.Tables[0];
            return dt;
        }
        public bool AgreeThesis(string thesisid, string teacherid, string studentid,string groupname, ref string error)
        {

            try
            {   if (db.QueryCheckexist("SELECT COUNT(*) FROM " + tablegroups + " WHERE group_name='" + groupname + "'", CommandType.Text, ref error) != 0)
                {
                    string date = DateTime.Now.ToString();
                    string sqlString = "DELETE FROM " + tablename + " WHERE thesis_id = '" + thesisid + "' And group_id='" + groupname+ "' And student='" + studentid + "'\n" +
                         "INSERT INTO " + tablegroupstudent + "( student_id, group_name) VALUES('" + studentid + "', '"+ groupname + "')\n" +
                         "INSERT INTO " + tableIfo + "(thesis_id, teacher_id, group_name) VALUES('" + thesisid + "', '" + teacherid + "', '" + groupname + "')\n" +
                         "INSERT INTO " + tablenotificate + " VALUES ('" + studentid + "','" + teacherid + "'," + "TRY_CONVERT(DATETIME, '" + date.ToString() + "', 103)" +
                         ",'Teacher agree your register in" + thesisid + " at group" + groupname + "')";
                    return db.QueryCanbeRollback(sqlString, CommandType.Text, ref error);
                } else  {
                    int a = int.Parse(db.Getparameter("select Number_member from Thesis Where thesis_id='" + thesisid + "'", "Number_member", CommandType.Text, ref error));
                    string date = DateTime.Now.ToString();
                    string sqlString = "DELETE FROM " + tablename + " WHERE thesis_id = '" + thesisid + "' And group_id='" + groupname + "' And student='" + studentid + "'\n" +
                         "INSERT INTO " + tablegroups + " VALUES('" + groupname + "', '" + a + "','"+thesisid+"')\n" +
                         "INSERT INTO " + tablegroupstudent + "( student_id, group_name) VALUES('" + studentid + "', '" + groupname + "')\n" +
                         "INSERT INTO " + tableIfo + "(thesis_id, teacher_id, group_name) VALUES('" + thesisid + "', '" + teacherid + "', '" + groupname + "')\n" +
                         "INSERT INTO " + tablenotificate + " VALUES ('" + studentid + "','" + teacherid + "'," + "TRY_CONVERT(DATETIME, '" + date.ToString() + "', 103)" +
                         ",'Teacher agree your register in" + thesisid + " at group" + groupname + "')";
                    return db.QueryCanbeRollback(sqlString, CommandType.Text, ref error);
                }
            } catch (Exception ex) { error = ex.ToString(); }
            return false;
        }
        public bool RejectThesis(string thesisid, string teacherid, string studentid,string groupname, ref string error)
        {
            DateTime date = DateTime.Now;
            string sqlString = "DELETE FROM " + tablename + " WHERE thesis_id = '" + thesisid+"' And student_id='" + studentid + "' And group_id='" + groupname+ "'\n" +
                 "INSERT INTO " + tablenotificate + " VALUES ('" + studentid + "','" + teacherid + "'," + "TRY_CONVERT(DATETIME, '" + date.ToString() + "', 103)" + 
                 ",'Teacher Reject your register in " + thesisid + " at group "+ groupname + "')";
            return db.QueryCanbeRollback(sqlString,CommandType.Text,ref error);
        }
    }
}
