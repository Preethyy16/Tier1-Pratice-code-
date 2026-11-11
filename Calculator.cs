using System;

public class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Subtract(int a, int b)
    {
        return a - b;
    }

    public int Multiply(int a, int b)
    {
        return a * b;
    }

    public double Divide(int a, int b)
    {
        try
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }

            return (double)a / b;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            throw;
        }
    }


}

