using System.Linq;
using System.Reflection;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using System.Text;
using System.IO;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number of Students: ");
            int numberOfStudents = Convert.ToInt32(Console.ReadLine());
            Students[] students = new Students[numberOfStudents];
            for (int i = 0; i < numberOfStudents ; i++)
            {
                string name = "";
                int marks = 0;
                Console.Write("Name: ");
                name = Console.ReadLine();
                Console.Write("Marks: ");
                marks = Convert.ToInt32(Console.ReadLine());
                var student = new Students(name, marks);
                students[i] = student;
            } 
            for (int j = 0; j < numberOfStudents; j++)
            {
                Console.WriteLine($"{students[j].Name} has {students[j].Marks} Marks");
            }
        }
    }
}