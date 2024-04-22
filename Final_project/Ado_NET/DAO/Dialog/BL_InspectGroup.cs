namespace Final_project.Ado_NET.DAO.Dialog;
using Final_project.DBConnection;
using System.Data;

internal class BL_InspectGroup
{
    DBconnection db = null;
    string tablename = "Thesis_register";
    string primarycl = "Thesis_id";
    string tablemember = "groups";
    string tablestudent = "Student";
    string seconcol = "teacherid";
    string thirdcol = "studentid";
    public BL_InspectGroup() { db = new DBconnection(); }
    public bool New(string thesisid, string Teacher_id, string studentid, ref string error)
    {
        string sqlString = "INSERT INTO " + tablename +
            " VALUES ('" + thesisid + "', '" + Teacher_id + "','" + studentid + "')";
        return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref error);
    }
    public DataTable getGroupCreated(string Thesisid)
    {
        DataTable dt = new DataTable();
        dt.Clear();
        DataSet ds = db.ExecuteQueryDataSet("SELECT sg.group_name AS GroupName, COUNT(*) AS NumberOfGroups " +
            "FROM     student_group sg " +
            "WHERE   sg.group_name IN (SELECT group_name FROM thesis WHERE thesis_id = '"+Thesisid+"') " +
            "GROUP BY     sg.group_name;", CommandType.Text);
        dt = ds.Tables[0];
        return dt;
    }
}
