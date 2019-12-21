using System;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace SwitchCase{
    class Program{
        public static void main(String[] args){

            int luaChon;
            string strInput;

            Console.WriteLine("1. Nhap ho ten \n2. Nhap dia chi \n3. Nhap so dien thoai \n4. Nhap email");
            luaChon = Int32.Parse(Console.ReadLine());

            switch(luaChon){
                case 1:
                    Console.WriteLine("Nhap ten:");
                    strInput = Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("Nhap dia chi:");
                    strInput = Console.ReadLine();
                    break;
                case 3:
                    Console.WriteLine("Nhap so dien thoai:");
                    strInput = Console.ReadLine();
                    break;
                case 4:
                    Console.WriteLine("Nhap e mail:");
                    strInput = Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Ban da nhap sai.");
                    break;
            }
            
            Console.WriteLine(strInput);
            Console.ReadLine();
        }
    }
}