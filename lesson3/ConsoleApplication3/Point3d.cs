using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Point3d: Point
    {
        public int z;

        public Point3d(int x, int y, int z)
        {
            this.x= x;
            this.y = y;
            this.z = z;
        }

        public double distanceTo(Point3d p2)
        {
            double d = Math.Sqrt(Math.Pow(this.x - p2.x, 2) + Math.Pow(this.y - p2.y, 2) + Math.Pow(this.z - p2.z, 2));
            return d;
        }
    }
}
