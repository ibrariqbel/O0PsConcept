using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O0PsConcept
{
    public class Parent()
    {
       public void ParentMethod()
        {
            Console.WriteLine("I am parent class Method");
        }

    }

    public class Child():Parent
    {
        public void ChildtMethod()
        {
            Console.WriteLine("I am Child class Method");
        }
    }

    public class GrandChild():Child
    {
        public void GrandChildtMethod()
        {
            Console.WriteLine("I am Grand Child class Method");
        }
    }
}
