using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sago.Framework.WorkFlow.Contract;
using Sago.Framework.WorkFlow.Helper;

namespace Sago.Framework.WorkFlow
{
	internal class WorkflowEngine
	{
		internal void DoSubmit(IProcessNode processNode, ISubmitArgs submitArgs)
		{
			var process = processNode.Process;
			//if(process.BizContext.Contains<>)
			foreach (var route in processNode.Routes)
			{
				if (route.Expression.Compile().Invoke(process.BizContext))
				{

				}
			}
		}
	}
}
