using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Hospital
    {
        public virtual void hospitalDetails()
        {
            Console.WriteLine("enter hospital name :");
            string p = Console.ReadLine();
            Console.WriteLine("enter checking price :");
            int r = Convert.ToInt32(Console.ReadLine());

        }
    }
    class Apollo : Hospital {
        public override void hospitalDetails() {
            Console.WriteLine("appolo hospital called");
            string  p = "appolo";
            Console.WriteLine(p);
        }
    }
    class Wockhardt : Hospital
    {
        public override void hospitalDetails()
        {
            Console.WriteLine("Wockhardt hospital called");
            string p = "Wockhardt";
            Console.WriteLine(p);
        }
    }
    class Gokul_Superspeciality : Hospital
    {
        public override void hospitalDetails()
        {
            Console.WriteLine("Gokul_Superspeciality hospital called");
            string p = "Gokul_Superspeciality";
            Console.WriteLine(p);
        }
    }
}