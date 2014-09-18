using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sago.Framework.WorkFlow.Contract
{
	public interface IProcess
	{
		IEnumerable<IProcessNode> ProcessNodes { get; set; }

		IEnumerable<KeyValuePair<string, object>> BizContext { get; set; }
	}
}
