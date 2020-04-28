using System;

namespace bàitapchuong1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine(" nhap bao so nguyen a: ");
             int a = Int32.Parse(Console.ReadLine());
             Console.WriteLine("nhap so nguye b :");
             int b = Convert.ToInt32(Console.ReadLine());
             int tong = a + b;
             Console.WriteLine("tong cua so {0} va {1} la {2}   " ,a,b,tong);
             Console.ReadLine();*/

            /*
            Console.WriteLine(" giai va bien luan phuong trinh ax+b=0");
            Console.WriteLine(" nhap so a ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" nhap so b ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" phuong trinh can gia la {0}x+{1}=0", a, b);
            if (a == 0)
            {
                if (b == 0) Console.WriteLine(" phuonf trinh vo so nghiem ");
                else Console.WriteLine(" phuong trinh vo nghiem ");

            }
            else Console.WriteLine(" phuong trinh co nghiem la -{0}/{1} ", b, a);
            Console.ReadLine(); */


            /*Console.WriteLine(" giai va bien luan phuong trinh ax2+bx+c=0");
            Console.WriteLine(" nhap so a ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" nhap so b ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" nhap so c ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" phuong trinh can gia la {0}x2+{1}x+{2}=0",a, b,c);
            int denta = b * b - 4 * a * c;
            if (denta < 0) Console.WriteLine("phuong trinh vo nghiem ");
            if (denta == 0) Console.WriteLine(" phuong trinh có 2 nghiem kep x=-{1}/2*{0}", b, a);
            if(denta>0)*/

            TamGiac Tg1 = new TamGiac();
            /*Tg1.nhap();*/
            if (Tg1.IsTamGiac())
            {
                Console.WriteLine(" chu vi va dien tich cua tam giac lan luot la : {0} va {1} ", Tg1.ChuVi(), Tg1.DienTich());
               
            }
            else Console.WriteLine(" khong phai la tam giac");
            Console.ReadLine();

            /*NguyenTo NT1 = new NguyenTo();
            NT1.nhap();
            NT1.xuat();*/

            /*SoHoanHao SHH1 = new SoHoanHao();
            SHH1.nhap();
            SHH1.xuat();*/
            /*TangDancs TD1 = new TangDancs();
            TD1.nhap();
            TD1.xuat();
            TD1.SXTangDan();*/

            TamGiac TG2;
                TG2 = new TamGiac(2,4,3);
            Console.WriteLine(" chu vi va dien tich cua tam giac lan luot la : {0} va {1} ", TG2.ChuVi(), TG2.DienTich());



        }
    }
}
