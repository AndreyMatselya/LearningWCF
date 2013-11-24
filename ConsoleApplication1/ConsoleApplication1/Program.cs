using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;
using ConsoleApplication1.ServiceReference1;

namespace ConsoleApplication1
{
	class Program : ServiceHost
	{
		[STAThread]
		private static void Main(string[] args)
		{
			var service = new Service1Client("ServiceReference1.IService1");
            myList.Add(new Color(){Name = "Andrey"});
            myList.Add(new Color() { Name = "Vitya" });
            myList.Add(new Color() { Name = "Matselya" });
		    var t = myList.Count;
            
			Service1Client service = new Service1Client(binding, adress);
		    var result = service.GetColors();
			Console.ReadLine();
		}

	}
}
