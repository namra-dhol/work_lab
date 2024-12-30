using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Rbi
    {
        public virtual void calculateInterest()
        {
            Console.WriteLine("enter p:");
            int p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter r:");
            int r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter n:");
            int n = Convert.ToInt32(Console.ReadLine());
            int intrest = (p * r * n) / 100;
            Console.WriteLine(intrest);
        }

    }
    class Hdfc : Rbi
    {
        public override void calculateInterest()
        {
            Console.WriteLine("hdfc method called:");
        }
    }
        class Sbi : Rbi
        {
            public override void calculateInterest()
            {

            Console.WriteLine("sbi called:");
            }
        }
        class ICICI : Rbi
        {
            public override void calculateInterest()
            {
            Console.WriteLine("icici banked called:");
            }
        }
    }

