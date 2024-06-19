// See https://aka.ms/new-console-template for more information
using Refactoring.Classes;

Console.WriteLine("Hello, World!");

NotificationSender notificationSender = new SmsErrorNotificationSender("0522XXXXXX","401");
notificationSender.Send("Hesaba giriş başarısız");