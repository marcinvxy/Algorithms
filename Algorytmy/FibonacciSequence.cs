using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorytmy
{
    class FibonacciSequence
    {
        public long iteration(int f)
        {
            if (f == 1)
            {
                return 0;
            }
            else if (f == 2)
            {
                return 1;
            }
            else if (f == 3)
            {
                return 1;
            }
            else
            { 
                long a = 0;
                long b = 1;
                long c = 0;
                for (int i = 0; i < f - 2; i++)
                {
                    c = a + b;
                    a = b;
                    b = c;
                }
                return c;
            }
        }

        public long recursion(int f)
        {
            if (f == 1)
                return 0;
            if (f == 2)
                return 1;
            if (f < 4 && f > 1)
                return 1;
            else
                return recursion(f - 1) + recursion(f - 2);
        }
    }
}