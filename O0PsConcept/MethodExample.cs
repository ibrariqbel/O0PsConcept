using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O0PsConcept
{
    public class MethodExample
    {
        // method with return type
        public void TestMethod()
        {
            Console.WriteLine("this is test case");
        }
        public void sum(int a ,int b)
        {
            int result  = a + b;
            Console.WriteLine(result);
        }

        // method with array type
        public void arra(int[] array1)
        {
            int result = 0;
            foreach(int i in array1)
            {
                result += i;
            }
            Console.WriteLine(result);
        }

        //Array with get function
        public int[] GetArray(int a, int b)
        {
            int[] result = new int[2];
            result[0] = a;
            result[1]=b;


            return result;
        }
    } 
}
