using System;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Bai_03{
    class Program{
        public static void main(String[] args){
            float firstNumber = 0, secondNumber = 0, thirdNumber = 0;
            Console.Write("Nhap vao so thu nhat: ");
            firstNumber = float.Parse(Console.ReadLine);
            Console.Write("Nhap vao so thu hai: ");
            secondNumber = float.Parse(Console.ReadLine());
            Console.Write("Nhap vao so thu ba: ");
            thirdNumber = float.Parse(Console.ReadLine());

            Console.WriteLine("Trung binh cong cua {0}, {1} va {2} la {3}", firstNumber, secondNumber, thirdNumber, (firstNumber + secondNumber + thirdNumber)/3);
            Console.ReadLine();
        }
    }
}