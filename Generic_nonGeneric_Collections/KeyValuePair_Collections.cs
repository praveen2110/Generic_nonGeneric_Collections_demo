using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_nonGeneric_Collections
{
    public class KeyValuePair_Collections
    {
        public Hashtable HashtableDemo()
        {
            Hashtable ht = new Hashtable();
            ht.Add(1, "C#");
            ht.Add(2, "Asp.Net MVC");
            ht.Add(3, "SQL Server");

            return ht;

        }

        public Dictionary<int,string> DicitionaryDemo()
        {
            Dictionary<int, string> d = new Dictionary<int, string>();
            d.Add(1, "C#");
            d.Add(2, "Asp.Net MVC");
            d.Add(3, "SQL Server");

            return d;
        }

        public SortedList SortedListDemo()
        {
            SortedList sl = new SortedList();
            sl.Add("SQL","SQL Server");
            sl.Add("MVC","ASP.net MVC");
            sl.Add("C","C#");
            sl.Add("A","ASP.Net");
            return sl;
        }

        public SortedList<int,string> SortedListGenericDemo()
        {
            SortedList<int, string> sl = new SortedList<int, string>();
            sl.Add(5, "SQL Server");
            sl.Add(3, "ASP.net MVC");
            sl.Add(1, "C#");
            sl.Add(2, "ASP.Net");
            return sl;
        }
    }
}
