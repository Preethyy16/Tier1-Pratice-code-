using System;
namespace DIP.Before;
public class Email
{
    public void Send()
    {
        Console.WriteLine("Email sent");
    }
}
// Violates DIP: depends directly on the  Email class
public class Notification
{
    public void SendNotification()
    {
        Email email = new Email();
        email.Send();
    }
}