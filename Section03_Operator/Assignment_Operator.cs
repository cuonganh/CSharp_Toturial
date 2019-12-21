using System;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Assignment_Operator{
    class Program{
        public static void main(String[] args){

            int a = 3, b = 6, c = 14;
            a += 3;
            b -= 3;
            c += 1;
            
            Console.WriteLine("a = {0}, b = {1}, c = {2}", a, b, c);
            Console.ReadLine();
        }
    }
}