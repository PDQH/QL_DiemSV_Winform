using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_Diem_BTL
{
     internal class XuLydataDiem
    {
        public double ThangDiem4(Double diem)
        {
            double d = 0;
            if (diem >= 9.0)
                d = 4;
            else if (diem >= 8.5)
                d = 3.7;
            else if (diem >= 7.8)
                d = 3.5;
            else if (diem >= 7.0)
                d = 3;
            else if (diem >= 6.3)
                d = 2.5;
            else if (diem >= 5.5)
                d = 2;
            else if (diem >= 4.8)
                d = 1.5;
            else if (diem >= 4.0)
                d = 1;
            else if (diem < 4.0)
                d = 0;
            return d;
        }
        public String DiemChu(Double diem)
        {
            String d = null;
            if (diem >= 9.0)
                d = "A+";
            else if (diem >= 8.5)
                d = "A";
            else if (diem >= 7.8)
                d = "B+";
            else if (diem >= 7.0)
                d = "B";
            else if (diem >= 6.3)
                d = "C+";
            else if (diem >= 5.5)
                d = "C";
            else if (diem >= 4.8)
                d = "D+";
            else if (diem >= 4.0)
                d = "D";
            else if (diem < 4.0)
                d = "F";
            return d;
        }
        public String XL(double a)
        {
            string x;
            if (a >= 3.6)
                x = "Xuất xắc";
            else if (a >= 3.2)
                x = "Giỏi";
            else if (a >= 2.5)
                x = "Khá";
            else if (a >= 2)
                x = "Trung bình";
            else 
                x = "Yếu";
            return x;
        }
    }
}
