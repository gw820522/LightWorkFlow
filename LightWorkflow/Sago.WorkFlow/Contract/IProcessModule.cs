using Sago.Framework.WorkFlow.Entities;

namespace Sago.Framework.WorkFlow.Contract
{
	public interface IProcessModule
	{
		void OnApproved(ProcessNodeEventArgs processNodeEventArgs);
	}
}
