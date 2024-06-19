using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring.Classes
{
    public abstract class NotificationSender
    {
        public abstract void Send(string message);
    }
    public class SmsNotificationSender : NotificationSender
    {
        protected string _phone;
        public SmsNotificationSender(string phone)
        {
            _phone = phone;
        }
        public override void Send(string message)
        {

        }
    }
    public class SmsErrorNotificationSender : SmsNotificationSender
    {
        private string _errorCode;
        public SmsErrorNotificationSender(string phone, string errorCode) : base(phone)
        {
            _errorCode = errorCode;
        }
        public override void Send(string message)
        {
            Console.WriteLine($"Error Code {_errorCode}, Message {message}");
            Console.WriteLine($"{_phone} telefon numarasına sms gönderildi.");

        }
    }
    public class SmsInfoNotificationSender : SmsNotificationSender
    {
        private string _infoCode;
        public SmsInfoNotificationSender(string phone, string infoCode) : base(phone)
        {
            _infoCode = infoCode;
        }
        public override void Send(string message)
        {
            Console.WriteLine($"Bilgi Kodu : {_infoCode}, Mesaj : {message}");
            Console.WriteLine($"{_phone} telefon numarasına sms gönderildi.");

        }
    }

    public class EmailNotificationSender : NotificationSender
    {
        protected string _email;
        public EmailNotificationSender(string email)
        {
            _email = email;
        }
        public override void Send(string message)
        {

        }
    }
    public class EmailErrorNotificationSender : SmsNotificationSender
    {
        private string _errorCode;
        public EmailErrorNotificationSender(string email, string errorCode) : base(email)
        {
            _errorCode = errorCode;
        }
        public override void Send(string message)
        {
            
        }
    }
    public class EmailInfoNotificationSender : SmsNotificationSender
    {
        private string _infoCode;
        public EmailInfoNotificationSender(string email, string infoCode) : base(email)
        {
            _infoCode = infoCode;
        }
        public override void Send(string message)
        {
           
        }
    }
}
