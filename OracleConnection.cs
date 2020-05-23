using System;

namespace DatabaseConnection
{
    class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString) : base(connectionString)
        {
        }

        public override void OpenConnection()
        {
            Console.WriteLine($"Connection started in {nameof(OracleConnection)}");
        }

        public override void CloseConnection()
        {
            Console.WriteLine($"Connection started in {nameof(OracleConnection)}");
        }
    }
}