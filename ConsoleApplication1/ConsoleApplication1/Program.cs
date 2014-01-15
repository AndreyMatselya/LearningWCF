using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
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
            //Console.WriteLine("InactivityTimeout: " + ((NetTcpBinding)service.Endpoint.Binding).ReliableSession.InactivityTimeout);
            Console.WriteLine("OpenTimeout: " + service.Endpoint.Binding.OpenTimeout);
            Console.WriteLine("CloseTimeout: " + service.Endpoint.Binding.CloseTimeout);
            Console.WriteLine(default(DateTime));

		    var list = Create100Instanses().ToList();
            foreach (var s in list)
		    {
                //for (var i = 0; i < 20; i++)
                //{
                    s.Init();
                    //Console.WriteLine("Количество элементов: {0}", service.GetDict(i.ToString()).Count);
                    //Console.WriteLine("SessionId: " + service.InnerChannel.SessionId);
                //}
                Console.WriteLine(list.IndexOf(s));
		    }



			service.Close();
			Console.ReadLine();
		}

        static IEnumerable<Service1Client> Create100Instanses()
        {
            var array = new List<Service1Client>();
            for (var i = 0; i < 600; i++)
            {
                array.Add(new Service1Client("NetTcpBinding_IService1"));
            }
            return array;
        }

	}
    internal class Color
    {
        public string Name { get; set; }
    }
}
