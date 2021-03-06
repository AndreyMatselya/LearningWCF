﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Dispatcher;
using System.Threading;

namespace ConsoleApplication1
{
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
     [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall, ConcurrencyMode = ConcurrencyMode.Reentrant)]   
	public class Service1 : IService1,IDisposable
    {
        #region All old
        //public string GetData(int value)
        //{
        //    return string.Format("You entered: {0}", value);
        //}

        ////private static IContact[] _contacts;

        ////static Service1()
        ////{
        ////	_contacts = new IContact[3];	
        ////}

        //public CompositeHelper GetDataUsingDataContract(CompositeHelper composite)
        //{
        //    if (composite == null)
        //    {
        //        throw new ArgumentNullException("composite");
        //    }
        //    //if (composite.BoooooolValue)
        //    //{
        //    //	composite.StringValue += "Suffix";
        //    //}
        //    return composite;
        //}

        //public string GetData(double value)
        //{
        //    return string.Format("You entered double: {0}", value);
        //}

        //public string GetDataWithService2(int value)
        //{
        //    return string.Format("You entered double Iservice2: {0}", value);
        //}

        //public string SimpleProperty { get; set; }

        //public string GetSimpleProperty()
        //{
        //    SimpleProperty = 34234.ToString(CultureInfo.InvariantCulture);
        //    return SimpleProperty;
        //}

        //public CompositeHelper GetDataUsingDataContract1(CompositeHelper composite)
        //{
        //    return composite;
        //}

        //public void ProcessArray(string[] array)
        //{
        //    foreach (var s in array)
        //    {
        //        Debug.WriteLine(s);
        //    }
        //}

	    //public IContact[] GetContancts()
		//{
		//	return _contacts;
		//}

		//public void AddContact(IContact contact)
		//{
		//	_contacts[0] = new Contact() { FirstName = contact.FirstName, LastName = contact.LastName };
		//}


        //public DataSet GetTables()
        //{
        //    throw new NotImplementedException();
        //}

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

        //public Stack<Color> GetCollection(string[] peoples)
        //{
        //    return new Stack<Color>(peoples.Select(x => new Color() {Name = x}));
        //}

        //List<Color> _list = new List<Color>(){new Color(){Name = "123"},new Color(){Name = "456"}}; 

        //public IEnumerable<Color> GetColors()
        //{
        //    foreach (var item in _list)
        //    {
        //        yield return item;
        //    }
        //}
#endregion
        // [OperationBehavior(ReleaseInstanceMode = ReleaseInstanceMode.BeforeAndAfterCall)]

       
         public Service1()
         {
             Trace.WriteLine(OperationContext.Current.SessionId);
         }

         //[OperationBehavior(ReleaseInstanceMode = ReleaseInstanceMode.AfterCall)]
         public void Connect()
         {
             var calback = OperationContext.Current.GetCallbackChannel<ISomeCallback>();
             if (!_hh.Contains(calback))
             {
                 _hh.Add(calback);
             }
         }

         public void Disconnect()
         {
             var calback = OperationContext.Current.GetCallbackChannel<ISomeCallback>();
             if (_hh.Contains(calback))
             {
                 _hh.Remove(calback);
             }
             else
             {
                 throw new InvalidOperationException("Не найден колбек");
             }
         }

         public void Init()
         {
             foreach (var someCallback in _hh)
             {
                 someCallback.Callback();
             }
         }

         static IList<ISomeCallback> _hh = new List<ISomeCallback>();

         public void Dispose()
         {
             Trace.WriteLine("Dispose" + _hh.Count);
             Trace.WriteLine(Thread.CurrentThread.ManagedThreadId);
         }
    }
}
