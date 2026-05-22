namespace Polymorphism.Models.Notification;

class Notification
{
	public virtual void Send()
	{
		Console.WriteLine("Send Notification");
	}
}