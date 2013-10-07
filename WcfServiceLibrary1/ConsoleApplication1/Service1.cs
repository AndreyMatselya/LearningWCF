using System;
using System.Globalization;
using System.Threading;

namespace ConsoleApplication1
{
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
	public class Service1 : IService1
	{
		public string GetData(int value)
		{
			return string.Format("You entered: {0}", value);
		}

		public CompositeType GetDataUsingDataContract(CompositeType composite)
		{
			if (composite == null)
			{
				throw new ArgumentNullException("composite");
			}
			if (composite.BoolValue)
			{
				composite.StringValue += "Suffix";
			}
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
	}
}
