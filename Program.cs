using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        List<Employee> employees = new List<Employee>();
        for (int i = 0; i < N; i++)
        {
            string[] input = Console.ReadLine().Split(" ").ToArray();
            employees.Add(new Employee(input[0], int.Parse(input[1])));
        }

        foreach (Employee employee in employees)
        {
            employee.Age += 1;
            Console.WriteLine($"{employee.Name} {employee.Age}");
        }
    }

    class Employee
    {
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; } = 0;
        public Employee(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
    }
}