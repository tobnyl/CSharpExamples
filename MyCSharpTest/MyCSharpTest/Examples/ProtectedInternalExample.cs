using AssemblyOne;

namespace MyCSharpTest.Examples
{
    class ProtectedInternalExample
    {
        AssemblyOneClassI _ao1 = new AssemblyOneClassI();
        A01Child _a01C = new A01Child();
    }

    class A01Child : AssemblyOneClassI
    {
        // AssemblyOneClassI resides in another assembly, since ID is 'protected internal' it can be
        // accessed in derived classes outside the assembly
        public A01Child()
        {
            this.ID = 10;
        }
    }
}
