using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libofclass
{
    public class calculator
    {
        private int result;
        public void add(int a, int b)
        {
            result = a + b;
        }
        public void div(int a, int b)
        {    if (b == 0)
                throw new DivideByZeroException();

            result = a/b;
        }
        public int output()
        {
            return result;
        }

    }
}
