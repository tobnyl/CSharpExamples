using System;

namespace MyCSharpTest.Examples
{
    class ExplicitInterfacesExample
    {
        public ExplicitInterfacesExample()
        {
            Program p = new Program();

            // Calls the default
            p.InterfaceMethod();

            // Explicit call
            ((I1) p).InterfaceMethod();
            ((I2)p).InterfaceMethod();

            // Explicit call
            I1 i1 = new Program();
            i1.InterfaceMethod();

            I2 i2 = new Program();
            i2.InterfaceMethod();
        }        
    }

    public class Program : I1, I2
    {        
        // Implement default
        public void InterfaceMethod()
        {
            Console.WriteLine("I1 Interface Method");
        }

        // Explicit: not allowed to use the access modifier, 
        // and you have to use the interface-name before the method-name
        void I2.InterfaceMethod()
        {
            Console.WriteLine("I2 Interface Method");
        }
    }

    interface I1
    {
        void InterfaceMethod();
    }

    interface I2
    {
        void InterfaceMethod();
    }
}
