
namespace Main
{
    record Employee
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Possion { get; set; }
        public decimal Salary { get; set; }
    }
    class Department
    {
        public Employee[] Employees { get; set; }
        public string Name { get; set; }
    }
    class Company
    {
        public string Name { get; set; }

        public string Info { get; set; }
        public Department[] Departments { get; set; }
    }
}
