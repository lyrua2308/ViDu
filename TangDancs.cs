using System;
using System.Collections.Generic;
using System.Text;

namespace bàitapchuong1
{
    class TangDancs
    {
         private  int n;
        int[] a;
        int tg;
        public void nhap()
        {
            Console.WriteLine("nhap so luong cua phan tu ");
            n = Int32.Parse(Console.ReadLine());
            a = new int[n];
            for( int i=0;i<n;i++)
            {
                Console.WriteLine("nhap phan tu thu {0} la : ", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        public void xuat()
        {
            Console.WriteLine(" Mang vua nhap la ");
            for(int i=0;i<n;i++)
            {
                Console.WriteLine("{0}", a[i]);

            }
        }
        public void SXTangDan()
        {
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (a[i] > a[j])
                    {
                        tg = a[i];
                        a[i] = a[j];
                        a[j] = tg;

                    }

                }
            }
            Console.WriteLine(" mang sap xep la ");
            for( int i=0;i<n;i++)
            {
                Console.WriteLine("{0}", a[i]);
            }
            Console.ReadLine();
        }

    }
}
