using System.Linq;
using System.Reflection;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using System.Text;
using System.IO;
using System.Runtime.CompilerServices;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var strings = new string[] { "bc", "ab", "dc", "cd", "fe","ef","hg", "gh"};
            Array.Sort(strings);
            foreach (var s in strings)
            {
                Console.WriteLine(s);
            }
        }
    }
}