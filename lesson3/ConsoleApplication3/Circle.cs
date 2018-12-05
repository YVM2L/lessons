using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Circle: Figure
    {
        public double radius;
       

        public double Square()
        {
            double s = Figure.PI * Math.Pow(radius, 2);
            return s;
        }

    }
}
