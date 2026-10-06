using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5sotunhiendautien
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine("i=" + i);
            //}
            //Console.ReadKey();

            //int i = 1;
            //while (i <= 5)
            //{
            //    Console.WriteLine("i=" + i);
            //    i++;
            //}
            //Console.ReadKey();

            //int i = 1;
            //do
            //{
            //    Console.WriteLine("i=" + i);
            //    i++;
            //}
            //while (i <= 5);
            //Console.ReadKey();

            //for (int i = 5; i >= 1; i--)
            //{
            //    Console.WriteLine("i=" + i);
            //}
            //Console.ReadKey();

            //int i = 5;
            //while (i >= 1)
            //{
            //    Console.WriteLine("i="+i);
            //    i--;
            //}
            //Console.ReadKey();

            int i = 5;
            do
            {
                Console.WriteLine("i=" + i);
                i--;
            }
            while (i >= 1);
            Console.ReadKey();
        }
    }
}