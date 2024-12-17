using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("----ArrayList----");
            //NonGenericCollection.ArrayListDemo();

            //Console.WriteLine("------HashTable-----");
            //NonGenericCollection.HashTableDemo();

            //Console.WriteLine("------SortedList-----");
            //NonGenericCollection.SortedListDemo();

            //Console.WriteLine("------Stack-------");
            //NonGenericCollection.StackDemo();

            //Console.WriteLine("------Queue-------");
            //NonGenericCollection.QueueDemo();

            Console.WriteLine("Generic type of Collections");
            Console.WriteLine("1.List");
            GenericCollection.ListDemo();

            Console.WriteLine("2.Dictionary");
            GenericCollection.DictionaryDemo();

            Console.WriteLine("3.SortedList");
            GenericCollection.SortedListDemo();

            Console.WriteLine("4.Stack");
            GenericCollection.StackDemo();

            Console.WriteLine("5.Queue");
            GenericCollection.QueueDemo();
        }
    }
}
