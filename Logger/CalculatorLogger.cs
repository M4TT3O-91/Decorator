using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public class CalculatorLogger : ICalculator
    {
        private Calculator _calculator;

        public CalculatorLogger(Calculator calculator) => _calculator = calculator;

        public int Add(int first, int second)
        {
            var res = _calculator.Add(first, second);
            Console.WriteLine($"{first} + {second} = {res}");
            return res;
        }

        public int Sub(int first, int second)
        {
            var res = _calculator.Sub(first, second);
            Console.WriteLine($"{first} - {second} = {res}");
            return res;
        }
    }
}
