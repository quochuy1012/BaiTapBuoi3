using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{               // Giải phương trình bậc 2 
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lệnh không bị lỗi font chữ
            Console.OutputEncoding = Encoding.UTF8;

            // Khai báo biến cho phương trình
            float a, b, c, delta;


            // Nhập giá trị cho từng phần tử 
            Console.WriteLine("Mời nhập vào giá trị của a: ");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Mời nhập vào giá trị của b: ");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine("Mời nhập vào giá trị của c: ");
            c = float.Parse(Console.ReadLine());

            // Tính nghiệm của phương trình
            delta = (b * b) - (4 * a * c);
            // Trường hợp 1 
            if (delta < 0)
                Console.WriteLine("Phương trình vô nghiệm.");
            // Trường hợp 2 
            else if (delta == 0)
            {
                float x = -b / (2 * a);
                Console.WriteLine("Phương trình có nghiệm kép là {0}", x);
            }
            // Trường hợp 3
            else
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("Phương trình có 2 nghiệm phân biệt");
                Console.WriteLine("X1 = {0}", x1);
                Console.WriteLine("X2 = {0}", x2);
            }



            // Lệnh dừng màn hình 
            Console.ReadKey();
        }
    }
}