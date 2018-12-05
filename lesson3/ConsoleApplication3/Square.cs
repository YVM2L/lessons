using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class SquareFigure: Figure
    {
        public double length;

        public double Square()
        {
            double s = Math.Pow(length, 2);
            return s;
        }
    }
}
