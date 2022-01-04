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
                var splitNumbers = numbers.Split(delimiterArray, StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => Int32.Parse(x));
                var negativesNumbers = new List<int>();
                var sum = 0;
                foreach (var number in splitNumbers)
                {
                    if (number < 0)
                    {
                        negativesNumbers.Add(number);
                        continue;
                    }

                    sum += number;

                }

                if (negativesNumbers.Count > 0) 
                    throw new ArgumentOutOfRangeException($"Negatives not allowed {negativesNumbers}");

                return sum;
            }
                
            return Int32.Parse(numbers) < 0 ?  throw new ArgumentOutOfRangeException($"Negatives not allowed {numbers}") : Int32.Parse(numbers);
        }
    }
}