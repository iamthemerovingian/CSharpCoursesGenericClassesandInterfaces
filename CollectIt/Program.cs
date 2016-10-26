using System;
using System.Collections.Generic;

namespace CollectIt
{

    class Program
    {
        static void Main(string[] args)
        {
            var departments = new DepartmentCollection();

            departments.Add("Sales", new Employee { Name = "Dani" })
                       .Add("Sales", new Employee { Name = "Dani" })
                       .Add("Sales", new Employee { Name = "Joy" });

            departments.Add("Engineering", new Employee { Name = "Dani" })
                       .Add("Engineering", new Employee { Name = "Scott"})
                       .Add("Engineering", new Employee { Name = "Alex" });



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
