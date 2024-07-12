using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingAndUnboxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //BOXING int to object casting
            int value1 = 200;
            object obj1 = value1;
            Console.WriteLine("int " + value1 +" object value after boxing "+ obj1);

            //UNBOXING object to int casting
            int obj2 = 230;
            int value2 = (int)obj2;
            Console.WriteLine("object " + obj2 + " int value after unboxing " + value2);

        }
    }
}
