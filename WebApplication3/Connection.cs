using Microsoft.Data.SqlClient;

namespace WebApplication3
{
    public class Connection
    {
        SqlConnection connection = new SqlConnection("Data Source=AJAYDEVTS-991\\SQLEXPRESS;Initial Catalog=Schooldb;Integrated Security=True");
        SqlCommand command = new SqlCommand();

        public Connection()
        {
            connection.Open();
            command.Connection = connection;
        }
        public SqlCommand getCommand
        {
            get { return command; }
        }
    }
}
