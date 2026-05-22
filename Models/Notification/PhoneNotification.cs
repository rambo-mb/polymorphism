namespace Polymorphism.Models.Notification;

class PhoneNotification : Notification
{
	public override void Send()
	{
		Console.WriteLine(
			"""
			=============================
			[PHONE NOTIFICATION]
			Phone: +998909841999
			Message: Darsga kech qolmang.
			Status: SMS yuborildi 📱
			"""
		);
	}
}