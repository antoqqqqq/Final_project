using Final_project.DBConnection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_project.Ado_NET.DAO.Dialog
{
    class BL_UpdateThesisDialog
    {
        string tablename = "Thesis";
        string primarycl = "username";
        string password_ = "password_";
        string role = "role_";
        DBconnection db;
        public BL_UpdateThesisDialog()
        {
            db = new DBconnection();
        }
        public bool EditThesis(string ID, string Topic, string Teacher_id, string Category, string Technology, string numbermember, string require, string function, ref string error)
        {
            string sqlString = "update " + tablename +
                " set topic='" + Topic + "', teacher_id='" + Teacher_id + "', category='" + Category + "', Technology='" + Technology + "', Number_member=" + numbermember + ", require='" + require + "', Function_contain='" + function + 
                "'where thesis_id='"+ID+"'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref error);
        }
    }
}
