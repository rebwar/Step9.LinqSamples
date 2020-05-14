using System.Collections.Generic;

namespace Step9.LinqSamples
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public string Gender { get; set; }
        public List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee{EmployeeId=1,Name="Ali",Gender="Male",Salary=3000},
                new Employee{EmployeeId=2,Name="Rebwar",Gender="Male",Salary=4000},
                new Employee{EmployeeId=3,Name="Maryam",Gender="Female",Salary=5000},
                new Employee{EmployeeId=4,Name="Sara",Gender="Female",Salary=3000},
                new Employee{EmployeeId=5,Name="Hasan",Gender="Male",Salary=4500},
                new Employee{EmployeeId=6,Name="Akbar",Gender="Male",Salary=2000},
                new Employee{EmployeeId=7,Name="Rojin",Gender="Female",Salary=2700},

            };
            return employees;
        }
    }
}
