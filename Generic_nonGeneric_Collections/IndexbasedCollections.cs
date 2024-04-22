using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_nonGeneric_Collections
{
    public class IndexbasedCollections
    {
        public ArrayList arrayListdemo()
        {
            ArrayList al = new ArrayList();
            int i = 10; double d = 20.234; string s = "ArrayList";
            al.Add(i);
            al.Add(d);
            al.Add(s);

            return al;
        }
        public List<string> listdemo()
        {
            List<string> li = new List<string>();
            string s = "List";
            li.Add("ListElementOne");
            li.Add("ListElementTwo");
            li.Add(s);

            return li;
        }
    }
}
