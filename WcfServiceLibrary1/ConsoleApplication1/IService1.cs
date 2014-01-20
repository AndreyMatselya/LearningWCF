using System.Runtime.Serialization;
using System.ServiceModel;

namespace ConsoleApplication1
{
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract(SessionMode = SessionMode.Allowed, CallbackContract = typeof(ISomeCallback))]
	public interface IService1
    {

        [OperationContract]
	    //[OperationContract(IsInitiating = false,IsTerminating = true)]
        void Connect();

        [OperationContract]
        //[OperationContract(IsInitiating = false,IsTerminating = true)]
        void Disconnect();


        [OperationContract]
       // [OperationContract(IsInitiating = true, IsTerminating = false)]
        void Init();
    }


    public interface ISomeCallback
    {
        [OperationContract]
        void Callback();
    }
   
    [DataContract]
    public class Color
    {
        [DataMember]
        public string Name { get; set; }
    }


}
