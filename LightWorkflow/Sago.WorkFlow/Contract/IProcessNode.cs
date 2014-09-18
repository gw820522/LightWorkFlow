using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sago.Framework.WorkFlow.Contract
{
	public interface IProcessNode
	{
		IProcess Process { get; set; }

		IEnumerable<IRoute> Routes { get; set; }
	}
}
