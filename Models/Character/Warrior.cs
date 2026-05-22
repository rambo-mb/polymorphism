namespace Polymorphism.Models.Character;

class Warrior : Character
{
	public override string Name { get; set; } = "Warrior";

	public override void Attack()
	{
		Console.WriteLine($"{Name} attacks with sword");
	}
}