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
            var service = new Service1Client("WSHttpBinding_IService1");
            //var service = new Service1Client("BasicHttpBinding_IService1");
            //var service = new Service1Client("NetTcpBinding_IService1");
		    for (var i = 0; i < 4; i++)
		    {
		        Console.WriteLine("Количество элементов: {0}",service.GetDict(i.ToString()).Count);
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
