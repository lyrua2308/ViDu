using System;
using System.Collections.Generic;
using System.Text;

namespace bàitapchuong1
{
    class NguyenTo
    {
        int N;
        public void nhap()
        {
            Console.WriteLine(" nhap vao so nguyen duong N : ");
            N = Convert.ToInt32(Console.ReadLine());
        }
        public bool IsNguyenTo()
        {
            bool Kq = false;
            int dem = 0;
            for (int i = 1; i <= N; i++)
                if (N % i == 0) dem++;
            if (dem == 2 && N > 0) Kq = true;
            return Kq;
        }
        public void xuat()
        {
            if (IsNguyenTo())
            {
                Console.WriteLine("{0} là so nguyen to ", N);
                Console.ReadLine();
            }
            else Console.WriteLine("khong phai la so nguyen to ");
            Console.ReadLine();
            if (N < 0) Console.WriteLine(" yeu cau nhap so nguyen duong ");
            Console.ReadLine();
        }
    }
}
