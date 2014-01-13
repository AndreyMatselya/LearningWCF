using System;
using System.Drawing;
using System.ServiceModel;
using ConsoleApplication1.ServiceReference1;

namespace ConsoleApplication1
{
	class Program : ServiceHost
	{
		[STAThread]
		private static void Main(string[] args)
		{
            //var service = new Service1Client("WSHttpBinding_IService1");
            //var service = new Service1Client("BasicHttpBinding_IService1");
            var service = new Service1Client("NetTcpBinding_IService1");
            Console.WriteLine("InactivityTimeout: " + ((NetTcpBinding)service.Endpoint.Binding).ReliableSession.InactivityTimeout);
            Console.WriteLine("OpenTimeout: " + service.Endpoint.Binding.OpenTimeout);
            Console.WriteLine("CloseTimeout: " + service.Endpoint.Binding.CloseTimeout);
            Console.WriteLine(default(DateTime));

            
		    for (var i = 0; i < 4; i++)
		    {
                service.Init();
                Console.WriteLine("Количество элементов: {0}",service.GetDict(i.ToString()).Count);
                Console.WriteLine("SessionId: " + service.InnerChannel.SessionId);
		    }
            service.Close();
		    Console.ReadLine();
		}


	}
    internal class Color
    {
        public string Name { get; set; }
    }
}
