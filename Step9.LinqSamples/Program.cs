using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Step9.LinqSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            //ReadTextFile();
            //ReadTextFileUsingLinq();
            //WhereSample();
            WhereSampleWithRealExample();
            Console.ReadKey();
        }

        private static void ReadTextFileUsingLinq()
        {
            var lines = File.ReadLines("Students.txt");
            var students = lines.Select(c =>
            {
                var data = c.Split(',');
                return new Student
                {
                    Id = int.Parse(data[0]),
                    Name = data[1],
                    Family = data[2],
                    Branch = data[3]
                };
            });
            foreach (var item in students)
            {
                Console.WriteLine($"{item.Id}  {item.Name}  {item.Family}  {item.Branch}");
            }
        }

        private static void ReadTextFile()
        {
            var lines = File.ReadLines("Students.txt");
            var students = new List<Student>();
            foreach (var item in lines)
            {
                var data = item.Split(',');
                Student student = new Student();
                student.Id =int.Parse(data[0]);
                student.Name = data[1];
                student.Family = data[2];
                student.Branch = data[3];
                students.Add(student);
            }
           
            foreach (var item in students)
            {
                Console.WriteLine($"{item.Id}  {item.Name}  {item.Family}  {item.Branch}");
            }
        }

        private static void WhereSampleWithRealExample()
        {
            Employee employee = new Employee();
            var employeeAnnualSalary = employee.GetEmployees()
                .Where(c => c.Salary > 2500 && c.Gender == "Male")
                .Select(emp => new
                {
                    EmpId = emp.EmployeeId,
                    EmpName = emp.Name,
                    TotalSalary = emp.Salary * 12

                }).OrderByDescending(emp => emp.TotalSalary);           
            foreach (var item in employeeAnnualSalary)
            {
                Console.WriteLine($"Employee Id={item.EmpId}  Name={item.EmpName}  Annual Salary={item.TotalSalary}");
            }
        }
        private static void WhereSample()
        {
            List<int> numbers = new List<int> { 1, 5, 4, 10, 15, 17, 19, 20, 21 };
            Console.Write("{");
            foreach (var item in numbers)
            {
                Console.Write(item+",");
            }
            Console.WriteLine("}");

            var OddNumberWithPosition = numbers.Select((number, index) => new
            {
                numbers = number,
                IndexPosition1 = index
            }).Where(c => c.numbers % 2 != 0).Select(c => new
            {
                Numbers=c.numbers,
                IndexPosition=c.IndexPosition1
            });
            foreach (var item in OddNumberWithPosition)
            {
                Console.WriteLine($"Index Position={item.IndexPosition} , Value={item.Numbers}");
            }
        }
    }
}
