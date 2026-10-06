using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5songuyenbatki
{
    class Program
    {
        static void Main(string[] args)
        {
            int tong = 0, gtln = 0, gtnn = 0;
            double tb;
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("Nhap vao so nguyen: ");
                int so = int.Parse(Console.ReadLine());
                tong = tong + so;
                if (i == 1)
                {
                    gtnn = so;
                    gtln = so;
                }
                else
                {
                    if (so < gtnn)
                        gtnn = so;
                    if (so > gtln)
                        gtln = so;

                }
                Console.Write($"Tong cua cac so da nhap: {tong}");
                Console.Write($"Trung binh cong cua cac so da nhap: {(double)tong / 3}");
                Console.Write($"So lon nhat: {gtln}");
                Console.Write($"So nho nhat: {gtnn}");
                Console.ReadKey();
            }
        }
    }
}

