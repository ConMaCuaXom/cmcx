using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1_I
{
    public class Program
    {
        static void Main(string[] args)
        {
            /* Nhập vào tên thuê bao, số điện trên công tơ sau đó tính cước theo quy ước sau.
            - Nếu số điện <= 30 số thì cước phí tính 30$.
            - Nếu từ 30 - 50 số thì số trong khoảng (30 - 50) sẽ tính theo 1.2$ cho mỗi số.
            - Nếu trên 50 số thì số trên 50 được tính theo 1.5$ cho mỗi số
            - In ra màn hình toàn bộ thông tin. */

            Console.WriteLine("Nhap ten thue bao: ");
            string name = Console.ReadLine();
            Console.WriteLine("Nhap so dien su dung: ");
            double number = Convert.ToDouble(Console.ReadLine());
            double total = 0;

            if (number > 0 && number<=30) 
            {
                total = 30;
                Console.Write("Cuoc phi la: ");
                Console.WriteLine(total+"$");
            }

            if (number > 30 && number<=50)
            {
                total = 30 + (number - 30) * 1.2;
                Console.Write("Cuoc phi la: ");
                Console.WriteLine(total + "$");
            }
            if(number > 50)
            {
                total = 30 + 20 * 1.2 + (number - 50) * 1.5;
                Console.Write("Cuoc phi la: ");
                Console.WriteLine(total + "$");
            }

            Console.ReadKey();
        }
    }
}
