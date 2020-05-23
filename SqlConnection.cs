using System;

namespace DatabaseConnection
{
    class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString) : base(connectionString)
        {
        }

        public override void OpenConnection()
        {
            Console.WriteLine($"Connection started in {nameof(SqlConnection)}");
        }

        public override void CloseConnection()
        {
            Console.WriteLine($"Connection closed in {nameof(SqlConnection)}");
        }
    }
}