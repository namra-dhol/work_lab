using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Class1 c1 = new Class1();
            //int x = c1.add(2, 5);
            //Console.WriteLine(x);
            //float y = c1.add(2.5f, 5.5f);
            //Console.WriteLine(y);


            //Class2 c2 = new Class2();
            //int x = c2.area(6);
            //Console.WriteLine(x);
            //int y = c2.area(7,5);
            //Console.WriteLine(y);

            //Rbi r1 = new Rbi();
            //r1.calculateInterest();

            //Hdfc h1 = new Hdfc();
            //h1.calculateInterest();

            //Hospital h1 = new Hospital();
            //h1.hospitalDetails();

            //Hospital h2 = new Apollo();
            //h2.hospitalDetails();


            //AreaB a1 = new AreaB();
            //int x = a1.area(8);
            //Console.WriteLine(x);
            //int y = a1.area(8,7);
            //Console.WriteLine(y);
            //int z = a1.area(8);
            //Console.WriteLine(z);

            BankAccount b1 = new BankAccount();
            b1.deposite(500);
            b1.withdraw(800);
            b1.getBalance();

        }
    }
}
