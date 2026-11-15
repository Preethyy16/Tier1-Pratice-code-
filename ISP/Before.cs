using System;

namespace ISP.Before;
// Violates ISP: one fat interface forces every worker to implement Eat()
public interface IPerson
{
    void Read();
    void Play();
}
public class HumanWorker : IPerson
{
    public void Read()
    {
        Console.WriteLine("Human is Reading.");
    }

    public void Play()
    {
        Console.WriteLine("Human is Playing.");
    }
}
public class Animal : IPerson
{
    public void Play()
    {
        Console.WriteLine("Animal is playing.");
    }
    public void Read()
    {
        throw new NotImplementedException();
    }
}