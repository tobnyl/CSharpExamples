using System;

namespace MyCSharpTest.Examples
{
    class StructsVsClassesExample
    {
        public StructsVsClassesExample()
        {
            Console.WriteLine("1. Structs can't have destructors.");
            Console.WriteLine("2. Structs cannot have explicit parameterless constructor.");
            Console.WriteLine("3. Structs can't inherit from another class, but can inherit from an interface");
            Console.WriteLine("4. A class or a struct cannot inherit from another struct...");
            Console.WriteLine("         ...because structs are 'sealed' types.");
        }
    }
}
