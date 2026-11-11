
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void Add_TwoNumbers_ReturnsSum()
        {
            // Arrange
            Calculator calculator = new Calculator();
            int a = 10;
            int b = 5;

            // Act
            int result = calculator.Add(a, b);

            // Assert
            Assert.AreEqual(15, result);
        }

        [TestMethod]
        public void Subtract_TwoNumbers_ReturnsDifference()
        {
            // Arrange
            Calculator calculator = new Calculator();
            int a = 10;
            int b = 5;

            // Act
            int result = calculator.Subtract(a, b);

            // Assert
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void Multiply_TwoNumbers_ReturnsProduct()
        {
            // Arrange
            Calculator calculator = new Calculator();
            int a = 10;
            int b = 5;

            // Act
            int result = calculator.Multiply(a, b);

            // Assert
            Assert.AreEqual(50, result);
        }
        [TestMethod]
        public void divide_TwoNumbers_ReturnsProduct()
        {
            // Arrange
            Calculator calculator = new Calculator();
            int a = 10;
            int b = 5;

            // Act
            double result = calculator.Divide(a, b);

            // Assert
            Assert.AreEqual(2.0, result);
        }
    }
}
