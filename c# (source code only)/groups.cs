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

            Console.WriteLine("number of students: ");
            int studentsCount = Convert.ToInt32(Console.ReadLine());
            var marks = new int[studentsCount];
            var orderedMarks = new int[studentsCount];
            for (int i = 0; i < studentsCount; i++)
            {
                Console.WriteLine("Marks for student {0}: ", i);
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }
            int one = 0;
            int two = 0;
            int three = 0;
            int four = 0;
            int five = 0;
            int six = 0;
            int seven = 0;
            int eight = 0;
            for (int i = 0; i < studentsCount; i++)
            {
                Console.WriteLine(marks[i]);
                if (marks[i] <= 69)
                {
                    if(marks[i] <= 59){
                        if (marks[i] <= 49)
                        {
                            if (marks[i] <= 39)
                            {
                                if (marks[i] <= 29)
                                {
                                    if (marks[i] <= 19)
                                    {
                                        if (marks[i] <= 9)
                                        {
                                            one++;
                                            continue;
                                        }
                                        two++;
                                        continue;
                                    }
                                    three++;
                                    continue;
                                }
                                four++;
                                continue;
                            }
                            five++;
                            continue;
                        }
                        six++;
                        continue;
                    }
                    seven++;
                    continue;
                }
            }
            Console.WriteLine($"0 to 9\t{one}");
            Console.WriteLine($"10 to 19\t{two}");
            Console.WriteLine($"20 to 29\t{three}");
            Console.WriteLine($"30 to 39\t{four}");
            Console.WriteLine($"40 to 49\t{five}");
            Console.WriteLine($"50 to 59\t{six}");
            Console.WriteLine($"60 to 69\t{seven}");
        }
    }
}