using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public class CalculatorCasher : ICalculator
    {
        private ICalculator _calculator;
        private Dictionary<(int, int, method), int> _resultCasher = new Dictionary<(int, int, method), int>();

        enum method { sum, sub}

        public CalculatorCasher(ICalculator calculator) => _calculator = calculator;

        public int Add(int first, int second)
        {
            if (_resultCasher.ContainsKey((first, second, method.sum)))
                return _resultCasher[(first, second, method.sum)];
            
            var res = _calculator.Add(first, second);
            _resultCasher[(first, second, method.sum)] = res ;
            return res;
        }

        public int Sub(int first, int second)
        {
            if (_resultCasher.ContainsKey((first, second, method.sub)))
                return _resultCasher[(first, second, method.sub)];

            var res = _calculator.Sub(first, second);
            _resultCasher[(first, second, method.sub)] = res;
            return res;
        }
    }
}
