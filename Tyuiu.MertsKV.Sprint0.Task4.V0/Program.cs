﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.MertsKV.Sprint0.Task4.V0.Lib;
namespace Tyuiu.MertsKV.Sprint0.Task4.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Пример линейной структуры программы 
            // Вызов методов сложения Addition 
            Console.WriteLine(DataServise.Addition(1, 5));

            Console.WriteLine(DataServise.Subtraction(15, 5));

            Console.WriteLine(DataServise.Multiplication(10, 10));

            Console.WriteLine(DataServise.Division(5, 5));

            Console.ReadKey();

        }
    }
}
