using System;
using System.Linq;

namespace StringCalculator
{
    public class Calculator
    {
        public int Add(string numbers)
        {
            if(string.IsNullOrEmpty(numbers))
                return 0;
            if (numbers.Contains(','))
            {
                return numbers.Split(',').Select(x => Int32.Parse(x)).Sum();
            }
                
            return Int32.Parse(numbers);
        }
    }
}