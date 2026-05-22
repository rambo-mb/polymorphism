namespace Polymorphism.Models.Device;

class TV : Device
{
	public override void TurnOn()
	{
		Console.WriteLine("TV is turning on");
	}
}