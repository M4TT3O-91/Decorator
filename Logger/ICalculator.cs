using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public interface ICalculator
    {
        public int Add (int first, int second);
        public int Sub (int first, int second);
    }
}
