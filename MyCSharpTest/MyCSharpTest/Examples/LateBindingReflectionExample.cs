using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace MyCSharpTest.Examples
{
    class LateBindingReflectionExample
    {
        public LateBindingReflectionExample()
        {
            #region Late Binding

            // Create instance of Customer1 class
            Assembly executingAssembly = Assembly.GetExecutingAssembly();
            var customerType = executingAssembly.GetType(("MyCSharpTest.Examples.Customer1"));
            var customerInstance = Activator.CreateInstance(customerType);

            // Get method from class
            var getFullNameMethod = customerType.GetMethod("GetFullName");

            // Prepare parameters and invoke the method
            string[] parameters = new string[2];
            parameters[0] = "Tobias";
            parameters[1] = "Nylin";

            string fullName = (string)getFullNameMethod.Invoke(customerInstance, parameters);

            Console.WriteLine("Full Name: {0}", fullName);

            #endregion
            #region Early binding

            Customer1 c1 = new Customer1();
            fullName = c1.GetFullName("Tobias", "Nylin");
            Console.WriteLine("Full name: {0}", fullName);

            #endregion
        }
    }

    class Customer1
    {
        public string GetFullName(string firstName, string lastName)
        {
            return firstName + " " + lastName;
        }
    }
}
