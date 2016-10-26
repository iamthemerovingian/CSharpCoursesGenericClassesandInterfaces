using System;
using System.Collections.Generic;

namespace CollectIt
{
    class Program
    {
        static void Main(string[] args)
        {
            var departments = new SortedDictionary<string, SortedSet<Employee>>();

            departments.Add("Sales", new SortedSet<Employee>(new EmployeeComparer()));
            departments["Sales"].Add(new Employee { Name = "Joy" });
            departments["Sales"].Add(new Employee { Name = "Dani" });
            departments["Sales"].Add(new Employee { Name = "Dani" });

            departments.Add("Engineering", new SortedSet<Employee>(new EmployeeComparer()));
            departments["Engineering"].Add(new Employee { Name = "Scott" });
            departments["Engineering"].Add(new Employee { Name = "Alex" });
            departments["Engineering"].Add(new Employee { Name = "Dani" });



            foreach (var department in departments)
            {
                Console.WriteLine(department.Key);
                foreach (var employee in department.Value)
                {
                    Console.WriteLine("\t" + employee.Name);
                }
            }

            //var employeesByName = new SortedList<string, List<Employee>>();

            //employeesByName.Add("Sales", new List<Employee> { new Employee(), new Employee(), new Employee() });
            //employeesByName.Add("Engineering", new List<Employee> { new Employee(), new Employee() });

            //foreach (var item in employeesByName)
            //{
            //    Console.WriteLine("The count of employees for {0} is {1}", 
            //                item.Key, item.Value.Count
            //            );
            //}

        }
    }
}
