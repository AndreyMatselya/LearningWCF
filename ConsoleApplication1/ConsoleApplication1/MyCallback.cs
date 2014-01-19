using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1.ServiceReference1;
using System.Windows.Forms;

namespace ConsoleApplication1
{
    public class MyCallback : IService1Callback
    {
        public void Callback()
        {
            MessageBox.Show("пришел");
        }
    }
}
