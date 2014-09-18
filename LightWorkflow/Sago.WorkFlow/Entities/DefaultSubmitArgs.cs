using Sago.Framework.WorkFlow.Contract;

namespace Sago.Framework.WorkFlow.Entities
{
	public class DefaultSubmitArgs : ISubmitArgs
	{
		public ProcessAction ProcessAction { get; set; }
	}
}
