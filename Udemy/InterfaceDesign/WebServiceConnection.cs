using System;
namespace Udemy.InterfaceDesign
{
    public class WebServiceConnection : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Video encoding service, your video is ready for encoding");
        }
    }
}
