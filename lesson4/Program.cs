using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*user u = null;
            u.name = "swaf";*/

            /*book b;
            b.title = "asf";*/


            user u1 = new user();
            u1.name = "123";
            u1.age = 12;
            user u2 = new user();
            u2.name = "123";
            u2.age = 12;
           
            Console.WriteLine(u1.ToString());


            String s = "hello, {{username}}. Welcome ...";
            Console.WriteLine(s.Contains("hel"));
            Console.WriteLine(s.IndexOf('l'));
            Console.WriteLine(s.Remove(2, 2));
            Console.WriteLine(s.Replace("{{username}}", "Vasyan"));
            char[] p = { ',', '.', ' ', ':' };
            String[] words = s.Split(p);
            for (int i = 0; i < words.Length; i = i + 1) {
                Console.WriteLine(words[i]);
            }
            Console.WriteLine(s.ToUpper());

            // HOMEWORK
            String message = "Ты дурак. ДуРаК!!! а я не дурак";

            String editedMessage = ""; // Ты ***. ***!!! а я не ***
            Console.WriteLine(editedMessage);


            Console.ReadKey();
        }
    }
}
