using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamDemo
{
    internal class Employee
    {
        string name;
        string position;
        int salary;

        public Employee() {
            getEmployeeDetails();
            displayDetails();
        }   
        public void getEmployeeDetails()
        {
            Console.WriteLine("enter employee name:");
            name = Console.ReadLine();
            Console.WriteLine("enter employee position:");
            position = Console.ReadLine();
            Console.WriteLine("enter employee salary:");
            salary = Convert.ToInt32(Console.ReadLine());   
        }
        public void displayDetails()
        {
            Console.WriteLine("name:  " + name + "posoition:  " + position + "salary:  " + salary);
        }
    }
}
