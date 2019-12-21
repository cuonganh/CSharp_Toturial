using System;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Collections.Generic;

namespace ChuyenDoiDuLieu{
    class Program{
        public static void Main(String[] args){
            //Convert.To__(--);
            //type.Parse(--);

            byte bNumber    = 2;
            int iNumber     = -1;

            int iNumber2    = bNumber;
            byte bNumber2   = (byte)iNumber;

            string sNumber  = "200";
            string strNumber= "2.718281828";
            int iNumber3    = Convert.ToInt32(sNumber);
            int iNumber4    = int.Parse(sNumber);
            int fNumber     = float.Parse(strNumber);

            Console.WriteLine("Nhap vao mot so: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(number);

            Console.ReadLine();
        }
    }
}