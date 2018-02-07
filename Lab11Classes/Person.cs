using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11Classes
{
    class Person
    {
        //Fields
        //private string name;
        //private string address;

        //Properties 

        public string Name
        {
            set;

            get;
        }

        public string Address
        {
            set;

            get;

        }

        public Person(string name, string address)
        {
            Name = name;
            Address = address;
        }

        public Person()
        {

        }

        public virtual void PrintInfo ()
        {
            Console.WriteLine("**********Person**********");
            Console.WriteLine(Name);
            Console.WriteLine(Address);                //USE THE PROPERTIE NOT THE FIELD
            
            Console.WriteLine(new string('*', 26));
            Console.WriteLine();
        }

        public override string ToString()
        {
            return $"Person : {Name} {Address}";
        }

        







    }
}
