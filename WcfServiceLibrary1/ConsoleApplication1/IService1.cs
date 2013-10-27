using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
		//[OperationContract]
		//void AddContact(IContact contact);

		//[OperationContract]
		//IContact[] GetContancts();

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
		Contact GetPersonContact(Contact person, int y);

		[OperationContract]
		UserStatus GetUserStatus(UserStatus status);

		[OperationContract]
		DataSet GetTables();

		[OperationContract]
		int GetGenericInt(MyClass<int> i);

		[OperationContract]
		string GetGenericString(MyClass<string> i);

		[OperationContract]
		Contact GetGenericContact(MyClass<Contact> i);

		[OperationContract]
		Person GetGenericPerson(MyClass<Person> i);

		[OperationContract]
		List<Person> GetPersons();

		#region неработающая хрнь с датасетом

		//[OperationContract]
		//void AddContacts(MyDataSet.ContactsDataTable contacts);

		//[OperationContract]
		//MyDataSet.ContactsDataTable GetContacts();

		#endregion
	}

	[DataContract(Name = "My{0}{#}ClassOf")]
	public class MyClass<T>
	{
		[DataMember]
		public T Member { get; set; }
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

	#region Неработающая хрень с датасето и дататейблом
	//[Serializable]
	//public partial class MyDataSet : DataSet
	//{
	//	[Serializable]
	//	public partial class ContactsDataTable : DataTable, IEnumerable
	//	{
	//		public void AddContactsRow(ContactsRow row)
	//		{

	//		}
	//		public ContactsRow AddContactsRow(string FirstName, string LastName)
	//		{
	//			return null;
	//		}

	//		public IEnumerator GetEnumerator()
	//		{
	//			return null;
	//		}
	//	}

	//	public partial class ContactsRow 
	//	{
	//		protected internal ContactsRow()
			
	//		{
	//		}
			
	//		public string FirstString { get; set; }
	//	}
	//}

	//public partial class ContactsTableAdapter : Component
	//{
	//	public virtual MyDataSet.ContactsDataTable GetData()
	//	{
	//		return new MyDataSet.ContactsDataTable();
	//	}
	//}
	#endregion

	[DataContract]
	public enum UserStatus
	{
		Banned = 1,
		[EnumMember(Value = "Не забаненный")]
		Unbanned = 2,
		Deleted = 3
	}

	#region CompositeHelper и Type
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

#endregion

	[DataContract]
	public class Contact
	{
		public Contact()
		{
			FirstName = "Просто так конструктор";
		}

		//[field: DataMember]
		//public event SimpleDelagete MHandler;

		//protected virtual void OnMHandler(int i)
		//{
		//	SimpleDelagete handler = MHandler;
		//	if (handler != null) handler(i);
		//}

		//[DataMember]
		//public UserStatus Status{ get; set; }

		[DataMember(IsRequired = true)]
		public string FirstName { get; set; }

		[DataMember]
		public string LastName { get; set; }

		[DataMember]
		public string AddedProp { get; set; }

		[OnDeserializing]
		public void Deser(StreamingContext context)
		{
			LastName = "Просто так Contact";
		}

		[OnDeserialized]
		public void Desered(StreamingContext context)
		{
			//FirstName = "Просто так Contact";
			AddedProp = "Просто так Person";
		}


	}
	//[Serializable]
	//public delegate void SimpleDelagete(int i);

	[DataContract()]
	public class Person
	{
		[DataMember]
		public string FirstName { get; set; }

		[DataMember]
		public string LastName { get; set; }
		
		public Person()
		{
			FirstName = "Просто так Person";
		}

		[OnDeserializing]
		public void Deser(StreamingContext context)
		{
			FirstName = "Просто так Person";
		}

		[OnDeserialized]
		public void Desered(StreamingContext context)
		{
			FirstName = "Просто так Person";

		}
	}
}
