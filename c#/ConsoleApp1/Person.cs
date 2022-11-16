using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public  class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;

        }

    }
    
    public class Developer: Person
    {
        public string Language { get; set; }
        public string Employer { get; set; }


        public Developer( string name, int age, string language, string employer): base(name, age)
        {
            Name=name;
            Age=age;
            Language = language;
            Employer = employer;
        }
    }
}
