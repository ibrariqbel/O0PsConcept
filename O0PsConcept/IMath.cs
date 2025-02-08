using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O0PsConcept
{
    public interface IMath
    {
        void sum(int a, int b);
        void sub(int a, int b);
    }

    public interface ITest
    {
        void test();
    }

    public class ChildIMath : IMath, ITest
    {
        public void sum(int a, int b)
        {
            Console.WriteLine("The Sum of two number is: " + (a + b));
        }
        public void sub(int a, int b)
        {
            Console.WriteLine("The Subtraction of two number is: " + (a - b));
        }

        public void test()
        {
            Console.WriteLine("This second Interface class inherite in same child class");
        }
    }
}
