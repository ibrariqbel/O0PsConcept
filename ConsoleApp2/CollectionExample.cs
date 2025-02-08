using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class CollectionExample
    {
        public void ArrayListExample()
        {
            // Define
            ArrayList objArray = new ArrayList();

            // insert value
            objArray.Add(1);
            objArray.Add("Ibrar");    
            objArray.Add(false);
            objArray.Add(DateTime.Now);

            // read
            int var1 = Convert.ToInt32(objArray[0]);
            string var2 = Convert.ToString(objArray[1]);
            bool var3 = Convert.ToBoolean(objArray[2]);
            DateTime var4 = Convert.ToDateTime(objArray[3]);


            // update
            objArray[2] = 10000;

            // insert
            objArray.Insert(1, "Ali");


            // Delete
            objArray.Remove("Ibrar");//by name of index
            objArray.RemoveAt(3);// by index number
            objArray.Clear();//complete delete array

            int count  = objArray.Count;// tell about total number of array
             bool isExit = objArray.Contains(1);// it tell the this type of data can exit or not it can give you value in the form of true and false
        }
    }
}
