namespace Polymorphism.Models.Payment;

class Cash : Payment
{
	public override void Pay()
	{
		Console.WriteLine("Paid with Cash");
	}
}