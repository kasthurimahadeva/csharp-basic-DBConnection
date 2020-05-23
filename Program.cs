using System;

namespace DatabaseConnection
{
    class Program
    {
        static void Main(string[] args)
        {
            var sqlConnection = new SqlConnection("panda");
            sqlConnection.OpenConnection();
            sqlConnection.CloseConnection();
        }
    }
}