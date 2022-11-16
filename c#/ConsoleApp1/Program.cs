using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //var names = new List<string> { "<name>", "Ana", "Maria" };
            //var numbers = new List<int> { 1, 2, 3, 4, 5 };
            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(numbers.IndexOf(i));
            //}
            //foreach (string name in names)
            //{
            //    Console.WriteLine(name);
            //}
            Person Person1 = new Person("Jason", 36);
            Console.WriteLine($"I am {Person1.Name} and I am {Person1.Age} years old");
            Developer Dev1 = new Developer("jason", 23, "c#", "Microsoft");
            Console.WriteLine($"I am {Dev1.Name}, I am {Dev1.Age} years old, I am profficient in {Dev1.Language} and am currently working at {Dev1.Employer}");
        }
    }


}