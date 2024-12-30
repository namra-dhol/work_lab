using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamDemo
{
    internal class ConvertValue
    {
        double miles;
        double kilo;
        double gallons;
        double liters;
        double pounds;
        int a;
        public ConvertValue() { 
             Console.WriteLine("enter a 1 for convert kilo to miles");
           
            Console.WriteLine("enter a 2  for convert pounds to kilo");
          
            Console.WriteLine("enter a 3  for convert Liters to Gallons");

             int a = Convert.ToInt32(Console.ReadLine());   
            switch (a)
            {
                case 1:
                    kilo = Convert.ToDouble(Console.ReadLine());
                    miles = kilo * 0.621371;
                    Console.WriteLine(miles);
                    break;
                case 2:
                    pounds = Convert.ToDouble(Console.ReadLine());
                    kilo = pounds * 0.621371;
                    Console.WriteLine(kilo);
                    break;
                case 3:
                    liters = Convert.ToDouble(Console.ReadLine());
                    gallons = liters * 0.621371;
                    Console.WriteLine(gallons);
                    break;
            }
        }
}
}