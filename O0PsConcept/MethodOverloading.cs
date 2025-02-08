using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O0PsConcept
{
    public class MethodOverloading
    {
        public virtual void ParentMethod()
        {
            Console.WriteLine("i'm parent method");
        }
    }

    public class ChildClassMO2:MethodOverloading
    {
        public override void ParentMethod()
        {
            Console.WriteLine("i'm change the method that is override in the class");
        }
    }
}
