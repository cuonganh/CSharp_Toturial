using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Arithmetic_Operators{
    class Program{
        public static void main(String[] args){
            int a = 0, b = 1, c = 2;
            a = b++;
            c = --a;
            Console.WriteLine("a = {0}, b = {1}, c = {2}", a, b, c);
            Console.ReadLine();
        }
    }
}