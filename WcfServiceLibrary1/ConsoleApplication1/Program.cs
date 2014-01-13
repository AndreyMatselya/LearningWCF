using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Diagnostics;
using System.Net.Mail;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;

namespace ConsoleApplication1
{
	class Program
	{
		static void Main(string[] args)
		{
            //using (var host = new ServiceHost(new Service1()))
            using (var host = new ServiceHost(typeof(Service1)))
			{
                if (host.State == CommunicationState.Created)
                {
                    host.Open();
                    Console.WriteLine("СЛУЖБА ЗАПУЩЕНА");
                    Console.WriteLine(host.SingletonInstance == null);
                    Console.ReadLine();
                }
			}

            //var obj = typeof (DataSet).GetCustomAttributes(typeof (SerializableAttribute), false);
            //var channel = InProcFactory.CreateInstance<Service1, IService1>();
            //Console.WriteLine("СЛУЖБА ЗАПУЩЕНА");
            //Console.ReadLine();
            //InProcFactory.ClozeProxy(channel); 
		}
	}

    //class InProcFactory
    //{
    //    struct HostRecord
    //    {
    //        public HostRecord(ServiceHost host, string address)
    //        {
    //            Host = host;
    //            Address = address;
    //        }

    //        public readonly ServiceHost Host;

    //        public readonly string Address;
    //    }

    //    static readonly Uri BaseAddress = new Uri("http://localhost:8733/trololo");
    //    private static readonly Binding BasicHttpBinding;
    //    static Dictionary<Type, HostRecord> m_Hosts = new Dictionary<Type, HostRecord>();

    //    static InProcFactory()
    //    {
    //        BasicHttpBinding = new BasicHttpBinding(); 
    //        AppDomain.CurrentDomain.ProcessExit += CurrentDomainProcessExit;
    //    }

    //    static void CurrentDomainProcessExit(object sender, EventArgs e)
    //    {
    //        foreach (var hostRecord in m_Hosts)
    //        {
    //            hostRecord.Value.Host.Close();
    //        }
    //    }

    //    public static I CreateInstance<S, I>()
    //        where I : class
    //        where S : I
    //    {
    //        var hostRecord = GetHostRecord<S, I>();
    //        return ChannelFactory<I>.CreateChannel(BasicHttpBinding, new EndpointAddress(hostRecord.Address));
    //    }

    //    private static HostRecord GetHostRecord<S, I>()
    //    {
    //        HostRecord hostRecord;
    //        if (m_Hosts.ContainsKey(typeof(S)))
    //        {
    //            hostRecord = m_Hosts[typeof(S)];
    //        }
    //        else
    //        {
    //            var host = new ServiceHost(typeof(S), BaseAddress);
    //            var mex = host.Description.Behaviors.Find<ServiceMetadataBehavior>();
    //           // OperationDescription operation = host.Description.Endpoints[0].Contract.Operations.Find("MyOperationName"); 
    //            //operation.Behaviors.Find<DataContractSerializerOperationBehavior>().MaxItemsInObjectGraph = 3;
    //            if (mex==null)
    //            {
    //                mex = new ServiceMetadataBehavior {HttpGetEnabled = true};
    //                host.Description.Behaviors.Add(mex);
				   
    //                host.AddServiceEndpoint(typeof(IMetadataExchange),
    //                    new CustomBinding(new BindingElement[] { new HttpTransportBindingElement(), }), "mex");
    //            }
                
    //            var address = BaseAddress + "/blin";
    //            hostRecord = new HostRecord(host, address);
    //            m_Hosts.Add(typeof(S), hostRecord);
    //            host.AddServiceEndpoint(typeof(I), BasicHttpBinding, address);
    //           // host.Description.Endpoints[0].Contract.Operations.Find("GetCollection").Behaviors.Find<DataContractSerializerOperationBehavior>().MaxItemsInObjectGraph = 100;
    //            host.Open();
    //        }
    //        return hostRecord;
    //    }

    //    public static void ClozeProxy<I>(I instance) where I : class
    //    {
    //        var proxy = instance as ICommunicationObject;
    //        Debug.Assert(proxy != null);
    //        proxy.Close();
    //    }
    //}
}
