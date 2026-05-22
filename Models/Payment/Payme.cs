namespace Polymorphism.Models.Payment;

class Payme : Payment
{
	public override void Pay()
	{
		Console.WriteLine("Paid with Payme");
	}
}