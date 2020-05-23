using System;

namespace DatabaseConnection
{
    class DbCommand
    {
        private DbConnection _dbConnection;
        private string _instruction;

        public DbCommand(DbConnection dbConnection, string instruction)
        {
            if(dbConnection == null) throw new NullReferenceException("Connection cannot be null");
            if(instruction == null) throw new NullReferenceException("Instruction cannot be null");
            _dbConnection = dbConnection;
            _instruction = instruction;
        }

        public void Execute()
        {
            _dbConnection.OpenConnection();
            Console.WriteLine($"{_instruction} is running");
            _dbConnection.CloseConnection();
        }
    }
}