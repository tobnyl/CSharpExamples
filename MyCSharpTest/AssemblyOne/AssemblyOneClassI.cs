using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyOne
{
    public class AssemblyOneClassI
    {
        protected internal int ID = 101;
    }

    class Test
    {
        private AssemblyOneClassI a01;

        Test()
        {
            a01 = new AssemblyOneClassI()
            {
                ID = 5
            };
        }
    }
}
