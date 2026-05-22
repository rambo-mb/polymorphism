namespace Polymorphism.Models.Notification;

class TelegramNotification : Notification
{
	public override void Send()
	{
		Console.WriteLine(
			"""
			=============================
			[TELEGRAM NOTIFICATION]
			User: @rambo_mb
			Message: Salom! To'lovni vaqtida amalga oshiring.
			Status: Telegramga jo'natildi 🚀
			"""
		);
	}
}