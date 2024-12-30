using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamDemo
{
    internal abstract class Emp
    {
        double hoursWorked;
        double salary;
        double hourlyrate;
        public abstract void calculateSalary();
        public abstract void displayEmpDetails();

        public class FullTimeEmp : Emp
        {
            double hoursWorked;
            double salary;
            double hourlyrate;
            public override void calculateSalary() {
                Console.WriteLine("enter hours worked :");
                 hoursWorked = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("enter your hourly rate:");
                 hourlyrate = Convert.ToDouble(Console.ReadLine());
                 salary = hoursWorked * hourlyrate;
            }
            public override void displayEmpDetails() {
                Console.WriteLine("emp worked for :" + hoursWorked + "emp hourly rate is : " + hourlyrate + " so the emp slary is : " + salary);
            }
        }
    }
}