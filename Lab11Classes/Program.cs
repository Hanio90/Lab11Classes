using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Person perp = new Person("Hani", "27900 Coding Dr.");
            Staff perp2 = new Staff("Jacob", "1570 Woodward", "Grand Circus", 2000);
            Student perp3 = new Student("James Jackson", "84639 Silver ln","C# .NET", 2018, 8000);

            List<Person> People = new List<Person>();

            People.Add(perp);
            People.Add(perp2);
            People.Add(perp3);

            foreach (Person persons in People)
            {
                persons.PrintInfo();
            }
        }
    }
}
