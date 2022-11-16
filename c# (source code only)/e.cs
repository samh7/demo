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
            double e = 1;
            ulong fact = 1;
            ulong n = 1;
            for (int i = 1; i < 50; i++)
            {
                fact *= n++;
                e += 1.0 / fact;
            }
            Console.WriteLine("\n");
            Console.WriteLine(e);

        }
      
    }
}