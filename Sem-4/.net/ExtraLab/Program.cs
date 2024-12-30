using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            {
                // Create an Employee instance
                Employee emp = new Employee("John Doe", 5000, 2000, 3000);

                // Display Salary Details
                emp.Disp_sal();

                // Calculate and display Gross Salary
                emp.Gross_sal();

                // Calculate and display Basic Salary
                emp.Basic_sal();
            }
        }
    }
}
