using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tonglannhap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tongSo = 0, tongLanNhap = 0, gtln = 0, gtnn = 0;
            double tb;
            while (true)
            {
                Console.WriteLine("Nhap vao so nguyen: ");
                int n = int.Parse(Console.ReadLine());
                if (n > 0)
                {
                    tongSo = n + tongSo;
                    tongLanNhap++;
                }
                else
                {
                    break;
                }
                Console.WriteLine($"Tong cac so da nhap la {tongSo}");
                Console.WriteLine($"Tong so lan nhap la {tongLanNhap}");
                Console.ReadKey();
            }
        }
    }
}
