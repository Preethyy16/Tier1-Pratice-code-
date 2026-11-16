using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Pattern.StratergyPattern
{
    public interface IGradeStrategy
    {
        void CalculateGrade();
    }

    public class PercentageGrade : IGradeStrategy
    {
        public void CalculateGrade()
        {
            Console.WriteLine("Calculating percentage grade");
        }
    }

    public class PassFailGrade : IGradeStrategy
    {
        public void CalculateGrade()
        {
            Console.WriteLine("Calculating pass/fail grade");
        }
    }

    public class GradeCalculator
    {
        private IGradeStrategy _strategy;

        public GradeCalculator(IGradeStrategy strategy)
        {
            _strategy = strategy;
        }

        public void Calculate()
        {
            _strategy.CalculateGrade();
        }
    }

}
