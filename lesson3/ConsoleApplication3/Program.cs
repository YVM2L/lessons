using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Dog d1 = new Dog("rex", 4);
            d1.say();
            d1.sleep(5,6);
            d1.whatisyourname();

            Dog d2 = new Dog();

            Console.WriteLine(d1.name);
            d1.name = "22";
            Console.WriteLine(d1.name);
            Console.WriteLine(d1.age);
            Console.WriteLine(Dog.sound);
            Test();*/

            Point p1 = new Point(0, 2);
            Point p2 = new Point(3, 3);
            Console.WriteLine(p1.distanceTo(p2));
            Point3d p11 = new Point3d(0, 2, 2);
            Point3d p22 = new Point3d(3, 3, 3);
            
            Console.WriteLine(p11.distanceTo(p22));

            Circle c = new Circle();
            Console.WriteLine(c.Square());


            Console.ReadKey();
        }

        public static void Test()
        {

        }
    }
}
