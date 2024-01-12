// See https://aka.ms/new-console-template for more information




using Main;
using System;
using System.Security.Cryptography.X509Certificates;
using task10c_.NewFolder;

namespace MyNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            Company alif = new Company();
            alif.Name = "Alif";

            Department department = new Department();
            department.Name = "IT";

            alif.Departments = new Department[] { department };

            Employee employee = new Employee();
            employee.Name = "Navruz";
            employee.LastName = "Komilov";
            employee.Possion = ".net developer";
            employee.Salary = 5000;

            department.Employees= new Employee[] { employee };
            ShowCompanyFullInfo(alif);
        }
        static void ShowCompanyFullInfo(Company company) 
        {
            Console.WriteLine($"Company Name:{company.Name}");
            Console.WriteLine("Departmens:");
            foreach (var department in company.Departments)
            {
                Console.WriteLine($" Name:{department.Name}");
                Console.WriteLine(" Employees:");
                foreach (var employee in department.Employees)
                {
                    Console.WriteLine($" {employee.Name} {employee.LastName} {employee.Possion} {employee.Salary}");
                }
                Console.WriteLine("-------------");
            }
        }
    }
}