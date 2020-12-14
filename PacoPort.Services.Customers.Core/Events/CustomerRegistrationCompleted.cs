using PacoPort.Services.Customers.Core.Entities;

namespace PacoPort.Services.Customers.Core.Events
{
	public class CustomerRegistrationCompleted : IDomainEvent
	{
		public Customer Customer { get; }

		public CustomerRegistrationCompleted(Customer customer)
		{
			Customer = customer;
		}
	}
}