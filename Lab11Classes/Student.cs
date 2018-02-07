using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11Classes
{
    class Student:Person
    {
        public string Program
        {
            set;
            get;
        }

        public int Year
        {
            set;
            get;
        }
        public double Fee
        {
            set;
            get;
        }


        public Student(string name, string address, string program, int year, double fee): base (name , address)
        {
            Program = program;
            Year = year;
            Fee = fee;
        }

        public Student()
        {

        }

        public override void PrintInfo()
        {
            Console.WriteLine("**********STUDENT*********");
            Console.WriteLine(Name);
            Console.WriteLine(Address);
            Console.WriteLine(Program);
            Console.WriteLine(Year);
            Console.WriteLine(Fee);
            Console.WriteLine(new string('*', 26));
            Console.WriteLine();

        }
        public override string ToString()
        {
            return $"Student : {Name} {Address} {Program} {Year} {Fee}";
        }
    }
}
