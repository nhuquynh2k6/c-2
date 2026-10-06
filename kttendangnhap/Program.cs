using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace kttendangnhap
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Nhap username: ");
            //string username = Console.ReadLine();
            //Console.WriteLine("Nhap password: ");
            //string password = Console.ReadLine();
            //if (username != "abc" || password != "123")
            //    Console.WriteLine("Ten dang nhap va mat khau sai");
            //else
            //    Console.WriteLine("Ten dang nhap va mat khau dung");
            //Console.ReadKey();

            int count = 0;
            string username, password;
            do
            {
                Console.WriteLine("Nhap username: ");
                username = Console.ReadLine();
                Console.WriteLine("Nhap password: ");
                password = Console.ReadLine();
                if (username != "abc" || password != "123")
                    count++;
                else
                    count = 1;
            }
            while ((username != "abc" || password != "123") && count != 3);
            if (count == 3)
                Console.WriteLine("Ban da nhap sai qua 3 lan, vui long thu lai");
            else
                Console.WriteLine("Ten dang nhap va mat khau dung");
            Console.ReadKey();

        }
    }
}
