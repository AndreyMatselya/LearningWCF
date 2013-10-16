using System;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace ConsoleApplication1
{
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
	[ServiceContract]
	public interface IService1:IService2
	{
		[OperationContract]
		string GetSimpleProperty();

		[OperationContract]
		string GetData(int value);

		[OperationContract(Name = "GetDataDouble")]
		string GetData(double value);

		[OperationContract]
		string GetDataUsingDataContract(CompositeType composite);

		// TODO: Add your service operations here
	}

	[ServiceContract]
	public interface IService2
	{
		[OperationContract]
		string GetDataWithService2(int value);
	}

	// Use a data contract as illustrated in the sample below to add composite types to service operations.
	// You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "WcfServiceLibrary1.ContractType".
	//[Serializable]
	[DataContract]
	public class CompositeHelper
	{
		[DataMember()]
		public string Result{ get; set; }

		[OnSerializing]
		void Serealizinggg(StreamingContext streaming)
		{
			this.Result = "God Buy Andrey!";
		}
	}

	[DataContract]
	public class CompositeType
	{
		bool boolValueeeeee = true;
		string stringValue = "Hello ";

		public  CompositeHelper Helper;
		//[DataMember]
		public bool BoooooolValue
		{
			get { return boolValueeeeee; }
			set { boolValueeeeee = value; }
		}

		[OnSerializing]
		void Serealizinggg(StreamingContext streaming)
		{
			Helper.Result = "God Buy Andrey!";
		}

		[OnDeserialized]
		void Deserealized(StreamingContext streaming)
		{
			Helper = new CompositeHelper();
			Helper.Result = "Heello Andrey";
		}

		//[DataMember]
		public string StringValue
		{
			get { return stringValue; }
			set { stringValue = value; }
		}
		
		public  int m_int;
		[DataMember(Name = "ХерПойми")]
		public int M_Int
		{
			get { return m_int; }
			set { m_int = value; }
		}
	}
}
