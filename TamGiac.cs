using System;
using System.Collections.Generic;
using System.Text;

namespace bàitapchuong1
{
    class TamGiac
    {
        int a, b, c;
        public void nhap()
        {
            Console.WriteLine("nhap vao canh a : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nhap vao canh b : ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nhap vao canh c : ");
            c = Convert.ToInt32(Console.ReadLine());
        }
         
        public bool IsTamGiac()
        {
            bool kq = false;
            if ((a + b) > c && c > (a - b) && (a + c) > b && b > (a - c) && (c + b) > a && a > (c - b))
                kq = true;
            return kq;
        }
        public double ChuVi()
        {
            if (IsTamGiac())
                return (a + b + c);
            else Console.WriteLine(" khong phai la tam giac");
            return -1;
        }
        public double DienTich()
        {
            if (IsTamGiac())
            {
                double p = (a + b + c) *0.5;
                return (Math.Sqrt(p * (p - a) * (p - b) * (p - c)));


            }
            else Console.WriteLine("khong phai la tam giac ");
            return -1;
        }


        public TamGiac()
        {
            a = b = c = 1;

        }

       
        public TamGiac(int a,int b,int c )
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

  
    }
}
