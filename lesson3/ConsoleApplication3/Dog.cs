using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Dog: Pet
    {
        public Dog() {
            Console.WriteLine("dog object was created");
        }

        public Dog(String name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public new void say()
        {
            base.say();
            Console.WriteLine(sound);
        }

        public static String sound = "haw-haw";

        public void sleep(int hours)
        {
            Console.WriteLine("dog was sleep on " + hours + " hours");
        }
        public void sleep(int hours, int minutes)
        {
            Console.WriteLine("dog was sleep on " + hours + " hours and "+minutes+" minutes");
        }

        public void whatisyourname()
        {
            Console.WriteLine("my name is " + name);
        }

    }
}
