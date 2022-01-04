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

        [Fact]
        public void ReturnNumberWithoutDelimiter()
        {
            Calculator calculator = new();
            
            Assert.Equal(1, calculator.Add("1"));
        } 
    }
}