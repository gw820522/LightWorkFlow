using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sago.Framework.WorkFlow.Contract;
using System.Linq.Expressions;

namespace Sago.Framework.WorkFlow.Entities
{
	public class DefaultRoute : IRoute
	{
		public Expression<Func<IEnumerable<KeyValuePair<string, object>>, bool>> Expression { get; set; }

		public IProcessNode NextProcessNode { get; set; }
	}
}
