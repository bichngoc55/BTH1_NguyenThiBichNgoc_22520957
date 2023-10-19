using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int th, nm;
            Console.WriteLine("Nhap thang: ");
            th = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap nam: ");
            nm = Convert.ToInt32(Console.ReadLine());
            int ng = tinhNgay(th, nm);
            Console.WriteLine($"So ngay trong thang la {ng}");
        }

        static int tinhNgay( int th, int nm)
        {
            int[] thang = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (DateTime.IsLeapYear(nm))
            {
                thang[1] = 29;
                return thang[th-1];
            }
            else
            {
                return thang[th-1];
            }

        }
    }
}
