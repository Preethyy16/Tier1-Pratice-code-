using System;
namespace LSP.Before;
public class Person
{
    public virtual void Eating()
    {
        Console.WriteLine("Human is Eating.");
    }
}
public class Eagle : Person
{
    public override void Eating()
    {
        Console.WriteLine("Eagle is Eating.");
    }
}
public class PlaticToy : Person
{
    public override void Eating()
    {
        throw new Exception("Platic Toy cannot Eat.");
    }
}