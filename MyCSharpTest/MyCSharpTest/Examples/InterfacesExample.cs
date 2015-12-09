using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace MyCSharpTest
{
    class InterfacesExample
    {
        public InterfacesExample()
        {
            var customer = new Customer();
            customer.Print1();
            customer.Print2();

            // We cannot create an instance of an interface            
            //ICustomer1 cust = new ICustomer1();

            // BUT an interface reference variable can point to a derived class object
            ICustomer1 cust = new Customer();
            cust.Print1();

            // Will not work, since ref is only of ICustomer1
            //cust.Print2();

            IEnumerable<int> ie = new List<int>();
        }
    }

    public class BaseClass
    {
        public BaseClass()
        {
            Console.WriteLine("Base class constructor...");
        }
    }

    // Hoover over the 'I2' and select 'Implement interface I2'
    public class Customer : BaseClass, ICustomer2
    {
        public void Print2()
        {
            Console.WriteLine("Print2");
        }

        public void Print1()
        {
            Console.WriteLine("Print1");
        }
    }

    // Interface members are 'public' by default, you cannot have explicit access modifiers
    // Interface cannot have 'fields'
    interface ICustomer1
    {
        void Print1();
    }

    interface ICustomer2 : ICustomer1
    {
        void Print2();
    }
}
