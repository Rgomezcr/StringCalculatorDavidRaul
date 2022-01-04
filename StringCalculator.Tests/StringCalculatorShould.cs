using System;
using Xunit;

namespace StringCalculator.Tests
{
    public class StringCalculatorShould
    {
        [Fact]
        public void ReturnZeroWhenInputIsEmpty()
        {
            Calculator calculator = new();
            
            Assert.Equal(0, calculator.Add(""));
        }

        [Theory]
        [InlineData("1",1)]
        [InlineData("10",10)]
        [InlineData("100",100)]
        public void ReturnNumberWithoutDelimiter(string numbers, int expected)
        {
            Calculator calculator = new();
            
            Assert.Equal(expected, calculator.Add(numbers));
        }
    }
}