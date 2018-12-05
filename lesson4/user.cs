using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class user
    {
        public String name;
        public int age;

        public bool Equals(object obj)
        {
            user u = (user) obj;
            if ( u.age == age && u.name == name)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string ToString()
        {
            return String.Format("Name: {0}, age: {1}", name, age);
        }
    }
}
