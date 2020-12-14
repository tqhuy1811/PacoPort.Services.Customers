using PacoPort.Services.Customers.Core.Entities;

namespace PacoPort.Services.Customers.Core.Events
{
	public class CustomerBecameVip : IDomainEvent
	{
		public Customer Customer { get; }

		public CustomerBecameVip(Customer customer)
		{
			Customer = customer;
		}
	}
}