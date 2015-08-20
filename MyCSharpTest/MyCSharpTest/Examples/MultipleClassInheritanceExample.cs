using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharpTest.Examples
{
    class MultipleClassInheritanceExample
    {
        public MultipleClassInheritanceExample()
        {
            //D d = new D();
            //d.Print();
        }
    }

    class A
    {
        public virtual void Print()
        {
            Console.WriteLine("A Implementation");
        }
    }

    class B : A
    {
        public override void Print()
        {
            Console.WriteLine("B Implementation");
        }
    }

    class C : A
    {
        public override void Print()
        {
            Console.WriteLine("C Implementation");
        }
    }

    //class D : B, C
    //{
        
    //}
}
