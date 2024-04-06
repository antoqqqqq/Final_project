using Final_project.DBConnection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_project.Ado_NET.DAO.UserControls
{
    class BL_AccountInformation
    {
        string tablename0 = "Teacher";
        string tablename1 = "Student";
        string primarycl = "ID";
        string secondcol = "name";
        string thirdcol = "email";
        string forthcol = "username";
        List<string> list = new List<string>();
        DBconnection db;
        public BL_AccountInformation()
        {
            db = new DBconnection();
        }
        public List<string> GetAccouninformation(int role, string username, ref string error)
        {
            if (role ==0)
            {
                string query = "SELECT * FROM " + tablename0 + " WHERE " + forthcol + " = '" + username + "'";
                return db.GetRowInfo(query, CommandType.Text, ref error);
            }
            else {
                string query = "SELECT * FROM " + tablename1 + " WHERE " + forthcol + " = '" + username+"'";
                return db.GetRowInfo(query, CommandType.Text, ref error);
            }
        }
    }
}
