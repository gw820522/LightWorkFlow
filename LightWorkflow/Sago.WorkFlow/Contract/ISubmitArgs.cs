using Sago.Framework.WorkFlow.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sago.Framework.WorkFlow.Contract
{
	public interface ISubmitArgs
	{
		ProcessAction ProcessAction { get; set; }
	}
}
