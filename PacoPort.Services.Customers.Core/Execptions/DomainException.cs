using System;

namespace PacoPort.Services.Customers.Core.Execptions
{
	public abstract class DomainException : Exception
	{
		public virtual string Code { get; }

		protected DomainException(string message) : base(message)
		{
		}
	}
}