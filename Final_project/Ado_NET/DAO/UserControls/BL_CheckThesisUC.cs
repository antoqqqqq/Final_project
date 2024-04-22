using Final_project.DBConnection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_project.Ado_NET.DAO.UserControls
{
    public class BL_CheckThesisUC
    {
        string tablename = "Thesis_info";
        string tableThesis = "Thesis";
        string tablegroup = "groups";

        DBconnection db = new DBconnection();
        private string error = string.Empty;

        public BL_CheckThesisUC()
        {

        }
        public DataTable getThesisDuring( string teacherid)
        {
            DataTable dt = new DataTable();
            dt.Clear();
            DataSet ds = db.ExecuteQueryDataSet("select " + tablename + ".thesis_id," + tableThesis + ".topic," + 
                tableThesis + ".category," + tablename + ".group_name " +
                "from " + tablename + " join " + tableThesis + " on " + tablename + ".thesis_id =" + tableThesis +
                ".thesis_id  " + " where " + tablename + ".teacher_id='" + teacherid + "' ", CommandType.Text);
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
