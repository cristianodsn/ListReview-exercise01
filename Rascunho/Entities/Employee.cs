using System.Globalization;
namespace Rascunho.Entities
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; private set; }

        public Employee(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void IncreaseSalary(double percentage)
        {
            Salary += (Salary / 100 * percentage);
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Salary: {Salary.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
