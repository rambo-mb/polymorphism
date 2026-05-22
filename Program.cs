using Polymorphism.Models.Shape;
using Polymorphism.Models.Notification;
using Polymorphism.Models.Payment;
using Polymorphism.Models.Character;
using Polymorphism.Models.Device;

// 1-TASK — Shape System
Shape s1 = new Circle();
Shape s2 = new Rectangle();
Shape s3 = new Triangle();

s1.Draw();
s2.Draw();
s3.Draw();

// 2-TASK — Notification System
Notification email = new EmailNotification();
Notification phone = new PhoneNotification();
Notification telegram = new TelegramNotification();

email.Send();
phone.Send();
telegram.Send();

// 3-TASK — Payment System
Payment click = new Click();
Payment payme = new Payme();
Payment cash = new Cash();

click.Pay();
payme.Pay();
cash.Pay();

// 4-TASK — Game Characters
Character warrior = new Warrior();
Character archer = new Archer();
Character mage = new Mage();

warrior.Attack();
archer.Attack();
mage.Attack();

// 5-TASK — Smart Devices
Device smartphone = new Phone();
Device laptop = new Laptop();
Device tv = new TV();

smartphone.TurnOn();
laptop.TurnOn();
tv.TurnOn();