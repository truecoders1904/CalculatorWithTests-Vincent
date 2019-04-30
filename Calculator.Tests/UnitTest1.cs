using System;
using Xunit;

namespace CalculatorWithTests.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(10, 7, 17)]
        [InlineData(100, 75, 175)]
        [InlineData(1, 1, 2)]
        [InlineData(10, 15, 25)]
        [InlineData(0, 7, 7)]
        [InlineData(0, 0, 0)]
        [InlineData(-5, 5, 0)]
        [InlineData(-10, -7, -17)]
        [InlineData(-10, -15, -25)]
        public void Add(int addend1, int addend2, int expectedSum)
        {
            // Arrange
            Calculator challenger = new Calculator();

            // Act
            int actual = challenger.Add(addend1, addend2);

            // Assert
            Assert.Equal(expectedSum, actual);
        }

        [Theory]
        [InlineData(10, 7, 3)]
        [InlineData(100, 75, 25)]
        [InlineData(1, 1, 0)]
        [InlineData(10, 15, -5)]
        [InlineData(0, 7, -7)]
        [InlineData(0, 0, 0)]
        [InlineData(-5, 5, -10)]
        [InlineData(-10, -7, -3)]
        [InlineData(-10, -15, 5)]
        [InlineData(5.5, 1.2, 4.3)]
        [InlineData(0.7, 0.35, 0.35)]
        [InlineData(-2.2, 1.1, -3.3)]
        public void Subtract(double minuend, double subtrahend, double expectedDifference)
        {
            // Arrange
            Calculator challenger = new Calculator();

            // Act
            double actual = challenger.Subtract(minuend, subtrahend);

            // Assert
            Assert.Equal(Math.Round(expectedDifference, 2), Math.Round(actual, 2));
        }

        [Theory]
        [InlineData(10, 7, 70)]
        [InlineData(100, 75, 7500)]
        [InlineData(1, 1, 1)]
        [InlineData(10, 15, 150)]
        [InlineData(0, 7, 0)]
        [InlineData(0, 0, 0)]
        [InlineData(-5, 5, -25)]
        [InlineData(-10, -7, 70)]
        [InlineData(-10, -15, 150)]
        [InlineData(1234567, 7654321, 9449772114007)]
        [InlineData(1234567, -7654321, -9449772114007)]
        public void Multiply(long factor1, long factor2, long product)
        {
            // Arrange
            Calculator challenger = new Calculator();

            // Act
            long actual = challenger.Multiply(factor1, factor2);

            // Assert
            Assert.Equal(product, actual);
        }

        [Theory]
        [InlineData(10, 7, 3.33)]
        [InlineData(100, 75, 1.33)]
        [InlineData(1, 1, 1)]
        [InlineData(10, 15, .66)]
        [InlineData(0, 7, 0)]
        [InlineData(0, 0, 0)]
        [InlineData(-5, 5, 1)]
        [InlineData(-10, -7, 1.42)]
        [InlineData(-10, -15, .66)]
        [InlineData(5.5, 1.2, 4.58)]
        [InlineData(0.7, 0.35, 2)]
        [InlineData(-2.2, 1.1, -2)]
        public void Divide(double num1, double num2, double Sum)
        {
            // Arrange
            Calculator challenger = new Calculator();

            // Act
            double actual = challenger.Divide(num1, num2);

            // Assert
            Assert.Equal(Sum, actual);
        }

        [Theory]
        [InlineData(2, 1, 2)]
        [InlineData(0, 0, 0)]                     
        public void Factorial(double recursive, double recursive2, double recrusiveSum)
        {
            // Arrange
            Calculator challenger = new Calculator();

            // Act
            double actual = challenger.Factorial(recursive, recursive2);

            // Assert
            Assert.Equal(recrusiveSum, actual);
        }
    }
}
