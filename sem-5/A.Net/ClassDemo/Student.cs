using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo
{
    internal class Student
    {
        public int RollNo { get; set; }

        public int Age { get; set; }

        public string Name { get; set; }    

        public string Branch {  get; set; }

        public double Cpi { get; set; }

        public int Sem {  get; set; }
    }

    public class Course
    {
        public int Rno { get; set; }
        public string CourseName { get; set; }
        public int Credits { get; set; }

        public override string ToString()
        {
            return $"Rno: {Rno}, Course: {CourseName}, Credits: {Credits}";
        }
    }
}
