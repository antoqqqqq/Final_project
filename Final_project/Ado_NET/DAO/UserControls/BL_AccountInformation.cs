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
        string teacherid = "teacher_id";
        string studentid = "student_id";
        string username ="username";
        List<string> list = new List<string>();
        DBconnection db;
        public BL_AccountInformation()
        {
            db = new DBconnection();
        }
        public List<string> GetAccouninformation(int role, string id, ref string error)
        {
            if (role ==0)
            {
                string query = "SELECT * FROM " + tablename0 + " WHERE teacher_id = '" + id + "'";
                return db.GetRowInfo(query, CommandType.Text, ref error);
            }
            else {
                string query = "SELECT * FROM " + tablename1 + " WHERE student_id = '" + id+"'";
                return db.GetRowInfo(query, CommandType.Text, ref error);
            }
        }
        public string getid(string username, int role, ref string error)
        {
            if (role == 0)
            {
                string query = "SELECT " + teacherid + " FROM " + tablename0 + " WHERE " + this.username + " = '" + username + "'";
                return db.Getparameter(query, teacherid, CommandType.Text, ref error);
            }
            else
            {
                string query = "SELECT " + studentid + " FROM " + tablename1 + " WHERE " + this.username + " = '" + username + "'";
                return db.Getparameter(query, studentid, CommandType.Text, ref error);
            }
        }
    }
}
