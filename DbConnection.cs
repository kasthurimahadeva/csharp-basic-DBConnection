using System;

namespace DatabaseConnection
{
    abstract class DbConnection
    {
        public string ConnectionString { get; set; }
        protected TimeSpan Timeout { get; set; }

        public DbConnection(string connectionString)
        {
            if(connectionString == null) throw new NullReferenceException("Connection string cannot be null");
            ConnectionString = connectionString;
        }

        public abstract void OpenConnection();
        public abstract void CloseConnection();
    }
}