using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_nonGeneric_Collections
{
    public class PrioritybasedCollections
    {
        public Stack StackCollectionsDemo()
        {
            Stack stk = new Stack();
            stk.Push("C#");
            stk.Push(10);
            stk.Push(20.234);
            return stk;
        }

        public Stack<string> StackGenericCollectionDemo()
        {
            Stack<string> stk = new Stack<string>();
            stk.Push("C#");
            stk.Push("Asp.Net");
            stk.Push("SQL Server");
            return stk;
        }

        public Queue QueueCollectionDemo()
        {
            Queue q = new Queue();
            q.Enqueue("C#");
            q.Enqueue(10);
            q.Enqueue(20.234);
            return q;
        }

        public Queue<string> QueueGenericCollectionDemo()
        {
            Queue<string> q = new Queue<string>();
            q.Enqueue("C#");
            q.Enqueue("Asp.Net");
            q.Enqueue("SQL Server");
            return q;
        }
    }

}
