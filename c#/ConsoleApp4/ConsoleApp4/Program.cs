using System;
using System.Text;
using System.IO;
namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] source = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //var query = from item in source
            //            where item < 3
            //            select item;    
            StreamWriter writer = new StreamWriter("test.txt");
            writer.WriteLine("hello, world");
            writer.Close();

            StreamReader reader = new StreamReader("Test.txt");
            
            while (reader.EndOfStream == false)
            {
                string line = reader.ReadLine();
                Console.WriteLine(line);
            }   
            reader.Close();

            string path = @"C:\Users\Cy\dev\demo\c#\ConsoleApp4\ConsoleApp4\test.txt";

            StreamWriter writer1 = new StreamWriter(path);
            writer1.WriteLine("Hello, World");
            writer1.WriteLine("Hello, World");
            writer1.WriteLine("Hello, World");
            writer1.Close();


            StreamReader reader1 = new StreamReader(path);

            while (reader1.EndOfStream == false)
            {
                var line = reader1.ReadLine();
                Console.WriteLine(line);
            }
    


        }
    }
}