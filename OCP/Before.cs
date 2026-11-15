using System;
namespace OCP.Before;
// Violates OCP: adding a new discount type means editing whole method
public class DiscountCalculator
{
    public double Calculate(string type, double amount)
    {
        if (type == "Regular")
            return amount * 0.10;
        if (type == "Festival")
            return amount * 0.20;
        return 0;
    }
}