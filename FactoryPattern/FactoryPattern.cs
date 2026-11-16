using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Pattern.FactoryPattern
{

    using System;

    namespace FactoryPattern
    {
        public interface IMessage
        {
            void Send();
        }

        public class Email : IMessage
        {
            public void Send()
            {
                Console.WriteLine("Email sent");
            }
        }

        public class SMS : IMessage
        {
            public void Send()
            {
                Console.WriteLine("SMS sent");
            }
        }

        // Factory class
        public class MessageFactory
        {
            public IMessage CreateMessage(string type)
            {
                if (type == "Email")
                {
                    return new Email();
                }
                else if (type == "SMS")
                {
                    return new SMS();
                }

                throw new ArgumentException("Invalid message type");
            }
        }

        public class Notification
        {
            private readonly IMessage _message;

            public Notification(IMessage message)
            {
                _message = message;
            }

            public void SendNotification()
            {
                _message.Send();
            }
        }  
    }
}