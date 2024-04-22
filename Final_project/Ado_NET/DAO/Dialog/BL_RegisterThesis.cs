using Final_project.DBConnection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_project.Ado_NET.DAO.Dialog
{
    public class BL_RegisterThesis
    {
        string tablename = "Thesis_register";
        string tablemember = "student_group";
        string tablestudent = "Student";
        string primarycl = "Thesis_id";
        string seconcol = "teacherid";
        string thirdcol = "studentid";
        DBconnection db;
        public BL_RegisterThesis()
        {
            db = new DBconnection();
        }
        public bool addNewRow(string ID, string Teacher_id,  string studentid,string groupname, ref string error)
        {
            string sqlString = "INSERT INTO " + tablename +
                " VALUES ('" + ID +  "', '" + Teacher_id + "','"+ groupname + "','"+ studentid+"')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref error);
        }
        public DataTable getThesisDuring(string groupname)
        {
            DataTable dt = new DataTable();
            dt.Clear();
            DataSet ds = db.ExecuteQueryDataSet("select " + tablestudent + ".name," + tablemember + ".group_name,"
                + "from " + tablemember +" Where " +tablemember+ "=" +groupname+ " join " + tablestudent + " on " + tablestudent + ".studentid =" + tablemember + ".thesis_id"  , CommandType.Text);
            dt = ds.Tables[0];
            return dt;
        }
    }
}
