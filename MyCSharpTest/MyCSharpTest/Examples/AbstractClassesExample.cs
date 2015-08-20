using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharpTest.Examples.AbstractClassesExample
{
    class AbstractClassesExample
    {
        public AbstractClassesExample()
        {
            Program p = new Program();
            p.Print();

            Customer c = new Program();
            c.Print();
        }
        
    }

    public class Program : Customer
    {
        // Override must be used
        public override void Print()
        {
            Console.WriteLine("1. An abstract class is incomplete and hence cannot be instantiated");
            Console.WriteLine("2. An abstract class can only be used as base class");
            Console.WriteLine("3. An abstract class cannot be sealed");
            Console.WriteLine("4. An abstract class may contain abstract members, but not mandatory");
            Console.WriteLine(("5. A non-abstract class derived from an abstract class must provide implementations for all inherited abstract members"));
        }
    }

    // Abstract classes can not be instantiated
    public abstract class Customer
    {
        // Non-abstract method
        public void Print1()
        {
            
        }

        public abstract void Print();
    }
}
