using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai3array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6 };
            int[] newArray = new int[array.Length];
            for (int j = 0; j < array.Length; j++)
            {
                newArray[array.Length - 1 - j] = array[j];
            }
            int i = 0;
            while (i < newArray.Length)
            {
                Console.WriteLine($"{newArray[i]}");
                i++;
            }
            Console.ReadKey();
        }
    }
}
