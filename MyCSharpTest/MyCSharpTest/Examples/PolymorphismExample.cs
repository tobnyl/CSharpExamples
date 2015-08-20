using System;

namespace MyCSharpTest.Examples
{    
    class PolymorphismExample
    {
        public PolymorphismExample()
        {
            Employee[] employees = new Employee[4];

            // Polymorphism allows you to invoke derived class methods through base class reference during runtime.
            // In the base class the method is declared 'virtual', and in the derived class we 'override' the same method.
            // The 'virtual' keyword indicates, the method can be overridden in any derived class.
            employees[0] = new Employee();
            employees[1] = new PartTimeEmployee();
            employees[2] = new FullTimeEmployee();
            employees[3] = new TemporaryEmployee();

            foreach (Employee e in employees)
            {
                e.PrintFullName();
            }
        }
    }

    #region classes

    public class Employee
    {
        public string FirstName = "FN";
        public string LastName = "LN";

        public virtual void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
    }

    public class PartTimeEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName + " - Part Time");            
        }
    }

    public class FullTimeEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName + " - Full Time");
        }
    }

    public class TemporaryEmployee : Employee
    {
        // If no overridden method, the base class method is used.
    }

    #endregion
}
