using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public class SafeCalculator:ICalculator
    {
        private Calculator _calculator;

        public SafeCalculator(Calculator calculator)
        {
            _calculator = calculator;
        }

        public int Add(int first, int second)
        {
            if (second == null) return 0;

            return _calculator.Add(first, second);
        }

        public int Sub(int first, int second)
        {
            var res = _calculator.Sub(first, second);
            Console.WriteLine($"{first} - {second} = {res}");
            return res;
        }
    }
}
