using System;
namespace ISP.After;
public interface IRead
{
    void Read();
}
public interface IPlay
{
    void Play();
}
public class Humans : IRead, IPlay
{
    public void Read()
    {
        Console.WriteLine("Human Like Reading");
    }
    public void Play()
    {
        Console.WriteLine("Human Like Playing.");
    }
}
public class Animals : IPlay
{
    public void Play()
    {
        Console.WriteLine("Animals like playing with Humans.");
    }
}