using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ConsoleApplication1.ServiceReference1;
using System.Windows.Forms;

namespace ConsoleApplication1
{
    [CallbackBehavior(IncludeExceptionDetailInFaults = true)]
    public class MyCallback : IService1Callback
    {
        public void Callback()
        {
            Console.Write("Потомк №{0}\n", Thread.CurrentThread.ManagedThreadId);
            throw new MyExceptionEpt("Хуета");
        }
    }

  

    [Serializable]
    public class MyExceptionEpt : Exception
    {
        public MyExceptionEpt()
        {
        }

        public MyExceptionEpt(string message) : base(message)
        {
        }

        public MyExceptionEpt(string message, Exception inner) : base(message, inner)
        {
        }

        protected MyExceptionEpt(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context)
        {
        }
    }

}
