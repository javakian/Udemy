using System;
using System.Runtime.InteropServices;
namespace Udemy
{
    public class DbCommand //<T> where T : DbConnect
    {
        readonly DbConnect _dbConnect;

        //public DbCommand(T dbConnect) => _dbConnect = dbConnect ?? throw new Exception("dbConnect is null");
        //or
        public DbCommand(DbConnect dbConnect)
        {
            _dbConnect = dbConnect ?? throw new Exception("dbConnect is null");
        }

        public void Execute()
        {
            _dbConnect.OpenConnection();
            _dbConnect.CloseConnection();
        }
    }
}
