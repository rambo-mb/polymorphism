namespace Polymorphism.Models.Payment;

class Click : Payment
{
	public override void Pay()
	{
		Console.WriteLine("Paid with Click");
	}
}