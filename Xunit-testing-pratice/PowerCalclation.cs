using System;
using System.Collections.Generic;
using System.Text;

namespace Xunit_testing_pratice
{
    public class Calculator
        {
            // Calculates the power of a given number
            public double CountPower(double number, int power)
            {
                if (power < 0)
                {
                    throw new ArgumentException("Power cannot be negative.");
                }

                double result = 1;

                for (int i = 1; i <= power; i++)
                {
                    result = result * number;
                }

                return result;
            }
        }
    

}
