using System;

namespace DatabaseConnection
{
    abstract class DbConnection
    {
        private string _connectionString;
        protected TimeSpan Timeout { get; set; }

        public DbConnection(string connectionString)
        {
            if(connectionString == null) throw new NullReferenceException("Connection string cannot be null");
            _connectionString = connectionString;
        }

        public abstract void OpenConnection();
        public abstract void CloseConnection();
    }
}