using System;
using System.Runtime.InteropServices;
using System.Collections;
using System.Collections.Generic;
namespace Udemy.InterfaceDesign
{
    public class Workflow
    {
        private readonly IList<IActivity> _activity;

        public Workflow()
        {
            _activity = new List<IActivity>();
        }

        public void Run(){
            foreach (var activity in _activity)
            {
                activity.Execute();
            }
        }

        public void RegisterActivity(IActivity activity){
            _activity.Add(activity);
        }
    }
}
