using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharpTest.Examples
{
    class GenericsExample
    {
        public GenericsExample()
        {
            Console.WriteLine(Calculator1.AreEqual<string>("A", "A") ? "Equal" : "Not Equal");
            Console.WriteLine(Calculator2<string>.AreEqual("A", "A") ? "Equal" : "Not Equal");
        }

        public class Calculator1
        {
            public static bool AreEqual<T>(T value1, T value2)
            {
                return value1.Equals(value2);
            }

            // AVOID!: Not strongly-typed, performance degredation due to boxing and unboxing
            public static bool AreEqual(object value1, object value2)
            {
                return value1 == value2;
            }
        }

        public class Calculator2<T>
        {
            public static bool AreEqual(T value1, T value2)
            {
                return value1.Equals(value2);
            }
        }
    }
}
