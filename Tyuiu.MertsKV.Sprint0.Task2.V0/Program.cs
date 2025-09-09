using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.MertsKV.Sprint0.Task2.V0.Lib;

namespace Tyuiu.MertsKV.Sprint0.Task2.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Вызов класса DataServise и метода GetMessange 
            // из биоблиотеки Tyuiu.MertsKV.Sprint0.Task2.V0.Lib
            Console.WriteLine(DataServise.GetMessange("Кристина"));
            Console.ReadKey();
            Console.ReadKey();
        }
    }
}
