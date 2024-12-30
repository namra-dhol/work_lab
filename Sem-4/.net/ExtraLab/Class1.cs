
namespace ExtraLab
{
    using System;

    // Define Interface: Gross
    interface IGross
    {
        void Gross_sal();
    }

    // Define Class: Salary
    class Salary
    {
        public double HRA;
        public double TA;
        public double DA;

        public void Disp_sal()
        {
            Console.WriteLine($"HRA: {HRA}, TA: {TA}, DA: {DA}");
        }
    }

    // Define Class: Employee
    class Employee : Salary, IGross
    {
        public string Name;

        public Employee(string name, double hra, double ta, double da)
        {
            Name = name;
            HRA = hra;
            TA = ta;
            DA = da;
        }

        // Implement Gross_sal from IGross interface
        public void Gross_sal()
        {
            double grossSalary = HRA + TA + DA;
            Console.WriteLine($"Gross Salary for {Name}: {grossSalary}");
        }

        public void Basic_sal()
        {
            double basicSalary = HRA + TA + DA;
            Console.WriteLine($"Basic Salary for {Name}: {basicSalary}");
        }
    }

   
}