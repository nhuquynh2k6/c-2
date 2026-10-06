using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static string reverseStr(string s, int a)
        {
            //    if (s.Length == 0) return s;
            //    return s[s.Length - 1] + reverseStr(s.Substring(0, s.Length - 1));
            return a == 1 ? s[a - 1].ToString() : s[a - 1] + reverseStr(s, a - 1);
        }
        private static void hienThi(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + ",");

            }
            
        }
        
        static void Main(string[] args)
        {
            //Console.Write("Nhap vao 1 chuoi: ");
            //string input = Console.ReadLine();
            //string reversed = reverseStr(input);
            //Console.WriteLine(reversed);
            //Console.Write("Nhap vao 1 chuoi: ");
            //string input = Console.ReadLine();
            //Console.WriteLine(reverseStr(input,input.Length));
            Console.Write("Nhap vao so phan tu cua day so: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                //Console.Write($"Nhap vao phan tu thu {i + 1}: ");
                //arr[i] = int.Parse(Console.ReadLine());
                arr[i] = r.Next(1,101);
            }
            Console.WriteLine($"Spt trong mang la: {n}");
            for (int i = 0;i < n; i++)
            {
                Console.WriteLine($"Gtri cua ptu thu {i+1} la: {arr[i]+" "}");
            }
            int sum = 0;
            foreach(int i in arr)
                sum += i;
            Console.WriteLine($"Tong cac ptu of mang la: {sum}");
            //Console.WriteLine("Truoc sap: ");
            //hienThi(arr);
            //Console.WriteLine("Sx tang: ");
            //Array.Sort(arr);
            //hienThi(arr);
            //Console.WriteLine("Sx giam: ");
            //Array.Reverse(arr);
            //hienThi(arr);
            Console.ReadKey();
        }
    }
}
