using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sago.Framework.WorkFlow.Contract;

namespace UnitTestProject.ProcessNodes
{
	public class PaymentStartNode : IProcessNode
	{
		public IEnumerable<IRoute> Routes { get; set; }

		public IProcess Process
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}
	}
}
