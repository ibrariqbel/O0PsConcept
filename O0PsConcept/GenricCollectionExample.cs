using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O0PsConcept
{
    public class GenricCollectionExample
    {
        public void ListOperation()
        {
            // Declaration
            List<string> lstString = new List<string>();

            // insertion
            List<string> lstString2 = new List<string>() { "abc", "fgh","ijk"};

            // insertion
            lstString.Add("Apple");
            lstString.Add("Mango");
            lstString.Add("Oringe");
            lstString.Add("Banana");

            // read from the list
            string fruit1 = lstString[0];
            string fruit2 = lstString[1];
            string fruit3 = lstString[2];
            string fruit4 = lstString[3];

            foreach(string str in lstString)
            {
                Console.WriteLine(str);
            }


            // update
            lstString[2] = "Greyfruit";

            //remove
            lstString.Remove("Apple");
            lstString.RemoveAt(2);
            lstString.Clear();

            // contain , count
            int count = lstString.Count;
            bool isExit = lstString.Contains("Apple");


           
        }

        public void DictionaryExample()
        {
            // Declaration
            Dictionary<int , string> dicString = new Dictionary<int , string>();

            // insert the Data
            dicString.Add(1, "Ibrar");
            dicString.Add(2, "Ali");
            dicString.Add(3, "Shah");
            dicString.Add(4, "Ibrahim");

            // read the data
            string value1 = dicString[2];
            
           foreach(KeyValuePair<int , string> kvp in dicString)
            {
                Console.WriteLine("key is" +  kvp.Key + "value is" + kvp.Value);
            }

        }

        public void StackExample()
        {
            // Declare
            Stack<string> objStack = new Stack<string>();
            
            // push
            objStack.Push("a");
            objStack.Push("b");
            objStack.Push("c");
            objStack.Push("d");

            // peek
            objStack.Peek();
            objStack.Peek();
            objStack.Peek();
            objStack.Peek();

            //  pop
            objStack.Pop();
            objStack.Pop();
            objStack.Pop();

        }

        public void QueueExample()
        {
            // Declaration
            Queue<string> queue = new Queue<string>();

            // insertion
            queue.Enqueue("a");
            
            queue.Enqueue("b");
            queue.Enqueue("c");
            queue.Enqueue("d");

            //Dequeue
            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();

            //peek
            queue.Peek();
            queue.Peek();

        }


    }
}
