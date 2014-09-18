using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sago.Framework.WorkFlow.Contract;

namespace UnitTestProject.Process
{
	public class PaymentProcess : IProcess
	{
		public PaymentProcess()
		{
			this.BizContext = new Dictionary<string, object>() 
			{ 
				{"NeedInternal",true},
				{"NeedQuotation",true}
			};
		}

		public IEnumerable<IProcessNode> ProcessNodes { get; set; }

		public IEnumerable<KeyValuePair<string, object>> BizContext { get; set; }
	}
}
