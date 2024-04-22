using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_nonGeneric_Collections
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Collections demo");
            Console.WriteLine("***************************************************************");
            Console.WriteLine("Index Based Collections demo");

            IndexbasedCollections ibc = new IndexbasedCollections();
            Console.WriteLine("Non Generic Collection Demo");
            Console.WriteLine("ArrayList demo");

            ArrayList al = new ArrayList();
            al = ibc.arrayListdemo();

            foreach (object o in al)
                Console.WriteLine(o);
            Console.WriteLine("###########################################");

            Console.WriteLine("Generic Collection Demo");
            Console.WriteLine("List demo");

            List<string> li = new List<string>();
            li = ibc.listdemo();

            foreach (string o in li)
                Console.WriteLine(o);
            Console.WriteLine("###########################################");


            Console.WriteLine("***************************************************************");
            Console.WriteLine("Key Value Pair Collections demo");
            KeyValuePair_Collections kvp = new KeyValuePair_Collections();

            Console.WriteLine("Non Generic Collections demo");
            Console.WriteLine("HashTable Demo");
            Hashtable ht = new Hashtable();
            ht = kvp.HashtableDemo();

            foreach (DictionaryEntry d in ht)
                Console.WriteLine(d.Key + " " + d.Value);
            Console.WriteLine("###########################################");
            Console.WriteLine("Generic Collections demo");
            Console.WriteLine("Dicitonary Demo");
            Dictionary<int,string> di = new Dictionary<int, string>();
            di = kvp.DicitionaryDemo();

            foreach (KeyValuePair<int,string> k in di)
                Console.WriteLine(k.Key + " " + k.Value);
            Console.WriteLine("###########################################");

            Console.WriteLine("Non Generic Collections demo");
            Console.WriteLine("SortedList Demo");
            SortedList sl = new SortedList();
            sl = kvp.SortedListDemo();

            foreach (DictionaryEntry k in sl)
                Console.WriteLine(k.Key + " " + k.Value);
            Console.WriteLine("###########################################");

            Console.WriteLine("Generic Collections demo");
            Console.WriteLine("SortedList Demo");
            SortedList<int,string> slg = new SortedList<int, string>();
            slg = kvp.SortedListGenericDemo();

            foreach (KeyValuePair<int,string> k in slg)
                Console.WriteLine(k.Key + " " + k.Value);
            Console.WriteLine("###########################################");
            Console.WriteLine("***************************************************************");
            Console.WriteLine("Priority based Collections demo");

            PrioritybasedCollections pbc = new PrioritybasedCollections();

            Console.WriteLine("Non Generic Collections demo");
            Console.WriteLine("Stack Demo");
            Stack stk = new Stack();
            stk = pbc.StackCollectionsDemo();
            foreach (object o in stk)
                Console.WriteLine(o);
            Console.WriteLine("###########################################");

            Console.WriteLine("Generic Collections demo");
            Console.WriteLine("Stack Demo");
            Stack<string> stg = new Stack<string>();
            stg = pbc.StackGenericCollectionDemo();
            foreach (string o in stg)
                Console.WriteLine(o);
            Console.WriteLine("###########################################");

            Console.WriteLine("Non Generic Collections demo");
            Console.WriteLine("Queue Demo");
            Queue q = new Queue();
            q = pbc.QueueCollectionDemo();
            foreach (object o in q)
                Console.WriteLine(o);
            Console.WriteLine("###########################################");

            Console.WriteLine("Generic Collections demo");
            Console.WriteLine("Queue Demo");
            Queue<string> qu = new Queue<string>();
            qu = pbc.QueueGenericCollectionDemo();
            foreach (object o in qu)
                Console.WriteLine(o);
            Console.WriteLine("###########################################");

            
            Console.ReadKey();
        }
    }
}
