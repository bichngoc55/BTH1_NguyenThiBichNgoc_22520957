using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ng,th,nm;
            Console.WriteLine("Nhap ngay: ");
            ng = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap thang: ");
            th=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap nam: ");
            nm = Convert.ToInt32(Console.ReadLine());
            if (ktraHopLe(ng, th, nm))
            {
                Console.WriteLine("Ngay thang nam hop le");
            }
            else
                Console.WriteLine("Ngay thang nam khong hop le");
        }
 
        static bool ktraHopLe(int ng,int th,int nm)
        {
            int[] thang = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (DateTime.IsLeapYear(nm))
            {
                thang[1] = 29;
                if (th>=1&& th<=12)
                {
                    if (ng>=1 &&ng<=thang[th])
                    {
                        return true;
                    }
                }
            }
            else
            {
                if (th >= 1 && th <= 12)
                {
                    if (ng >= 1 && ng <= thang[th])
                    {
                        return true;
                    }
                }
            }
            return false;

        }
    }
}
