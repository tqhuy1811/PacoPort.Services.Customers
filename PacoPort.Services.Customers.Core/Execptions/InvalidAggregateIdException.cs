namespace PacoPort.Services.Customers.Core.Execptions
{
	public class InvalidAggregateIdException : DomainException
	{
		public override string Code { get; } = "invalid_aggregate_id";

		public InvalidAggregateIdException() : base($"Invalid aggregate id.")
		{
		}
	}
}