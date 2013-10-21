using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;

namespace ConsoleApplication1
{
	class Program
	{
		static void Main(string[] args)
		{
			//var host = new ServiceHost(typeof(Service1), new Uri("http://localhost:8733/trololo"), new Uri("net.tcp://localhost:8732/trololo"));
			//if (host.Description.Behaviors.Find<ServiceMetadataBehavior>() == null)
			//{
			//	host.Description.Behaviors.Add(new ServiceMetadataBehavior());
			//}
			//host.AddServiceEndpoint(typeof(IService1), new NetTcpBinding(), "blin");
			//host.AddServiceEndpoint(typeof(IService1),new BasicHttpBinding(),"blin");
			//host.AddServiceEndpoint(typeof(IMetadataExchange), new CustomBinding(new BindingElement[] { new TcpTransportBindingElement() }), "");
			//host.AddServiceEndpoint(typeof(IMetadataExchange), new CustomBinding(new BindingElement[] { new HttpTransportBindingElement(),  }), "mev");
			//host.Open();
			//Console.ReadLine();
			//host.Close();



			var channel = InProcFactory.CreateInstance<Service1, IService1>();
			Console.WriteLine(channel.GetDataWithService2(324324));
			Console.WriteLine(channel.GetData(324324f));
			Console.WriteLine(channel.GetSimpleProperty());
			channel.AddContact(new Contact(){FirstName = "Андрей",LastName = "Мацеля"});
			Console.ReadLine();
			InProcFactory.ClozeProxy(channel); 
		}
	}

	class InProcFactory
	{
		struct HostRecord
		{
			public HostRecord(ServiceHost host, string address)
			{
				Host = host;
				Address = address;
			}

			public readonly ServiceHost Host;

			public readonly string Address;
		}

		static readonly Uri BaseAddress = new Uri("http://katusha:8733/trololo");
		private static readonly Binding BasicHttpBinding;
		static Dictionary<Type, HostRecord> m_Hosts = new Dictionary<Type, HostRecord>();

		static InProcFactory()
		{
			BasicHttpBinding = new BasicHttpBinding(); 
			AppDomain.CurrentDomain.ProcessExit += CurrentDomainProcessExit;
		}

		static void CurrentDomainProcessExit(object sender, EventArgs e)
		{
			foreach (var hostRecord in m_Hosts)
			{
				hostRecord.Value.Host.Close();
			}
		}

		public static I CreateInstance<S, I>()
			where I : class
			where S : I
		{
			var hostRecord = GetHostRecord<S, I>();
			return ChannelFactory<I>.CreateChannel(BasicHttpBinding, new EndpointAddress(hostRecord.Address));
		}

		private static HostRecord GetHostRecord<S, I>()
		{
			HostRecord hostRecord;
			if (m_Hosts.ContainsKey(typeof(S)))
			{
				hostRecord = m_Hosts[typeof(S)];
			}
			else
			{
				var host = new ServiceHost(typeof(S), BaseAddress);
				var mex = host.Description.Behaviors.Find<ServiceMetadataBehavior>();
				if (mex==null)
				{
					mex = new ServiceMetadataBehavior {HttpGetEnabled = true};
					host.Description.Behaviors.Add(mex);
					host.AddServiceEndpoint(typeof(IMetadataExchange),
						new CustomBinding(new BindingElement[] { new HttpTransportBindingElement(), }), "mex");
				}
				var address = BaseAddress + "/blin";
				hostRecord = new HostRecord(host, address);
				m_Hosts.Add(typeof(S), hostRecord);
				host.AddServiceEndpoint(typeof(I), BasicHttpBinding, address);
				host.Open();
			}
			return hostRecord;
		}

		public static void ClozeProxy<I>(I instance) where I : class
		{
			var proxy = instance as ICommunicationObject;
			Debug.Assert(proxy != null);
			proxy.Close();
		}
	}
}
