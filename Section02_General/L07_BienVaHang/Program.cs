using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Bien_va_Hang{
    class Program{
            static void Main(string[] args){
            
            byte byteNumber = 255;
            const float PI = 3.14f;
            const double E = 2.718; //default

            var num  = 15;
            var s1  = "Lap trinh C#";
            var check = true;

            Console.WriteLine("Value of byte is " + byte.MinValue + " to " + byte.MaxValue);
            Console.WriteLine("Type of num is " + num.GetType());
            Console.WriteLine("Type of check is " + check.GetType());


            Console.ReadLine();
            

        }
    }
}