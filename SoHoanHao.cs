using System;
using System.Collections.Generic;
using System.Text;

namespace bàitapchuong1
{
    class SoHoanHao
    {
        int N;
        public void nhap()
        {
            Console.WriteLine(" nhap vao so nguyen duong N : ");
            N = Convert.ToInt32(Console.ReadLine());
        }
        public bool KT()
        {
            bool kq = false;
            int sum = 0;
            for (int i = 1; i < N; i++)
                if (N % i == 0) sum += i;
            if (sum == N) kq = true;
            return kq;

        }
        public void xuat()
        {
            if (KT())
            {
                Console.WriteLine("LA SO HOAN HAO");
                Console.ReadLine();
            }
            else Console.WriteLine("KHONG PHAI LA SO HOAN HAO ");
            Console.ReadLine();

        }
    }
}
