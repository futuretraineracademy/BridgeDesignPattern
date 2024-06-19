// See https://aka.ms/new-console-template for more information
using Bridge.Classes;

Console.WriteLine("Hello, World!");

NotificationSender notificationSender = new SmsSender(new ErrorNotification("401"), "0555XXXXX");
notificationSender.Send("Yetkişisiz erişim");

notificationSender = new EmailSender(new InfoNotification("200"), "futuretraineracademy@gmail.com");
notificationSender.Send("Yetkili erişim");