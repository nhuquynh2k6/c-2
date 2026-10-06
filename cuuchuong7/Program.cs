using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cuuchuong7
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 1; i <= 10; i++)
            //    Console.WriteLine($"7 * {i} = {7 * i}");
            //Console.ReadKey();

            //int i = 1;
            //while (i <= 10)
            //{
            //    Console.WriteLine($"{7} * {i} = {7 * i}");
            //    i++;
            //}
            //Console.ReadKey();

            int i = 1;
            do
            {
                Console.WriteLine($"{7} * {i} = {7 * i}");
                i++;
            }
            while (i <= 10);
            Console.ReadKey();
        }
    }
}
