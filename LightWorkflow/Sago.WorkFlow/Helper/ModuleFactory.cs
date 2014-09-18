using Sago.Framework.WorkFlow.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sago.Framework.WorkFlow.Helper
{
	public static class ModuleFactory
	{
		public static IEnumerable<IProcessModule> Modules { get; set; }
	}
}
