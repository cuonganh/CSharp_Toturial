using System;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Bai_01{
    class Program{
        public static void main(String[] args){
            float firstNumber = 0; secondNumber = 0;
            Console.WriteLine("Nhap vao so thu nhat: ");
            firstNumber = float.Parse(Console.ReadLine);
            Console.WriteLine("Nhap vao so thu hai: ");
            secondNumber = float.Parse(Console.ReadLine());
            
            //Bai01
            Console.WriteLine("Tong cua {0} va {1} la: {2}", firstNumber, secondNumber, firstNumber + secondNumber);
            Console.WriteLine("Hieu cua {0} va {1} la: {2}", firstNumber, secondNumber, firstNumber - secondNumber);
            Console.WriteLine("Tich cua {0} va {1} la: {2}", firstNumber, secondNumber, firstNumber * secondNumber);
            if(secondNumber !=0){
                Console.WriteLine("Thuong cua {0} va {1} la: {2}", firstNumber, secondNumber, firstNumber / secondNumber);
            }
            
            //Bai02
            
            Console.ReadLine();

        }
    }
}