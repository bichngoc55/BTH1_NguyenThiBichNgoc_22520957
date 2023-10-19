using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai01
{

    internal class Program
    {
      
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Input n : ");
            n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            for (int i=0;i<n; i++)
            {
                Console.WriteLine($"Element {i + 1}:");
                a[i] = Convert.ToInt32(Console.ReadLine());
                 
            }
            int res = Sum(a);
            Console.WriteLine($"Tong cua day: {res}");

            int count=CountPrimes(a);
            Console.WriteLine($"Tong so luong so nguyen to: {count}");

            int smallestPerfectSquare = FindSmallestPerfectSquare(a);
            Console.WriteLine($"So chinh phuong nho nhat :{smallestPerfectSquare} ");
        }
        static int Sum(int[] array)
        {
            int sum = 0;

            foreach (var number in array)
            {
                sum += number;
            }

            return sum;
        }
        static bool IsPrime(int number)
        {
            if (number < 2)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        static int CountPrimes(int[] array)
        {
            int count = 0;

            foreach (var number in array)
            {
                if (IsPrime(number))
                {
                    count++;
                }
            }

            return count;
        }
        static bool IsPerfectSquare(int number)
        {
            int sqrt = (int)Math.Sqrt(number);
            return sqrt * sqrt == number;
        }

        static int FindSmallestPerfectSquare(int[] array)
        {
            int smallestPerfectSquare = -1;

            foreach (var i in array)
            {
                if (IsPerfectSquare(i))
                {
                    if (smallestPerfectSquare == -1 || i < smallestPerfectSquare)
                    {
                        smallestPerfectSquare = i;
                    }
                }
            }

            return smallestPerfectSquare;
        }

    }
}
