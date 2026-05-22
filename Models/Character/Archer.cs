namespace Polymorphism.Models.Character;

class Archer : Character
{
	public override string Name { get; set; } = "Archer";

	public override void Attack()
	{
		Console.WriteLine($"{Name} shoots arrow");
	}
}