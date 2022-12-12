﻿using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
            Task7();

        }

        #region Task1 
        // Написать метод, рассчитывающий число из рада Фиббоначчи используя
        // рекурсию
        // 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584, 4181, 6765, 10946, 17711, …

        static void Task1()
        {
            System.Console.WriteLine("Task1");
            int n = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine(NumberFB(n));
        }

        static int NumberFB(int n)
        {
            if (n <= 1) { return n; }
            return NumberFB(n - 2) + NumberFB(n - 1);
        }
        #endregion
        #region Task2
        //Дано натуральное число (вводится с клавиатуры). Вычислите сумму его цифр
        // используя рекурсию
        static void Task2()
        {
            System.Console.WriteLine("Task2");
            int number = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine(SumNumber(number));
        }
        static int SumNumber(int number)
        {

            int sum = 0;
            if (number == 0)
            {
                return sum;
            }
            sum = number % 10 + SumNumber(number / 10);
            return sum;
        }
        #endregion
        #region Task7
        static void Task7()
        {
            System.Console.WriteLine("Task7");
            string? text = Console.ReadLine();
            string? symbol = Console.ReadLine();
            if (!string.IsNullOrEmpty(text) && !string.IsNullOrEmpty(symbol))
            {
                Console.WriteLine(MethodAllSearch(text, symbol));
            }
            else
            {
                Console.WriteLine("error");
            }
        }

        static (string, int, int, int) MethodAllSearch(string text, string symbol)
        {
            int count = 0;
            int indexFirst = -1;
            int indexLast = -1;
            int LengthSymbol = symbol.Length;
            for (int i = 0; i <= text.Length - LengthSymbol; i++)
            {
                string temp = "";
                for (int j = i; j <= i + (LengthSymbol - 1); j++)
                {
                    temp += text[j];
                }
                if (temp == symbol)
                {
                    if (indexFirst == -1)
                    {
                        indexFirst = i;
                    }
                    indexLast = i;
                    count++;
                }
            }
            return (symbol, count, indexFirst, indexLast);
        }
        #endregion
        #region Task3 
        //     Дано натуральное число больше 1 (вводится с Выведите все простые
        // делители этого числа используя рекурсию
        static void Task3()
        {
            System.Console.WriteLine("Task3");
            int number = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            System.Console.WriteLine(SearchSimpleNumber(ref number, ref count));
        }
        static int SearchSimpleNumber(ref int number, ref int count)
        {

            if (number > 1 && count == 0)
            {
                count++;
                System.Console.WriteLine(1);
                return SearchSimpleNumber(ref number, ref count);
            }
            if (number % 2 == 0)
            {
                number = number / 2;
                count++;
                System.Console.WriteLine(2);
                return SearchSimpleNumber(ref number, ref count);
            }
            if (number % 3 == 0)
            {
                number = number / 3;
                count++;
                System.Console.WriteLine(3);
                return SearchSimpleNumber(ref number, ref count);
            }
            if (number % 5 == 0)
            {
                number = number / 5;
                count++;
                System.Console.WriteLine(5);
                return SearchSimpleNumber(ref number, ref count);
            }
            if (number % 7 == 0)
            {
                number = number / 7;
                count++;
                System.Console.WriteLine(7);
                return SearchSimpleNumber(ref number, ref count);
            }
            return count;
        }
        #endregion
    }
}





