namespace Polymorphism.Models.Notification;

class EmailNotification : Notification
{
	public override void Send()
	{
		Console.WriteLine(
			"""
			=============================
			[EMAIL NOTIFICATION]
			To: nodirkhan@gmail.com
			Subject: Polymorphism topshiriqlari
			Body: Nodirkhan ustoz vazifalar bajarildi.
			Status: Email muvaffaqiyatli yuborildi ✅
			"""
		);
	}
}