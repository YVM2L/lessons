using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int[] array = new int[3];
            int c = 0;
            try
            {
                array[0] = 1;
                throw new Exception("i am exception");
                array[3] = 2;
                array[1] = 3;
            }
            catch (System.IndexOutOfRangeException e)
            {
                Console.WriteLine("ошибка");
            }
            catch (System.DivideByZeroException u)
            {
                Console.WriteLine("деление на 0");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            for (int i = 0; i < array.Length; i = i + 1)
            {
                Console.WriteLine(array[i]);
            }*/

            Account a = new Account(100, 4354);

            for (int i = 3; i > 0; i = i - 1)
            {
                Console.Clear();
                Console.WriteLine("Введите пин-код");
                String h = Console.ReadLine();
                try
                {
                    int j = int.Parse(h);
                    if (a.checkpin(j))
                    {
                        break;
                    }
                    else
                    {
                        if (i == 1)
                        {
                            return;
                        }

                        Console.WriteLine("Неверный пин-код");
                        Console.Write("У вас осталось ");
                        Console.Write(i - 1);
                        Console.Write(" попыток");
                        Console.ReadKey();
                    }
                }
                catch (Exception ex)
                {
                    if (i == 1)
                    {
                        return;
                    }

                    Console.WriteLine(ex.Message);
                    Console.Write("У вас осталось ");
                    Console.Write(i - 1);
                    Console.Write(" попыток");
                    Console.ReadKey();
                }
            }

            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. Посмотреть баланс");
                Console.WriteLine("2. Снять сумму");
                Console.WriteLine("3. Пополнить счет");
                Console.WriteLine("4. Выход");
                Console.Write("Выбор ");
                ConsoleKeyInfo l = Console.ReadKey();
                Console.WriteLine();

                if (l.KeyChar == '1')
                {
                    Console.Write("Ваш баланс: ");
                    Console.WriteLine(a.balance);
                    Console.WriteLine("Для продолжения нажмите клавишу");
                    Console.ReadKey();
                }
                else if (l.KeyChar == '2')
                {
                    Console.WriteLine("Введите сумму");
                    String s = Console.ReadLine();
                    try
                    {
                        float b = float.Parse(s);
                        a.balance = a.balance - b;
                    }
                    catch (System.FormatException e)
                    {
                        Console.WriteLine("Сумма указана неверно");
                    }
                    catch (Exception k)
                    {
                        Console.WriteLine(k.Message);
                    }

                    Console.Write("Ваш баланс: ");
                    Console.WriteLine(a.balance);
                    Console.WriteLine("Для продолжения нажмите клавишу");
                    Console.ReadKey();

                }
                else if (l.KeyChar == '3')
                {
                    break;
                }
                else
                {
                    Console.WriteLine("неверный выбор");
                    Console.ReadKey();
                }

            }
        }
    }
}