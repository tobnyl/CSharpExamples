using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharpTest.Examples.Delegate
{
    class Delegates2Example
    {
        public Delegates2Example()
        {
            List<Employee> empList = new List<Employee>();

            empList.Add(new Employee(){ID = 101, Name = "Mary", Salary = 5000, Experience = 5});
            empList.Add(new Employee() { ID = 102, Name = "Mike", Salary = 4000, Experience = 4 });
            empList.Add(new Employee() { ID = 103, Name = "John", Salary = 6000, Experience = 6 });
            empList.Add(new Employee() { ID = 104, Name = "Todd", Salary = 3000, Experience = 3 });

            Employee.PromoteEmployee(empList);
        }
    }

    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

        public static void PromoteEmployee(List<Employee> employees)
        {
            foreach (var employee in employees)
            {
                if (employee.Experience >= 5)
                {
                    Console.WriteLine(employee.Name + " promoted");
                }
            }
        }
    }
}
