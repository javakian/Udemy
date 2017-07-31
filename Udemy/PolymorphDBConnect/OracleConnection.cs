using System;

namespace Udemy
{
    public class OracleConnection : DbConnect
    {
        public OracleConnection(string connectionString) 
            : base(connectionString)
        {
        }

        public override void OpenConnection()
        {
            Console.WriteLine("Opening Connection with Oracle DB");
        }

        public override void CloseConnection()
        {
            Console.WriteLine("Closing Connection with Oracle DB");
        }
    }
}