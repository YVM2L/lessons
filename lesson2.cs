using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int a = 20;
            while (a >= 10)
            {
                Console.WriteLine(a);
                a = a - 1;
            }

            int k = 0;
            do{
                Console.WriteLine(k * k);
                k = k + 1;

            }while (k < 5);

            float[] m = { 1.2f, 2.3f, 4.8f };
            
            float sum = 0;
            for (int i = 0; i < m.Length; i = i + 1) {
                sum = sum + m[i];
            } 
            Console.WriteLine(sum);

            foreach (float item in m) {
                Console.WriteLine(item * item);
            }
             
            Console.WriteLine("введите число от 1 до 9");
            String s = Console.ReadLine();
            int number = Convert.ToInt32(s);
            if (1 <= number && number <= 9)
            {
                for (int i = 1; i <= number; i = i + 1)
                {
                    for (int j = 1; j < 10; j = j + 1)
                    {
                        Console.Write(i);
                        Console.Write("x");
                        Console.Write(j);
                        Console.Write("=");
                        Console.WriteLine(i * j);
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("неверный ввод");
            }*/
            int c = Min(50, 10);
            Console.WriteLine(c);

            int[] array = { 1, 2, 3, 14, 5 };
            Print(array);

            Console.WriteLine();

            float[] array2 = { 1.2f, 4.4f, 4.1f };
            Print(array2);

            Console.ReadKey();
        }

        static int Min(int a, int b)
        {
            if (a < b)
            {
                return a;
            }
            else 
            {
                return b;
            }
        }

        static void Print(int[] array) 
        {
            foreach (int a in array)
            {
                Console.Write(a);
                Console.Write(",");
            }
        }

        static void Print(float[] array)
        {
            for (int i = 0; i < array.Length; i = i + 1)
            {
                Console.Write(array[i]);
                if (i < array.Length - 1)
                {
                    Console.Write(",");
                }
            }

        }
    }
}
