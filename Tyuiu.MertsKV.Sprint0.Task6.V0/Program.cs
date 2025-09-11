using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.MertsKV.Sprint0.Task6.V0.Lib;

namespace Tyuiu.MertsKV.Sprint0.Task6.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numsArray = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Сумма элементов массива = " + DataServise.AdditionArray(numsArray));
            Console.WriteLine("Разность элементов массива = " + DataServise.SubtractionArray(numsArray));
            Console.WriteLine("Произведение элементов массива = " + DataServise.MultiplicationArray(numsArray));
            Console.ReadKey();
        }
    }
}
