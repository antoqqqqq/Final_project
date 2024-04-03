using Final_project.DBConnection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Final_project.Ado_NET.DAO.Dialog
{
    class BL_AddThesisDialog
    {
        string tablename = "Thesis";
        string primarycl = "username";
        string password_ = "password_";
        string role = "role_";
        DBconnection db;
        public BL_AddThesisDialog()
        {
            db = new DBconnection();
        }
        public bool addNewRow(string ID, string Topic,string Teacher_id, string Category,string Technology,string numbermember,string require,string function, ref string error)
        {
            string sqlString = "INSERT INTO " + tablename +
                " VALUES (" + ID + ", " + Topic +", " + Teacher_id + ", " + Category + ", " + Technology + ", " + numbermember + ", " + require +", " + function + ")";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref error);
        }
    }
}
