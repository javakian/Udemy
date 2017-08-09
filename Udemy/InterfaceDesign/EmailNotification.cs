using System;
namespace Udemy.InterfaceDesign
{
    public class EmailNotification : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Email that video has started processing");
        }
    }
}
