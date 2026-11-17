using System;
using System.Collections.Generic;
using System.Text;
using Xunit_testing_pratice;

namespace CountPower.Tests
{
    public class PowerCountTesting
    {
        [Fact]
        public void Power_Result_Validation()
        {
            // Arrange
            var calculator = new Calculator();
            double expected = 27;

            // Act
            double actual = calculator.CountPower(3, 3);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Power_Negative_Throws_Exception()
        {
            var calculator = new Calculator();

            Assert.Throws<ArgumentException>(() => calculator.CountPower(2, -1));
        }

    }
}
