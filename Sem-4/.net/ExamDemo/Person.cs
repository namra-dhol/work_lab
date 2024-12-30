using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamDemo
{
    internal class Person
    {
        string name;
        int age;


        public  virtual void displayDetails() {
            Console.WriteLine("enter employee name:");
            name = Console.ReadLine();
            Console.WriteLine("name : "+name);
;          
            Console.WriteLine("enter employee age:");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("age : " + age);
        }
        public class EmpDemo : Person
        {
            int EmployeeID;
            int salary;

            public override void displayDetails() {

                Console.WriteLine("enter employee EmpId:");
                EmployeeID = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("EmployeeID : " + EmployeeID);
                Console.WriteLine("enter employee salary:");
                salary = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("salary : " + salary);



            }
        }
        public class Manager : Person
        {
            string department;
      

            public override void displayDetails()
            {
                Console.WriteLine("enter employee EmpId:");
                department = Console.ReadLine();
                Console.WriteLine("department : " + department);

            }
        }


    }

   
}
