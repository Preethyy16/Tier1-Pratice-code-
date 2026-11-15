using System;
namespace DIP.After;
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
// Depends on the abstraction, injected through the constructor
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