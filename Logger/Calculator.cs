using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public class Calculator : ICalculator
    {
        public int Add(int first, int second) => first + second;
       

        public int Sub(int first, int second) => first - second;
        
    }
}
