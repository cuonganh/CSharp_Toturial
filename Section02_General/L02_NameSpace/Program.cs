using firstnamespace;
using firstnamespace.secondnamespace;
using System;
using System.Collections.Generic;
using System.Linq;
using Text;
using System.Threading.Tasks;

namespace firstnamespace{
    public class Intro{
        public void SayHello(){
            Console.WriteLine("I am in namespace 1");  
        }
    }
    namespace secondnamespace{
        public class Introduction{
            public void SayHello(){
                Console.WriteLine("I am in namespace 2");
            }
        }
    }
}

namespace HelloWorld{

    public class Program{

    }
}