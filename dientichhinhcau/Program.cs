using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dientichhinhcau
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao ban kinh hinh cau: ");
            double r = double.Parse(Console.ReadLine());
            Console.WriteLine($"Dien tich hinh cau la: {4*Math.PI*Math.Pow(r,2)}");
            Console.WriteLine($"The tich hinh cau la: {(4/3)*Math.PI*Math.Pow(r,3)}");
            Console.ReadKey();
        }
    }
}
