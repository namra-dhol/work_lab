using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamDemo
{
    internal class Vehicle
    {
        string model;
        string brand;
        string speed;
        
        public Vehicle()
        {
            Console.WriteLine("enter model type");
            model = Console.ReadLine();
            Console.WriteLine("enter brand type");
            brand = Console.ReadLine();
            Console.WriteLine("enter speed type");
            speed = Console.ReadLine();
        }
        public virtual void displayDetails()
        {
            Console.WriteLine(model);
            Console.WriteLine(brand);
            Console.WriteLine(speed);
        }

        public class Car : Vehicle
        {
            string fuleType;
            public Car()
            {
                Console.WriteLine("enter fuel type");
                fuleType = Console.ReadLine();  
            }

            public override void displayDetails()
            {
                Console.WriteLine(model);
                Console.WriteLine(brand);
                Console.WriteLine(speed);
                Console.WriteLine(fuleType);
            }
        }
        public class Bike : Vehicle {
            string Wheeltype;
            public Bike() {
                Console.WriteLine("enter fuel type");
                Wheeltype = Console.ReadLine();
            }

            public override void displayDetails()
            {
                Console.WriteLine(model);
                Console.WriteLine(brand);
                Console.WriteLine(speed);
                Console.WriteLine(Wheeltype);
            }

        }
    }
}
