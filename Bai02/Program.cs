using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter n:");
            int n = int.Parse(Console.ReadLine());
            int res = TinhTongSoNguyen(n);
            Console.WriteLine($"The sum of prime numbers less than n is {res}");
        }
        static bool isPrime(int n)
        {
            if (n < 2)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
        static int TinhTongSoNguyen(int n)
        {
            int res = 0;
            for (int i=0;i<n;i++)
            {
                if (isPrime(i))
                {
                    res += i;
                }
            }
            
            return res;
        }
    }
}
