using System;

namespace MyCSharpTest.Examples
{
    class ParamsExample
    {
        public ParamsExample()
        {
            PrintNumbers(1, 2, 3, 4, 5);
        }

        public static void PrintNumbers(params int[] numbers)
        {
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }
        }
    }


}
