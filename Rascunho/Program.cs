using System;
using System.Collections.Generic;
using System.Globalization;
using Rascunho.Entities;

class Program
{
    static void Main(string[] args)
    {
        List<Employee> employees = new List<Employee>();
        Console.Write("How many employee will be registered: ");
        int quantity = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("Employee data:");
        for (int i = 0; i < quantity; i++)
        {
            Console.WriteLine("Employee #" + (i + 1));
            Console.Write("Id: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Salary: ");
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            employees.Add(new Employee(id, name, salary));
            Console.WriteLine();
        }
        Console.Write("Enter the employee id that will have salary increase: ");
        int idIncrease = int.Parse(Console.ReadLine());
        
        Employee aux = employees.Find(x => x.Id == idIncrease);
        if (aux != null) 
        {
            Console.Write("Enter the percentage: ");
            double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aux.IncreaseSalary(percentage);
        }
        else
        {
            Console.WriteLine("Invalid Id.");
        }
        Console.WriteLine();

        Console.WriteLine("Update list of employyes:");
        foreach (Employee e in employees)
        {
            Console.WriteLine(e);
        }

        Console.ReadKey();
    }
}
