using System;
using Xunit;

namespace StringCalculator.Tests
{
    public class StringCalculatorShould
    {
        Calculator _calculator = new();
        
        [Fact]
        public void ReturnZeroWhenInputIsEmpty()
        {
            Assert.Equal(0, _calculator.Add(""));
        }

        [Theory]
        [InlineData("1",1)]
        [InlineData("10",10)]
        [InlineData("100",100)]
        public void ReturnNumberWithoutDelimiter(string numbers, int expected)
        {
            Assert.Equal(expected, _calculator.Add(numbers));
        }

        [Fact]
        public void ReturnThreeForOneAndTwo()
        {
            Assert.Equal(3, _calculator.Add("1,2"));
        } 
    }
}