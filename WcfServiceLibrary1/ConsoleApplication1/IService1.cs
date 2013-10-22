using System;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace ConsoleApplication1
{
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
	[ServiceContract]
	[ServiceKnownType(typeof(Contact))]
	[ServiceKnownType(typeof(CompositeType))]
	public interface IService1:IService2
	{
		[OperationContract]
		void AddContact(IContact contact);

		[OperationContract]
		IContact[] GetContancts();

		[OperationContract]
		string GetSimpleProperty();

		[OperationContract]
		string GetData(int value);

		[OperationContract(Name = "GetDataDouble")]
		string GetData(double value);

		[OperationContract]
		CompositeHelper GetDataUsingDataContract(CompositeHelper composite);

		[OperationContract]
		//[ServiceKnownType(typeof(CompositeType))]
		CompositeHelper GetDataUsingDataContract1(CompositeHelper composite);
		// TODO: Add your service operations here

		[OperationContract]
		Contact GetPersonContact(Person person);
	}

	[ServiceContract]
	public interface IService2
	{
		[OperationContract]
		string GetDataWithService2(int value);
	}
	
	public interface IContact
	{
		string FirstName { get; set; }
		string LastName { get; set; }
	}
	
	[DataContract]
	public class Contact:IContact
	{
		[DataMember]
		public string FirstName { get; set; }
		
		[DataMember]
		public string LastName { get; set; }
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
		void Serealizing(StreamingContext streaming)
		{
			//this.Result = "OnSerialized CompositeHelper";
		}

		[OnDeserializing]
		void Deserealizing(StreamingContext streaming)
		{
			this.Result = "OnDeserializing Heello Andrey";
		}

	}

	[DataContract]
	public class CompositeType:CompositeHelper
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

		[OnSerialized]
		void Serealizinggg(StreamingContext streaming)
		{
			Helper.Result = "God Buy Andrey!";
		}

		[OnDeserializing]
		void Deserealizing(StreamingContext streaming)
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

	[DataContract]
	public class Contact
	{
		public Contact()
		{
			//FirstName = "Просто так";
		}
		
		[DataMember]
		public string FirstName { get; set; }

		[DataMember]
		public string LastName { get; set; }
	}

	[DataContract(Name = "Contact")]
	public class Person
	{
		[DataMember]
		public string FirstName { get; set; }

		[DataMember]
		public string LastName { get; set; }

		public Person()
		{
			FirstName = "Просто так";
		}

		[OnDeserializing]
		public void Deser(StreamingContext context)
		{
			FirstName = "Просто так";
		}

		//[OnDeserialized]
		//public void Desered(StreamingContext context)
		//{
		//	FirstName = "Просто так";
		//}
	}
}
