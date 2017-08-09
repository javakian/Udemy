using System;
namespace Udemy.InterfaceDesign
{
    public class Database : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("DB status: Processing");
        }
    }
}
