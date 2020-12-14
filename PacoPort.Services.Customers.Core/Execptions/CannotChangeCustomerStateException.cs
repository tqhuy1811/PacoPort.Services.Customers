using System;
using PacoPort.Services.Customers.Core.Entities;

namespace PacoPort.Services.Customers.Core.Execptions
{
	public class CannotChangeCustomerStateException : DomainException
	{
		public override string Code { get; } = "cannot_change_customer_state";
		public Guid Id { get; }
		public State State { get; }

		public CannotChangeCustomerStateException(Guid id, State state) : base(
			$"Cannot change customer: {id} state to: {state}.")
		{
			Id = id;
			State = state;
		}
	}
}