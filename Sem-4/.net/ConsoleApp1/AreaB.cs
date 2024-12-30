using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class AreaB
    {
        public int area(int x, int y)
        {
            return x * y;
        }

        public int area(int x)
        {
            return x * x;
        }

        public Double area(double x)
        {
            return 3.14 * x * x;
        }
    }
}
