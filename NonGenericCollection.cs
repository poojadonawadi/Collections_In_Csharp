using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collection_Practice
{
    internal class NonGenericCollection
    {
        public static void ArrayListDemo()
        {
            ArrayList lst = new ArrayList();
            lst.Add(10);
            lst.Add("List");
            lst.Add(10.5);
            lst.Add(DateTime.Now);

            foreach(var element in lst)
            {
                Console.WriteLine(element);
            }
        }

        public static void HashTableDemo()
        {
            Hashtable ht = new Hashtable();
            ht.Add(101, "Hii");
            ht.Add("Name", "Pooja");
            ht.Add("CTC", 10);

            foreach (DictionaryEntry entry in ht)
            {
                Console.WriteLine(entry.Key+" -> "+entry.Value);
            }
        }
        public static void SortedListDemo()
        {
            SortedList slt = new SortedList();
            slt.Add(01, "Csharp");
            slt.Add(02, "DotNet");
            slt.Add(03, "visualStrudio");
            
            foreach(DictionaryEntry entry in slt)
            {
                Console.WriteLine(entry.Key + " -> " + entry.Value);
            }
        }

        public static void StackDemo()
        {
            Stack s = new Stack();
            s.Push(10);
            s.Push(15.6);
            s.Push("Tom");
            s.Push('A');
            s.Push(16);

            foreach(var elemets in s)
            {
                Console.WriteLine(elemets);
            }
        }
        public static void QueueDemo()
        {
            Queue q = new Queue();
            q.Enqueue(10);
            q.Enqueue(15.6);
            q.Enqueue("Tom");
            q.Enqueue('A');

            foreach (var elemets in q)
            {
                Console.WriteLine(elemets);
            }
        }

    }
}
