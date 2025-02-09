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
<<<<<<< HEAD
          
=======
            int a=23;
>>>>>>> e89e47975b03790bd64a28b1ad8fc872e4104a48
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
