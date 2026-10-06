using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tinhtien
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap vao so to 500k: ");
            int s500 = int.Parse(Console.ReadLine());
            Console.Write("Nhap vao so to 200k: ");
            int s200 = int.Parse(Console.ReadLine());
            Console.Write("Nhap vao so to 100k: ");
            int s100 = int.Parse(Console.ReadLine());
            Console.Write("Nhap vao so to 50k: ");
            int s50 = int.Parse(Console.ReadLine());


            int tong = s500 * 500000 + s200 * 200000 + s100 * 100000 + s50 * 50000;

            if (tong>Math.Pow(10,9))
                Console.WriteLine($"Voi so tien {tong}, ban la ty phu");
            else if (tong>1000000)
                Console.WriteLine($"Voi so tien {tong}, ban la trieu phu");
            else if (tong > 10000)
                Console.WriteLine($"Voi so tien {tong}, ban la hieu truong");
            else
                Console.WriteLine($"Voi so tien {tong}, ban la thay giao");
            Console.ReadKey();

        }
    }
}
