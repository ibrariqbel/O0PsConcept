using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O0PsConcept
{
    public class ArrayCollectionExample
    {
        public void ArrayListExamples()
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

            int count = objArray.Count;// tell about total number of array
            bool isExit = objArray.Contains(1);// it tell the this type of data can exit or not it can give you value in the form of true and false
        }
        public void HashTableExample()
        {
            // object Create
            Hashtable objHt = new Hashtable();
            // Insert values
            objHt.Add(1, "Ali");// key value combination is called dictionaryentry.
            objHt.Add(2, "Aslam");
            objHt.Add("abc", "Noor");
            objHt.Add(4, "Amreen");

            //Read
            string val1 = Convert.ToString(objHt[1]);
            string var2= Convert.ToString(objHt[2]);
            string var3 = Convert.ToString(objHt["abc"]);
            string var4 = Convert.ToString(objHt[4]);

            //update
            objHt[2] = "Sultan";

            //delete
            objHt.Remove(1);
            objHt.Clear();

            // count 
            int count  = objHt.Count;   

            // check key exit or not
            bool isExit = objHt.Contains(1);
                
           bool isValueExit = objHt.Contains("Noor");

            // foreach

            foreach (var key in objHt.Keys)
            { 
                Console.WriteLine(key);
            }

             foreach (var value in objHt.Values)
            { 
                Console.WriteLine(value);
            }

            foreach (DictionaryEntry item in objHt)
            {
                Console.WriteLine("Key is: " + item.Key + " Value is :" + item.Value);
            }



        }

        public void StackOperation()
        {
            Stack objStack = new Stack();

            //Add
            objStack.Push(100);
            objStack.Push(200);   
            objStack.Push(300);
            objStack.Push(400);

            //peek
             int varpeek1 = Convert.ToInt32(objStack.Peek());// take out and but don't delete
            int varpeek2 = Convert.ToInt32(objStack.Peek());
            int varpeek3= Convert.ToInt32(objStack.Peek());
            int varpeek4 = Convert.ToInt32(objStack.Peek());

            // take out value
            int var1 = Convert.ToInt32(objStack.Pop());// take out and delete
            int var2 = Convert.ToInt32(objStack.Pop());
            int var3= Convert.ToInt32(objStack.Pop());
            int var4 = Convert.ToInt32(objStack.Pop());


            //other method are same
            int count = objStack.Count;

            objStack.Contains(var1);
            objStack.Clear();


        }//LIFO

        public void QueueOperation()//FIFO
        {
            Queue objQueue = new Queue();

            //Add
            objQueue.Enqueue(100);
            objQueue.Enqueue("abc");
            objQueue.Enqueue(300);
            objQueue.Enqueue(400);

            //peek
            int peek1 = Convert.ToInt32(objQueue.Peek());
            string peek2 = Convert.ToString(objQueue.Peek());
            int peek3 = Convert.ToInt32(objQueue.Peek());
            int peek4 = Convert.ToInt32(objQueue.Peek());

            // dequeue
            int var1 = Convert.ToInt32(objQueue.Dequeue());//return value and delete it.
            string var2 = Convert.ToString(objQueue.Dequeue());
            int var3 = Convert.ToInt32(objQueue.Dequeue());
            int var4 = Convert.ToInt32(objQueue.Dequeue());


        }
    }

    
}
