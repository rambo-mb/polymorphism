namespace Polymorphism.Models.Device;

class Laptop : Device
{
	public override void TurnOn()
	{
		Console.WriteLine("Laptop is turning on");
	}
}