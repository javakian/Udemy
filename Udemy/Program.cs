using System;

namespace Udemy
{
    class Program
    {
        static void Main(string[] args)
        {
            var oracleDB = new OracleConnection("teamOracle");
            var sqlDB = new SqlConnection("teamSQl");
            var _dbCommandSQL = new DbCommand(sqlDB);
            var _dbCommandOracle = new DbCommand(oracleDB);

            //oracleDB.OpenConnection();

            //oracleDB.CloseConnection();
            //sqlDB.OpenConnection();
            //sqlDB.CloseConnection();

            _dbCommandSQL.Execute();
            _dbCommandOracle.Execute();
        }
    }
}