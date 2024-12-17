using System;
using System.Collections;
using System.Collections.Generic; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Collection_Practice
{
    internal class GenericCollection
    {
        public static void ListDemo()
        {
            List<int> lst = new List<int>();
            lst.Add(10);
            lst.Add(20);
            lst.Add(30);
            lst.Add(40);

            foreach(int elements in lst)
            {
                Console.WriteLine(elements);
            }

        }
        public static void DictionaryDemo()
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(10, "Chetan");
            dict.Add(20, "Shivanand");
            dict.Add(30, "Pooja");

            foreach(KeyValuePair<int, string> element in dict)
            {
                Console.WriteLine(element);
            }

        }
        public static void SortedListDemo()
        {
            SortedList<string, string> slt = new SortedList<string, string>();
            slt.Add("laguage", "Csharp");
            slt.Add("FrameWork", "DotNet");
            slt.Add("WorkSpace", "visualStrudio");

            foreach(KeyValuePair<string, string> entry in slt)
            {
                Console.WriteLine(entry.Key + " -> " + entry.Value);
            }
        }
        public static void StackDemo()
        {
            Stack<double> s = new Stack<double>();
            s.Push(10.0);
            s.Push(15.6);
            s.Push(5.6);
            s.Push(2.4);

            foreach (double elemets in s)
            {
                Console.WriteLine(elemets);
            }
        }
        public static void QueueDemo()
        {
            Queue<int> q = new Queue<int>();
            q.Enqueue(10);
            q.Enqueue(15);
            q.Enqueue(20);
            q.Enqueue(30);

            foreach (int elemets in q)
            {
                Console.WriteLine(elemets);
            }
        }
    }
}
