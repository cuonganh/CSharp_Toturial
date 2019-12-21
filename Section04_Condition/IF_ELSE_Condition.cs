using System;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace IF_ELSE{
    class program{
        public static void main(String[] args){

            String userGuess;
            String status = "Tai";

            Random ran = new Random();
            int ranNum;

            Console.WriteLine("Nhap vao lua chon Tai hay Suu < T , S >");
            userGuess = Console.ReadLine();
            ranNum = ran.Next(0, 2);    // Lay duoi bo tren: lay 0, 1 bo 2.

            // 0 -> Tai, 1 -> Suu
            if(ranNum == 1){
                status = "Suu";
            }

            if((ranNum == 0 && userGuess = "T") || (ranNum == 1 && userGuess = "S")){
                    Console.WriteLine("Ra {0} ban da thang", status);
            }else{
                Console.WriteLine("Ra {0} ban da thua", status);
            }

            Console.ReadLine();
        }
    }
}