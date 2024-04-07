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
        string primarycl = "Thesis_id";
        string seconcol = "teacherid";
        string thirdcol = "studentid";
        DBconnection db;
        public BL_RegisterThesis()
        {
            db = new DBconnection();
        }
        public bool addNewRow(string ID, string Teacher_id,  string studentid, ref string error)
        {
            string sqlString = "INSERT INTO " + tablename +
                " VALUES ('" + ID +  "', '" + Teacher_id + "','"+ studentid+"')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref error);
        }
    }
}
