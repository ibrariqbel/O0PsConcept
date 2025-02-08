using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O0PsConcept
{
    internal class StaticExample
    {

        public static int VarInt = 100;
        public static int NonVarInt = 100;

        public static int TestProperty {  get; set; }
        public static void TestMethod()
        {
            Console.WriteLine("I am Static Method");
        }

    }
}   
