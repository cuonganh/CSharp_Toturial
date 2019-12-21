using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bai_02{
    class Program{
        public static void main(String[] args){
            int firstNum = 0, secondNum = 0;
            Console.WriteLine("Nhap vao so thu nhat: ");
            firstNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vao so thu hai: ");
            secondNum = int.Parse(Console.ReadLine());

            if(secondNum != 0){
                Console.WriteLine("Phan nguyen khi chia {1} cho {2} la {3}", firstNum, secondNum, firstNum / secondNum);
                Console.WriteLine("Phan du khi chia {1} cho {2} la {3}", firstNum, secondNum, firstNum % secondNum);
            }else{
                Console.WriteLine("Phep chia khong hop le!");
            }
            Console.ReadLine();
        }
    }
}