namespace Polymorphism.Models.Device;

class Phone : Device
{
	public override void TurnOn()
	{
		Console.WriteLine("Phone is turning on");
	}
}