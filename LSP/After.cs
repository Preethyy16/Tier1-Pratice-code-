using System;
namespace LSP.After;
public class Person
{
    public void Runing()
    {
        Console.WriteLine("Person is Runing.");
    }
}
public interface IFlyingBird
{
    void Fly();
}

public class Crow : Person, IFlyingBird
{
    public void Fly()
    {
        Console.WriteLine("Crow is Running.");
    }
}