﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Threading;
using System.Data;

namespace ConsoleApplication1
{
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
        
	public class Service1 : IService1
	{
		public string GetData(int value)
		{
			return string.Format("You entered: {0}", value);
		}

		//private static IContact[] _contacts;

		//static Service1()
		//{
		//	_contacts = new IContact[3];	
		//}

		public CompositeHelper GetDataUsingDataContract(CompositeHelper composite)
		{
			if (composite == null)
			{
				throw new ArgumentNullException("composite");
			}
			//if (composite.BoooooolValue)
			//{
			//	composite.StringValue += "Suffix";
			//}
			return composite;
		}

		public string GetData(double value)
		{
			return string.Format("You entered double: {0}", value);
		}

		public string GetDataWithService2(int value)
		{
			return string.Format("You entered double Iservice2: {0}", value);
		}

		public string SimpleProperty { get; set; }

		public string GetSimpleProperty()
		{
			SimpleProperty = 34234.ToString(CultureInfo.InvariantCulture);
			return SimpleProperty;
		}

		public CompositeHelper GetDataUsingDataContract1(CompositeHelper composite)
		{
			return composite;
		}

		//public IContact[] GetContancts()
		//{
		//	return _contacts;
		//}

		//public void AddContact(IContact contact)
		//{
		//	_contacts[0] = new Contact() { FirstName = contact.FirstName, LastName = contact.LastName };
		//}


		public DataSet GetTables()
		{
			throw new NotImplementedException();
		}

		#region неработающая хрнь с датасетом
		//public void AddContacts(MyDataSet.ContactsDataTable contacts)
		//{
		//	throw new NotImplementedException();
		//}

		//public MyDataSet.ContactsDataTable GetContacts()
		//{
		//	throw new NotImplementedException();
		//}
		#endregion

        public MyCollection GetCollection(string[] peoples)
	    {
            return new MyCollection(peoples);
	    }

	    public Gggg GetEnum()
	    {
	        return Gggg.dsfdfs;
	    }
	}
}
