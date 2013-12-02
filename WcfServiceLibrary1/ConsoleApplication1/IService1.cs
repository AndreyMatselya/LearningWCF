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
	[ServiceContract(SessionMode = SessionMode.Required)]
	public interface IService1
    {
        #region Все старое
        //[OperationContract]
        //string GetSimpleProperty();

        //[OperationContract]
        //string GetData(int value);

        //[OperationContract(Name = "GetDataDouble")]
        //string GetData(double value);

        //[OperationContract]
        //CompositeHelper GetDataUsingDataContract(CompositeHelper composite);

        //[OperationContract]
        ////[ServiceKnownType(typeof(CompositeType))]
        //CompositeHelper GetDataUsingDataContract1(CompositeHelper composite);
        //// TODO: Add your service operations here

        //[OperationContract]
        //void ProcessArray(string[] array);

        ////[OperationContract]
        ////Stack<Color> GetCollection(string[] people);

        //[OperationContract]
        //IEnumerable<Color> GetColors();
        #endregion

	    [OperationContract]
        IDictionary<string,int> GetDict(string key);
    }

   
  
    public class Color
    {
        public string Name { get; set; }
    }


}
