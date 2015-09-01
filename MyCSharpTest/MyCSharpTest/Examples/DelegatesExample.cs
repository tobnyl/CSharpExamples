using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharpTest.Examples
{
    // A delegate is a type safe function pointer
    // This delegate can point to any function that has void return type and
    // string parameter
    public delegate void HelloFunctionDelegate(string message);

    class DelegatesExample
    {        
        public DelegatesExample()
        {
            HelloFunctionDelegate del = Hello; // new HelloFunctionDelegate(Hello);

            del("Hello from Delegate!");
        }

        public static void Hello(string strMessage)
        {
            Console.WriteLine(strMessage);
        }
    }
}
