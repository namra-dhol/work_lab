using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class BankAccount
    {
        String accountHolderName;
        int initialBalance;
        int amount;
        public BankAccount()
        {
            Console.WriteLine("enter initialBalance :");
            this.initialBalance = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter accountHolderName :");
            accountHolderName = Console.ReadLine();
        }
        public void deposite(int amount)
        {
            this.amount = amount;
            initialBalance = amount + initialBalance;
            getBalance();
            //Console.WriteLine("initial balnce :" + initialBalance);
        }
        public void getBalance()
        {
            Console.WriteLine("initial balnce :"+this.initialBalance);
        }
        public void withdraw(int amount)
        {
            if (initialBalance >=  amount)
            {
                this.amount = amount;
                initialBalance = initialBalance - amount;
                getBalance(); 
            }
            else
            {
                Console.WriteLine("not allowed to withdraw :");
            }
        }
    }
}


   