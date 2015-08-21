using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharpTest.Examples
{
    class EnumExample
    {
        public EnumExample()
        {
            short[] values = (short[])Enum.GetValues(typeof (Gender));

            foreach (var value in values)
            {
                var name = Enum.GetName(typeof(Gender), value);                

                Console.WriteLine("{0} - {1}", name, value);
            }

            // Enums are strongly typed constants. Hence, an explicit cast is needed to convert
            // from enum typ to an integral type and vice versa.
            Gender gender = (Gender)1;
            int number = (int)Gender.Unknown;

            // Also, an enum of one type cannot be implicitly assigned to an enum of another type 
            // even though the underlying value of their members are the same
            Gender gender2 = (Gender)Season.Winter;            

            // Possible formats: G, X, D, F
            Console.WriteLine("Format: " + Enum.Format(typeof (Season), 1, "F"));

            Console.WriteLine("Underlying Type: " + Enum.GetUnderlyingType(typeof(Gender)));

            Console.WriteLine("Is value defines: " + Enum.IsDefined(typeof(Gender), (short)42));

            Season season;
            if (Enum.TryParse("Winter", true, out season))
            {
                Console.WriteLine("The season exists...");
            }            
        }
    }

    // 'short' instead of default 'int'
    public enum Gender : short
    {
        Unknown = 1,
        Male = 32767, // maximum value for short, 32768 not possible with 'short'
        Female = 23
    }

    public enum Season
    {
        Winter = 1,
        Spring = 2,
        Summer = 3
    }
}
