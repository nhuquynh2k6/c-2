using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int[] array = new int[] { 1, 2, 3, 4, 5, 6 };
            while (i < array.Length)
            {
                Console.Write($"{array[i]+" "}");
                i++;
            }
            Console.ReadKey();
        }
    }
}
