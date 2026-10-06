using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[2];
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Nhap vao so thu {i+1}: ");
                array[i] = int.Parse(Console.ReadLine());
                sum = sum + array[i];
            }
            Console.WriteLine(sum.ToString());
            Console.ReadKey();
        }
    }
}
