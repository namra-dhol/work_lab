using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamDemo
{
    internal class StringDemo
    {
        public StringDemo()
        {
            Console.WriteLine("enter a string : ");
            String s1 = Console.ReadLine();
            Console.WriteLine("enter a string : ");
            String s2 = Console.ReadLine();
            String value;
            if (s1.Equals(s2))
            {
                Console.WriteLine("string is same :");
            }
            else
            {
                Console.WriteLine("string is invalid input:");
            }

            Console.WriteLine("enter 1 for concate : ");
            int ans = Convert.ToInt32(Console.ReadLine());
            if(ans == 1){
                Console.WriteLine(s1.Concat(s2).ToString());
            }
            Console.WriteLine("enter 1 for convert 1 string in upper case : ");
            int demo = Convert.ToInt32(Console.ReadLine());
            if (demo == 1)
            {
                Console.WriteLine("after concate: " + s1.ToUpper());
            }
        }
    }
}