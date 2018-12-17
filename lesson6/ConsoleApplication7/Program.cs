using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void f1()
        {
            for (int i = 500000; i < 1000000 ; i = i + 1)
            {
                double d = Math.Cos(i * 10) * Math.Sqrt(i / 2) + Math.Sinh(i + i);
            }
        }
        static void Main(string[] args)
        {
            /*Stopwatch sw = new Stopwatch();
            Thread t1 = new Thread(f1);
            

            sw.Start();
            
            t1.Start();
            
            for (int i = 0; i < 500000; i = i + 1)
            {
                double d = Math.Cos(i * 10) * Math.Sqrt(i / 2) + Math.Sinh(i + i);
            }

            t1.Join();

            sw.Stop();



            Console.WriteLine(sw.ElapsedMilliseconds);
            List<int> collection = new List<int>();
            collection.Add(10);
            collection.Add(8);
            collection.Add(-4);
            Print(collection);

            collection.Remove(8);
            Print(collection);



            Console.ReadKey();
        }
        static void Print(List<int>values)
        {
            foreach(int v in values){
                Console.Write(v);
                Console.Write(" ");
            }
            Console.WriteLine();*/
            Dictionary<String, int> marks = new Dictionary<String, int>();
            marks.Add("Петров", 5);
            marks.Add("Сидоров", 4);
            marks.Add("Зайцев", 5);
            Console.WriteLine(marks["Сидоров"]);


            int m = max(2, 7, 4);
            Console.WriteLine(m);
            Console.ReadKey();

            // 1. Просмотреть список дел (1. Позвонить сестре - ок, 2. Купить молоко - не ок)
            // 2. Добавить дело
            // 3. Завершить дело
            // 4. Выход
        }


        static int max(int a, int b, int c)
        {
            if (a < b) 
            {
                a = b;
            }

            if (a < c)
            {
                return c;
            }
            else 
            {
                return a;
            }
        }
    } 
}
