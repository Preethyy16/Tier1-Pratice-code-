using System;
namespace OCP.After;
public interface IDiscount
{
    double Apply(double amount);
}
public class RegularDiscount : IDiscount
{
    public double Apply(double amount) => amount * 0.10;
}
public class FestivalDiscount : IDiscount
{
    public double Apply(double amount) => amount * 0.20;
}
public class DiscountCalculator
{
    public double GetDiscount(IDiscount discount, double amount)
    {
        return discount.Apply(amount);
    }
}