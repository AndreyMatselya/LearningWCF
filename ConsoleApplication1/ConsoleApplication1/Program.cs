using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.Threading;
using System.Threading.Tasks;
using ConsoleApplication1.ServiceReference1;

namespace ConsoleApplication1
{
	class Program :IDisposable
	{
	    private static Service1Client _service;

		[STAThread]
		private static void Main(string[] args)
		{
            //var service = new Service1Client("WSHttpBinding_IService1");
            //var service = new Service1Client("BasicHttpBinding_IService1");
            //var service = new Service1Client("NetTcpBinding_IService1");

            IService1Callback callback = new MyCallback();
            var context = new InstanceContext(callback);
            _service = new Service1Client(context, "WSDualHttpBinding_IService1");
          //for (var i = 0; i < 20; i++)
                //{
		            _service.Init();
                    //service.GetDict(new ServiceReference1.Color(){Name = "dsfdgf"});
                    //Console.WriteLine("Количество элементов: {0}", service.GetDict(i.ToString()).Count);
                    //Console.WriteLine("SessionId: " + service.InnerChannel.SessionId);




			
			Console.ReadLine();
        }

	    public void Dispose()
	    {
            _service.Close();
	    }
	}


    public class Duplex
    {

    }
}
