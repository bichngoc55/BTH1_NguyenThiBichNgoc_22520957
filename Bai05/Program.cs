using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ng, th, nm;
            Console.WriteLine("Nhap ngay: ");
            ng = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap thang: ");
            th = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap nam: ");
            nm = Convert.ToInt32(Console.ReadLine());
            string dayOfWeek = CalculateDayOfWeek(ng, th, nm);
            Console.WriteLine($"Ngày {ng}/{th}/{nm} là ngày {dayOfWeek}");

        }
        static int CalculateDays(int ng, int th, int nm)
        {
            int[] daysInMonth = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            if (IsLeapYear(nm))
                daysInMonth[1] = 29;

            int days = 0;
            for (int y = 1; y < nm; y++)
            {
                days += IsLeapYear(y) ? 366 : 365;
            }

            for (int m = 1; m < th; m++)
            {
                days += daysInMonth[m - 1];
            }

            days += ng;

            return days;
        }

        static bool IsLeapYear(int nm)
        {
            return (nm % 4 == 0 && nm % 100 != 0) || nm % 400 == 0;
        }
        static string CalculateDayOfWeek(int ng, int th, int nm)
        {
            int days = CalculateDays(ng, th, nm);
            int dayOfWeek = days % 7;
            string[] daysOfWeek = {   "Thu hai", "Thu ba", "Thu tu", "Thu nam", "Thu sau", "Thu bay", "Chu nhat" };
            return daysOfWeek[dayOfWeek];
        }
    }
}
