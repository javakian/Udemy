using System;
using Udemy.InterfaceDesign;

namespace Udemy
{
    class Program
    {
        static void Main(string[] args)
        {
            //PolyMorphDB
            //var oracleDB = new OracleConnection("teamOracle");
            //var sqlDB = new SqlConnection("teamSQl");
            //var _dbCommandSQL = new DbCommand(sqlDB);
            //var _dbCommandOracle = new DbCommand(oracleDB);
            ////oracleDB.OpenConnection();
            ////oracleDB.CloseConnection();
            ////sqlDB.OpenConnection();
            ////sqlDB.CloseConnection();
            //_dbCommandSQL.Execute();
            //_dbCommandOracle.Execute();

            //InterfaceDesign
            var workflow = new Workflow();
            workflow.RegisterActivity(new Upload());
            workflow.RegisterActivity(new WebServiceConnection()); 
            workflow.RegisterActivity(new EmailNotification());
            workflow.RegisterActivity(new Database());

            var workflowEngine = new WorkflowEngine(workflow);
            workflowEngine.run();
        }
    }
}