using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11Classes
{
    class Staff:Person
    {
        public string School
        {
            set;
            get;
        }

        public double Pay
        {
            set;
            get;
        }
        

        public Staff(string name , string address,string school, double pay) : base(name,address)
        {
            School = school;
            Pay = pay;
        }

        public Staff()
        {

        }

        public override void PrintInfo()
        {
            Console.WriteLine("**********STAFF***********");
            Console.WriteLine(Name);
            Console.WriteLine(Address);
            Console.WriteLine(School);
            Console.WriteLine(Pay);
            Console.WriteLine(new string('*', 26));
            Console.WriteLine();
        }
        public override string ToString()
        {
            return $"Staff : {Name} {Address} {School} {Pay}";
        }
    }
}
