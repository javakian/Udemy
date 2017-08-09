using System;
namespace Udemy.InterfaceDesign
{
    public class Upload : IActivity
    {
        public Upload()
        {
        }

        public void Execute()
        {
            Console.WriteLine("Upload Vido Now");
        }
    }
}
