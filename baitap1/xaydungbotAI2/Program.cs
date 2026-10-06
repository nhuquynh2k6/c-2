using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xaydungbotAI2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao so lon bia: ");
            int soLonBia = int.Parse(Console.ReadLine());
            Console.WriteLine($"Quy doi thanh {soLonBia/24} thung va {soLonBia%24} lon");
            Console.ReadKey();




        }
    }
}
