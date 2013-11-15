using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace ConsoleApplication1
{
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
	[ServiceContract]
	[ServiceKnownType(typeof(CompositeType))]
	public interface IService1
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
        MyCollection GetCollection(string[] people);

        [OperationContract]
	    Gggg GetEnum();

	    #region неработающая хрнь с датасетом

	    //[OperationContract]
	    //void AddContacts(MyDataSet.ContactsDataTable contacts);

	    //[OperationContract]
	    //MyDataSet.ContactsDataTable GetContacts();

	    #endregion
	}

    [DataContract]
    public enum Gggg
    {
        [EnumMember]
        dgdgf=1,
        dsfdfs=2
    }

    [CollectionDataContract]
    public class MyCollection:Collection<Color>
    {
        public Color[] _people;

        public MyCollection(string[] people) 
        {
            _people = new Color[people.Length];
            for (var i = 0; i < people.Length; i++)
            {
                _people[i] = new Color() {Name = people[i]};
            }
            
        }

        public MyCollection()
        {
            
        }
    }
    
    public class Color
    {
        public string Name { get; set; }
    }

    //[DataContract]
    //public class Color:IEnumerator
    //{
    //    public string[] _people;

    //    private int _position = -1;

    //    public Color(string[] people)
    //    {
    //        _people = people;
    //    }
        
    //    public bool MoveNext()
    //    {
    //        _position++;
    //        return _people.Length > _position;
    //    }

    //    public void Reset()
    //    {
    //        _position = -1;
    //    }

    //    [DataMember]
    //    public object Current
    //    {
    //        get { return _people[_position]; }
    //    }
    //}

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

}
