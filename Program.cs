using System;

namespace DatabaseConnection
{
    class Program
    {
        static void Main(string[] args)
        {
            var sqlConnection = new SqlConnection("Panda");
            var dbCommand = new DbCommand(sqlConnection, "Karady");
            dbCommand.Execute();
            var oracleConnection = new OracleConnection("Karady");
            dbCommand = new DbCommand(oracleConnection, "Panda");
            dbCommand.Execute();
        }
    }
}