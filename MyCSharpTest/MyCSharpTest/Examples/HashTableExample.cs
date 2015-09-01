using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace MyCSharpTest.Examples
{
    class HashTableExample
    {
        public HashTableExample()
        {
            Hashtable mTable = new Hashtable();
            mTable.Add(100, "Bryan");
            mTable.Add(101, "Heather");
            mTable.Add(99, "Cat");

            mTable.Remove(101);

            foreach (int id in mTable.Keys)
            {
                Console.WriteLine(id);
            }


            if (mTable.ContainsKey(101))
            {
                Console.WriteLine(mTable[101]);
            }
        }
    }
}
