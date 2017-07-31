using System;

namespace Udemy
{
    public class SqlConnection : DbConnect
    {
        public SqlConnection(string connectionString) 
            : base(connectionString)
        {
        }

        public override void OpenConnection()
        {
            Console.WriteLine("Opening connection with SQL DB");
        }

        public override void CloseConnection()
        {
            Console.WriteLine("Closing connection with SQL DB");
        }
    }
}