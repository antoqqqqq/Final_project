using System.Data;
using System.Data.Common;
using Final_project.DBConnection; 
namespace Final_project.DAO.Windows
{
    class BL_Login
    {
        string tablename = "Login";
        string tablename0 = "Teacher";
        string tablename1 = "Student";
        string teacherid = "teacher_id";
        string studentid = "student_id";
        string primarycl = "username";
        string password_ = "password_";
        string role = "role_";
        DBconnection db ;
        public BL_Login()
        {
            db = new DBconnection();
        }
        public string CheckLogin(string username, string password, ref string error)
        {
            string query = "SELECT "+role+" FROM "+tablename+" WHERE "+ primarycl + " = '" + username + "' AND "+ password_ + " ='" + password + "'";
            return  db.Getparameter(query, role, CommandType.Text,ref error);
        }
        public string getid(string username,int role,ref string error)
        {
            if (role == 0)
            {
                string query = "SELECT " + teacherid + " FROM " + tablename0 + " WHERE " + primarycl + " = '" + username +  "'";
                return db.Getparameter(query,teacherid, CommandType.Text, ref error);
            }
            else
            {
                string query = "SELECT " + studentid + " FROM " + tablename1 + " WHERE " + primarycl + " = '" + username + "'";
                return db.Getparameter(query,studentid, CommandType.Text, ref error);
            }
        }

    }
}
