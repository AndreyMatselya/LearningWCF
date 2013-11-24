﻿using System;
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
		static void Main(string[] args)
		{
			//var client = new Service1Client("BasicHttpBinding_IService1");


			EndpointAddress adress = new EndpointAddress("http://katusha:8733/trololo/blin");
			var binding = new BasicHttpBinding();
		    binding.MaxReceivedMessageSize = 200000;
			//AddingUsersClient g = new AddingUsersClient();
			//g.AddUser(291);


			/*
			IService1 client = ChannelFactory<IService1>.CreateChannel(binding, adress);
			Console.WriteLine(client.GetData(123));
			Console.WriteLine(client.GetDataDouble(16f));
			Console.WriteLine(client.GetDataWithService2(123123));
			((ICommunicationObject)client).Close();


			*/


		    var myList = new ConsoleApplication1.List<Color>();
            myList.Add(new Color(){Name = "Andrey"});
            myList.Add(new Color() { Name = "Vitya" });
            myList.Add(new Color() { Name = "Matselya" });
		    var t = myList.Count;
            
			Service1Client service = new Service1Client(binding, adress);
			//Console.WriteLine(t.GetDataWithService2(777777777));
			//var result = t.GetDataUsingDataContract(new CompositeType() {Result = "C сервачка значение"});+
		    var p = service.GetData(343);
//		    var response = t.GetCollection(new[] {"Саша", "Маша", "Каша"});
		    var result = service.GetColors();
		    
		    //Console.WriteLine(result.Result);
			Console.ReadLine();

			#region закоменчено
			//Service1Client t = new Service1Client(binding, adress);
			//Console.WriteLine(t.GetDataWithService2(777777777));
			//var result = t.GetDataUsingDataContract(new CompositeType() {Result = "C сервачка значение"});
			//Console.WriteLine(result.Result);
			//Console.ReadLine();


			//var _b = new DataContractSerializer(typeof(SomeClass));
			//IFormatter _b = new NetDataContractSerializer();
			//var stream = new StreamWriter();
			//	using (var stream = new FileStream(@"C:\serial.txt", FileMode.Create))
			//{
			//_b.Serialize(stream, new SomeClass("ооООО") { Prop1 = "Мацеля", Prop2 = "Андрей", Prop3 = 123, Prop4 = 1234f, Mass = new[] { 12, 23, 44 } });
			//	_b.WriteObject(stream, new SomeClass("ыыыЫЫЫы") { Prop1 = "Мацеля", Prop2 = "Андрей", Prop3 = 123, Prop4 = 1234f, Mass = new[] { 1, 2, 3, 4, 5 } });
			//stream.Seek(0, SeekOrigin.Begin);
			//var cl = (SomeClass)_b.ReadObject(stream);
			//}


			//Service1Client f = new Service2Client();
			/*var httpBindingElement = new HttpTransportBindingElement();
			httpBindingElement.MaxReceivedMessageSize *= 5;
			var mexx = new MetadataExchangeClient(new CustomBinding(new BindingElement[] { new HttpTransportBindingElement() }));
			var metadata = mexx.GetMetadata(new EndpointAddress("http://localhost:8733/trololo/mex"));
			var importer = new WsdlImporter(metadata);
			var contracts = importer.ImportAllContracts();
			using (var xmlWriter = new XmlTextWriter("C:\\xcv.xml", Encoding.UTF8))
			{
				metadata.WriteTo(xmlWriter);
			}
			*/
			#endregion
		}
	}
}
