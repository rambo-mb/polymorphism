namespace Polymorphism.Models.Character;

class Mage : Character
{
	public override string Name { get; set; } = "Mage";

	public override void Attack()
	{
		Console.WriteLine($"{Name} casts spell");
	}
}