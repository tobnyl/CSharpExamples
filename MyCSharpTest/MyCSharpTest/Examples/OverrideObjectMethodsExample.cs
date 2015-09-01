using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharpTest.Examples
{
    class OverrideObjectMethodsExample
    {
        public OverrideObjectMethodsExample()
        {
            // Object class has four methods that are available to every type

            // * Equals - can be overridden

            // * GetHashCode - can be overridden

            // * GetType

            // * ToString - can be overridden

            EqualsExample();
            //ToStringExample();
        }

        // ========================================================================================
        void EqualsExample()
        {
            // No need for overloading
            //Direction dir1 = Direction.East;
            //Direction dir2 = Direction.East;
            //Console.WriteLine(dir1 == dir2);
            //Console.WriteLine(dir1.Equals(dir2));

            Customer3 c1 = new Customer3();
            c1.FirstName = "Simon";
            c1.LastName = "Tan";

            Customer3 c2 = new Customer3();
            c2.FirstName = "Simon";
            c2.LastName = "Tan";

            Console.WriteLine(c1 == c2);
            Console.WriteLine(c1.Equals(c2));
        }

        // ========================================================================================
        void ToStringExample()
        {
            int number = 10;
            Console.WriteLine(number.ToString());

            Customer3 c1 = new Customer3();
            c1.FirstName = "Simon";
            c1.LastName = "Tan";

            Console.WriteLine(c1.ToString());
            Console.WriteLine(Convert.ToString(c1));
        }
    }

    public class Customer3
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // ========================================================================================
        public override int GetHashCode()
        {
            return FirstName.GetHashCode() ^ LastName.GetHashCode();
        }

        // ========================================================================================
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (!(obj is Customer3))
            {
                return false;
            }

            return FirstName == ((Customer3) obj).FirstName && LastName == ((Customer3) obj).LastName;
        }

        // ========================================================================================
        public override string ToString()
        {
            return FirstName + " " + LastName;
        }

        // ========================================================================================
        public static bool operator ==(Customer3 c1, Customer3 c2)
        {
            // If both are null, or both are same instance, return true
            if (System.Object.ReferenceEquals(c1, c2))
            {
                return true;
            }

            // If one is null, but not both, return false
            if (((object)c1) == null || ((object)c2) == null)
            {
                return false;
            }

            // Return true if the fields match:
            return c1.FirstName == c2.FirstName && c1.LastName == c2.LastName;
        }

        public static bool operator !=(Customer3 c1, Customer3 c2)
        {
            return !(c1 == c2);
        }
    }

    public enum Direction
    {
        East = 1,
        West = 2,
        North = 3,
        South = 4
    }
}
