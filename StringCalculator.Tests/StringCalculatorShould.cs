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
        public void ReturnSumForMultiplesCommaSeparatedNumbers(string numbers, int expected)
        {
            Assert.Equal(expected, _calculator.Add(numbers));
        }

        [Theory]
        [InlineData("1,2\n3",6)]
        [InlineData("1\n2,3",6)]
        [InlineData("1\n2\n3",6)]
        public void ReturnSumForMultiplesDelimiters(string numbers, int expected)
        {
            Assert.Equal(expected, _calculator.Add(numbers));
        }

        [Theory]
        [InlineData("//;\n1;2",3)]
        [InlineData("//,\n1,2",3)]
        [InlineData("//@\n1@2",3)]
        public void ReturnSumForCustomDelimiter(string numbers, int expected)
        {
            Assert.Equal(expected, _calculator.Add(numbers));
        }

        [Theory]
        [InlineData("-1")]
        [InlineData("-1,1")]
        [InlineData("-1,-1")]
        [InlineData("//;\n-1;-1")]
        public void FailWhenInputHasNegativeNumbers(string numbers)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => _calculator.Add(numbers));
        } 
    }
}