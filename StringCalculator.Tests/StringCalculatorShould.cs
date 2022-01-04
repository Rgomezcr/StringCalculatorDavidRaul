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

        [Theory]
        [InlineData("1,2",3)]
        [InlineData("10,20",30)]
        [InlineData("101,201,111",413)]
        public void ReturnThreeForOneAndTwo(string numbers, int expected)
        {
            Assert.Equal(expected, _calculator.Add(numbers));
        } 
    }
}