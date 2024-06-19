using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Classes
{
    public abstract class NotificationSender
    {
        protected INotification notification;

        protected NotificationSender(INotification notification)
        {
            this.notification = notification;
        }

        public abstract void Send(string message);
    }
    public class SmsSender : NotificationSender
    {
        private string _phone;

        public SmsSender(INotification notification, string phone) : base(notification)
        {
            _phone = phone;
        }

        public override void Send(string message)
        {
            Console.WriteLine($"{notification.GetContent(message)} mesajı");
            Console.WriteLine($"{_phone} numarasına gönderildi.");
        }
    }
    public class EmailSender : NotificationSender
    {
        private string _email;
        public EmailSender(INotification notification, string email) : base(notification)
        {
            _email = email;
        }

        public override void Send(string message)
        {
            Console.WriteLine($"{notification.GetContent(message)} mesajı");
            Console.WriteLine($"{_email} sınıfına gönderildi.");
        }
    }


    public interface INotification
    {
        string GetContent(string message);
    }
    public class ErrorNotification : INotification
    {
        private string _errorCode;

        public ErrorNotification(string errorCode)
        {
            _errorCode = errorCode;
        }

        public string GetContent(string message)
        {
            return $"Error Code : {_errorCode}, Message : {message}";
        }
    }
    public class InfoNotification : INotification
    {
        private string _infoCode;

        public InfoNotification(string infoCode)
        {
            _infoCode = infoCode;
        }

        public string GetContent(string message)
        {
            return $"Error Code : {_infoCode}, Message : {message}";
        }
    }
}
