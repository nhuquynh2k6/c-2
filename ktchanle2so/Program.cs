using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ktchanle2so
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so thu nhat: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so thu hai: ");
            int b = int.Parse(Console.ReadLine());
            if (a%2==0 && b%2==0)
                Console.WriteLine("Hai so deu la so chan");
            else
                Console.WriteLine("Hai so khong phai deu la so chan");
            Console.ReadKey();
            
           
        }
    }
}
