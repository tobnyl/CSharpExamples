using System;

namespace MyCSharpTest.Examples
{
    class OverridingHidingExample
    {
        public OverridingHidingExample()
        {
            BaseClass b = new DerivedClass();
            ((DerivedClass)b).Print();
        }
    }

    #region classes

    public class BaseClass
    {
        public virtual void Print()
        {
            Console.WriteLine("I am a Base Class Print Method");
        }
    }

    public class DerivedClass : BaseClass
    {
        public new void Print()
        {
            Console.WriteLine("I am a Derived Class Print Method");
        }
    }

    #endregion
}
