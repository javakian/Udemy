using System;
namespace Udemy.InterfaceDesign
{
    public class WorkflowEngine
    {
        private Workflow _workflow;

        public WorkflowEngine(Workflow workflow)
        {
            _workflow = workflow;
        }

        public void run(){
            _workflow.Run();
        }
    }
}
