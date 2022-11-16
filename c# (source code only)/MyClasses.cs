using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Students
    {
        public string Name { get; set; }
        public int Marks { get; set; }

        public Students(string name, int marks)
        {
            Name = name;
            Marks = marks;
        }

    }
}
