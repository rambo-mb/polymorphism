namespace Polymorphism.Models.Character;

class Character
{
	public virtual string Name { get; set; } = "Character";

	public virtual void Attack()
	{
		Console.WriteLine($"{Name} attacks with hands");
	}
}