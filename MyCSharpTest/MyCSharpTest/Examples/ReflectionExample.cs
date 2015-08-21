using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharpTest.Examples
{
    class ReflectionExample
    {
        public ReflectionExample()
        {
            var t = Type.GetType("MyCSharpTest.Examples.Customer");
            //var t = typeof(Customer);
            //var c1 = new Customer(); var t = c1.GetType();

            Console.WriteLine("Full Name: {0}", t.FullName);
            Console.WriteLine("Name: {0}", t.Name);
            Console.WriteLine("Namespace: {0}", t.Namespace);

            var properties = t.GetProperties();
            Console.WriteLine("\nProperties in {0}:", t.Name);
            Console.WriteLine("============================================");
            foreach (var property in properties)
            {                
                Console.WriteLine(property.PropertyType.Name + " " + property.Name);
            }

            var methods = t.GetMethods();
            Console.WriteLine("\nMethods in {0}:", t.Name);
            Console.WriteLine("============================================");
            foreach (var method in methods)
            {
                var sb = new StringBuilder();
                var parameters = method.GetParameters();

                sb.Append(method.ReturnType.Name + " " + method.Name + "(");

                foreach (var parameter in parameters)
                {
                    sb.Append(parameter.ParameterType.Name + " " + parameter.Name);
                    sb.Append(!parameter.Equals(parameters.Last()) ? ", " : "");
                }

                sb.Append(")");
                sb.Replace("Int32", "Int");                               

                Console.WriteLine(sb.ToString());
            }

            var constructors = t.GetConstructors();
            Console.WriteLine("\nConstructors in {0}:", t.Name);
            Console.WriteLine("============================================");
            foreach (var constructor in constructors)
            {
                var sb = new StringBuilder();
                var parameters = constructor.GetParameters();

                sb.Append(t.Name + "(");

                foreach (var parameter in parameters)
                {
                    sb.Append(parameter.ParameterType.Name + " " + parameter.Name);
                    sb.Append(!parameter.Equals(parameters.Last()) ? ", " : "");
                }

                sb.Append(")");
                sb.Replace("Int32", "Int");     

                Console.WriteLine(sb.ToString());
            }
        }
    }

    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Customer(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public Customer()
        {
            this.Id = -1;
            this.Name = string.Empty;
        }

        public void PrintId()
        {
            Console.WriteLine("ID = {0}", this.Id);
        }

        public void PrintName()
        {
            Console.WriteLine("Name = {0}", this.Name);
        }

        public int Sum(int x, int y)
        {
            return x + y;
        }
    }
}
