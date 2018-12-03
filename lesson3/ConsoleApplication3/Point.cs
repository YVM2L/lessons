using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Point
    {
        public int x;
        public int y;

        public Point() {}

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        // ((хА –  хВ)2 + (уА – уВ)2)
        public double distanceTo(Point p2)
        {
            double d = Math.Sqrt(Math.Pow(this.x - p2.x, 2) + Math.Pow(this.y -p2.y,2));
            return d;
        }
    }
}
