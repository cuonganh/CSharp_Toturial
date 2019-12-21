using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Comparison_Operator{
    class Program{
        public static void main(String[] args){

            int a = 1, b = 2;
            bool check1 = true, check2 = false;

            Console.WriteLine(a == b || a >= b);  // => false
            Console.WriteLine(a != b || check1 != check2);  // => true

            Console.ReadLine();
        }
    }
}