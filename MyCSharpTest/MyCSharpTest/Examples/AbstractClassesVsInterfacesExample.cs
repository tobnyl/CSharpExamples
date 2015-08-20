﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharpTest.Examples
{
    class AbstractClassesVsInterfacesExample
    {
        public AbstractClassesVsInterfacesExample()
        {
            Console.WriteLine("1. Abstract classes can have implementations for some of its members (Methods), but the interface can't have implementation for any of its members.\n");            
            Console.WriteLine("2. Interfaces cannot have fields where as an abstract class can have field.s\n");
            Console.WriteLine("3. An interface can inherit from another interface only and cannot inherit from an abstract class, where as an abstract class can inherit from another abstract class or another interface.\n");
            Console.WriteLine("4. A class can inherit from multiple interfaces at the same time, where as a class cannot inherit from multiple classes at the same time.\n");
            Console.WriteLine("5. Abstract class members can have access modifiers where as interface members cannot have access modifiers.");
        }
    }
}
