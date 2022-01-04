using System;
using System.Collections.Generic;
using System.Linq;

namespace StringCalculator
{
    public class Calculator
    {
        public int Add(string numbers)
        {
            if(string.IsNullOrEmpty(numbers))
                return 0;
            List<char> delimiters = new();
            delimiters.Add(',');
            delimiters.Add('\n');
            
            if (numbers.StartsWith("//"))
            {
                delimiters.Add(numbers[2]);
                numbers = numbers.Substring(4);
            }

            var delimiterArray = delimiters.ToArray();
            if (numbers.IndexOfAny(delimiterArray) != -1)
            {
                return numbers.Split(delimiterArray, StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => Int32.Parse(x))
                    .Sum();
            }
                
            return Int32.Parse(numbers);
        }
    }
}