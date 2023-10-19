using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, m;
            Console.WriteLine("Nhap n dong: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap m cot: ");
            m = Convert.ToInt32(Console.ReadLine());
            int[,] maTran = TaoMaTranNgauNhien(n, m);
            //Xuat ma tran
            Print(maTran);
            //Phan tu lon nhat
            int max = PhanTuLonNhat(maTran);
            Console.WriteLine($"Phan tu lon nhat: {max}");
            //Phan tu nho nhat
            int min = PhanTuNhoNhat(maTran);
            Console.WriteLine($"Phan tu nho nhat: {min}");
            //Dong co tong lon nhat
            int dong = TongLonNhat(maTran);
            Console.WriteLine($"Dong co tong lon nhat la:{dong} ");
            //Tong cac so khong phai so nguyent to
            int tong = tongKhongNguyenTo(maTran);
            Console.WriteLine($"Tong cac so khong phai so nguyen to: {tong}");
            //Xoa dong thu k trong ma tran
            Console.WriteLine("Nhap vao dong k muon xoa: ");
            int k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ma tran sau khi xoa dong k: ");
            XoaDong(maTran,k);

        }
        static void XoaDong(int[,]maTran,int dongXoa)
        {

            int numRows = maTran.GetLength(0);
            int numCols = maTran.GetLength(1);
            int newNumRows = numRows - 1;
             
            int[,] newMatrix = new int[newNumRows, numCols];
             
            int newRow = 0;
            for (int row = 0; row < numRows; row++)
            {
                if (row != dongXoa)
                {
                    for (int col = 0; col < numCols; col++)
                    {
                        newMatrix[newRow, col] = maTran[row, col];
                    }
                    newRow++;
                }
            }
            Print(newMatrix);

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
        static int tongKhongNguyenTo(int[,] maTran)
        {
            int tong = 0;
            for (int i = 0; i < maTran.GetLength(0); i++)
            {
                for (int j = 0; j < maTran.GetLength(1); j++)
                {
                    if (IsPrime(maTran[i,j]))
                    {
                        tong += maTran[i, j];
                    }
                }
            }
            return tong;
        }
        static int TongLonNhat(int[,] maTran)
        {
            int dong = -1;
            int tong = 0;
            for (int i=0;i<maTran.GetLength(0);i++)
            {
                int sum = 0;
                for (int j=0;j<maTran.GetLength(1);j++)
                {
                    sum += maTran[i, j];
                }
                if (sum>=tong)
                {
                    sum = tong;
                    dong = i;
                }
            }
            return dong;
        }
        static int PhanTuLonNhat(int[,]maTran )
        {
            int maxValue = int.MinValue;
            for (int i = 0; i < maTran.GetLength(0); i++)
            {
                for (int j = 0; j < maTran.GetLength(1); j++)
                {
                    if (maxValue < maTran[i, j])
                    {
                        maxValue = maTran[i, j];
                    }
                }
            }
            return maxValue;
        }
        static int PhanTuNhoNhat(int[,] maTran)
        {
            int minValue = int.MaxValue;
            for(int i = 0; i < maTran.GetLength(0); i++)
            { 
                for(int j = 0; j < maTran.GetLength(1); j++)
                {
                    if (minValue > maTran[i,j])
                    {
                        minValue = maTran[i, j];
                    }
                }
            }
            return minValue;
        }
        static int[,] TaoMaTranNgauNhien(int n, int m)
        {
            Random random = new Random();
            int[,] maTran = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    maTran[i, j] = random.Next(100);
                }
            }

            return maTran;
        }
        static void Print(int[,] maTran )
        {
            int n = maTran.GetLength(0);
            int m = maTran.GetLength(1);
            for (int i=0;i<n;i++)
            {
                for (int j=0;j<m;j++)
                {
                    Console.Write($"{maTran[i, j]} " );
                }
                Console.Write("\n");
            }
        }
    }
}
