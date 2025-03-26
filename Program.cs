using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_dequycoban
{
    class Program
    {
        // Hàm tính giai thừa bằng đệ quy 
        //Lưu ý người dùng code khi thực hiện đệ quy nên lưu ý biết nó phải có ít nhất 1 điều kiện dừng 
        static int Giaithua (int n)
        {
            // Điều kiện dừng đệ quy: nếu n == 0 thì giai thừa của 0 là 1
            if ( (n==0))
            {
                return 1;
            }
            else
            {
                // Đệ quy: giai thừa của n là n nhân với giai thừa của (n-1)
                return n * Giaithua(n - 1);
            }
        }
        static void Main(string[] args)
        {
            // in tiếng việt 
            Console.OutputEncoding = Encoding.UTF8;
            int n;
            Console.WriteLine("********************************");
            Console.WriteLine("------DEMO ĐỆ QUY CƠ BẢN------ ");
            Console.WriteLine();
            Console.WriteLine("mời nhập lại : ");
            n = int.Parse(Console.ReadLine());
            if (n<0)
            {
                Console.WriteLine("Không có giai thừa số âm");
            }
            else
            {
                Console.WriteLine("{0} giai thừa bằng {1}", n, Giaithua(n));
            }
            Console.ReadLine();
        }
    }
}
