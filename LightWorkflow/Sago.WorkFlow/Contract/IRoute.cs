using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Sago.Framework.WorkFlow.Contract
{
	public interface IRoute
	{
		Expression<Func<IEnumerable<KeyValuePair<string, object>>, bool>> Expression { get; set; }

		IProcessNode NextProcessNode { get; set; }
	}
}
