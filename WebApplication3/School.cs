using Microsoft.Data.SqlClient;
using System.Data;
using WebApplication3.Models;

namespace WebApplication3
{
    public class School
    {
        Connection connection = new Connection();
        public string insertStudent(Student st)
        {
            connection.getCommand.CommandText = "insert into Student(Id,Name,std) values ('" + st.Id + "','" + st.Name + "','" + st.std + "')";
            connection.getCommand.ExecuteNonQuery();
            return "Success";
        }
        public string insertMark(Mark mk)
        {
            connection.getCommand.CommandText = "insert into Mark(markid,mark1,mark2,id) values ('" + mk.Markid + "','" + mk.Mark1 + "','" + mk.Mark2 + "','" + mk.id + "')";
            connection.getCommand.ExecuteNonQuery();
            return "Success";
        }
        public DataSet studentgetdata()
        {
            SqlDataAdapter adp = new SqlDataAdapter();
            DataSet ds = new DataSet();

            connection.getCommand.CommandText = "select * from Student";
            adp.SelectCommand = connection.getCommand;
            adp.Fill(ds);
            return ds;
        }
        public DataSet markgetdata(int id)
        {
            SqlDataAdapter adp = new SqlDataAdapter();
            DataSet ds = new DataSet();

            connection.getCommand.CommandText = "select * from Mark where Id= '"+ id+"'";
            adp.SelectCommand = connection.getCommand;
            adp.Fill(ds);
            return ds;
        }
    }
}

