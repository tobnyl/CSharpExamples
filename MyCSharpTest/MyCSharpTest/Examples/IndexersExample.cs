using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharpTest.Examples.Indexer
{
    class IndexersExample
    {
        public IndexersExample()
        {
            var company = new Company();

            // Call indexer...
            Console.WriteLine(company[2]);

            // Set value with indexer
            company[2] = "Pamela";

            Console.WriteLine(company[2]);

            Console.WriteLine();
            Console.WriteLine("Before Update:");
            Console.WriteLine();
            Console.WriteLine("Total Male Employees: " + company["Male"]);
            Console.WriteLine("Total Female Employees: " + company["Female"]);

            company["Female"] = "Male";

            Console.WriteLine();
            Console.WriteLine("After Update:");
            Console.WriteLine();
            Console.WriteLine("Total Male Employees: " + company["Male"]);
            Console.WriteLine("Total Female Employees: " + company["Female"]);
        }
    }

    class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }

    }

    class Company
    {
        private List<Employee> listEmployees;

        public Company()
        {
            listEmployees = new List<Employee>();

            listEmployees.Add(new Employee { EmployeeId = 1, Name = "Mike", Gender = "Male" });
            listEmployees.Add(new Employee { EmployeeId = 2, Name = "Pam", Gender = "Female" });
            listEmployees.Add(new Employee { EmployeeId = 3, Name = "John", Gender = "Male" });
            listEmployees.Add(new Employee { EmployeeId = 4, Name = "Maxine", Gender = "Female" });
            listEmployees.Add(new Employee { EmployeeId = 5, Name = "Emiliy", Gender = "Female" });
            listEmployees.Add(new Employee { EmployeeId = 6, Name = "Scott", Gender = "Male" });
            listEmployees.Add(new Employee { EmployeeId = 7, Name = "Todd", Gender = "Male" });
            listEmployees.Add(new Employee { EmployeeId = 8, Name = "Ben", Gender = "Male" });
        }

        // Indexer
        public string this[int employeeId]
        {
            get
            {
                return listEmployees.FirstOrDefault(x => x.EmployeeId == employeeId).Name;
            }
            set
            {
                listEmployees.FirstOrDefault(x => x.EmployeeId == employeeId).Name = value;
            }
        }

        public string this[string gender]
        {
            get { return listEmployees.Count(x => x.Gender == gender).ToString(); }
            set
            {
                foreach (var employee in listEmployees)
                {
                    if (employee.Gender == gender)
                    {
                        employee.Gender = value;
                    }
                }
            }
        }
    }
}
