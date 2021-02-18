using System;
using Xunit;
using Calculator;

namespace Calculator
{
    public class CalculatorTest
    {
        private Calculator calculator = new Calculator();

        [Fact]
        public void CanAdd()
        {
            int result = calculator.Add(5, 3);

            Assert.Equal(8, result);
        }
        [Fact]
        public void CanSubtract()
        {
            int result = calculator.Subtract(5, 3);

            Assert.Equal(2, result);
        }
        [Fact]
        public void CanMultiply()
        {
            int result = calculator.Multiply(5, 3);

            Assert.Equal(15, result);
        }
        [Fact]
        public void CanDivide()
        {
            int result = calculator.Divide(6, 3);

            Assert.Equal(2, result);
        }

        [Fact]
        public void CanFibonacci()
        {
            int result = calculator.Fibonacci(5);

            Assert.Equal(5, result);
        }

        [Fact]
        public void IsPrime()
        {
            bool result = calculator.CheckPrime(17);

            Assert.True(result);
        }
    }
}
