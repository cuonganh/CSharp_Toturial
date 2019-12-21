using System;
using System.Text;
using System.Linq;
using System.Threading;
using System.Collections.Generic;

namespace Logic_Operation{
    class Program{
        public static void main(String[] args){
            
            int a = 1, b = 2, c = 3;
            Console.WriteLine( (!(a>b) && a < c ) || a == c);
            
            Console.ReadLine();
        }
    }
}