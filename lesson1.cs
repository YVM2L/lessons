using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = 2013;
            if (2018 - year >= 18) {
                Console.WriteLine("Совершеннолетний");
            }
            else
            {
                Console.WriteLine("Несовершеннолетний");

            }


            int loading = 100;
            if (loading == 100)
            {
                Console.WriteLine("100%");
            }
            else
            {
                Console.WriteLine("не завершена");
            }
            int month = 2;
            switch (month)
            {
                case 1:
                    Console.WriteLine("январь");
                    break;
                case 2:
                    Console.WriteLine("февраль");
                    break;
                case 3:
                    Console.WriteLine("март");
                    break;
                case 4:
                    Console.WriteLine("апрель");
                    break;
                case 5:
                    Console.WriteLine("май");
                    break;
                default:
                    Console.WriteLine("такого месяца не существует");
                    break;
            }

            int n = 10;
            int[] array = new int[n];
            array[0] = 4;
            array[1] = 3;
            array[2] = 17;
            Console.WriteLine(array[2]);

            int[] array2 = { 1, 3, 5 };


            Console.Write(n);
            Console.WriteLine("любой текст");

            /*Console.WriteLine("введите текст");
            String s = Console.ReadLine();
            Console.WriteLine(s.ToUpper());

            /*
             *  год, номер которого кратен 400, — високосный;
                остальные годы, номер которых кратен 100, — невисокосные;
                остальные годы, номер которых кратен 4, — високосные.
             */

            year = 2016;
            if (year % 400 == 0)
            {
                Console.WriteLine("високосный");
            }
            else
            {
                if (year % 100 == 0)
                {
                    Console.WriteLine("невисокосный");
                }
                else
                {
                    if (year % 4 == 0)
                    {
                        Console.WriteLine("високосный");
                    }
                    else
                    {
                        Console.WriteLine("невисокосный");
                    }

                }
            }

            Console.ReadKey();
        }
    }
}
