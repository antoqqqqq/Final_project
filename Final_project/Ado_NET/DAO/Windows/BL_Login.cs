using System.Data;
using System.Data.Common;
using Final_project.DBConnection; 
namespace Final_project.DAO.Windows
{
    class BL_Login
    {
        string tablename = "Login";
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
            string query = "SELECT "+role+" FROM "+tablename+" WHERE "+ primarycl + " = '" + username + "' AND "+ password+" ='" + password + "'";
            return  db.CheckLogin(query,CommandType.Text,ref error);
        }

    }
}
