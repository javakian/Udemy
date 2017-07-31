using System;

namespace Udemy
{
    public abstract class DbConnect
    {
        public String ConnectionString { get; set; }
        public TimeSpan Timeout { get; set; }

        protected DbConnect(string connectionString)
        {
            if (String.IsNullOrWhiteSpace(connectionString))
                throw new Exception("You've passed in an empty or invalid string");

            ConnectionString = connectionString;
        }

        public abstract void OpenConnection();

        public abstract void CloseConnection();
    }
}