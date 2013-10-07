using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using ConsoleApplication1.ServiceReference1;

namespace ConsoleApplication1
{
	class Program:ServiceHost
	{
		
		[STAThread]
		static void Main(string[] args)
		{
			//var client = new Service1Client("BasicHttpBinding_IService1");



			EndpointAddress adress = new EndpointAddress("http://localhost:8733/trololo/blin");
			var binding = new BasicHttpBinding();


			/*IService1 client = ChannelFactory<IService1>.CreateChannel(binding, adress);
			Console.WriteLine(client.GetData(123));
			Console.WriteLine(client.GetDataDouble(16f));
			Console.WriteLine(client.GetDataWithService2(123123));
			((ICommunicationObject)client).Close();*/

			/*
			Service2Client t = new Service1Client(binding, adress);
			Console.WriteLine(t.GetDataWithService2(123123));*/



			//Service1Client f = new Service2Client();
			var httpBindingElement = new HttpTransportBindingElement();
			httpBindingElement.MaxReceivedMessageSize *= 5;
			var mexx = new MetadataExchangeClient(new CustomBinding(new BindingElement[] { new HttpTransportBindingElement() }));
			var metadata = mexx.GetMetadata(new EndpointAddress("http://localhost:8733/trololo/mex"));
			var importer = new WsdlImporter(metadata);
			var contracts = importer.ImportAllContracts();
			using (var xmlWriter = new XmlTextWriter("C:\\xcv.xml", Encoding.UTF8))
			{
				metadata.WriteTo(xmlWriter);
			}

		}
	}


}
