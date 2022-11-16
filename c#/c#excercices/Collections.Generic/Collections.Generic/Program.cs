using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Collections.Generic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        
            static List<double> Method1()
            {

                List<double> temparatures = new List<double>() { 12, 32, 34,23, 34, 45, 43,34 ,32};
                int sum = 0;
                foreach(var item in temparatures)
                {
                    if (item >= 25)
                    {
                        sum++; ;
                    }

                }
                return temparatures;
            }
        
            static int GreaterCount(List<double> list, double min)
            {
                int sum = 0;
                foreach (var item in list)
                {
                    if (item >= min)
                    {
                        sum++;
                    }
                }
                return sum;
                
            }
            static int GreaterCount2(IEnumerable<double> eble, double min) 
            {
                int sum = 0;
                foreach (var item in eble)
                {
                    if (item >= min)
                    {
                        sum++;
                    }
                }
                return sum;
            }


            //Console.WriteLine(GreaterCount(Method1(), 25));
            Console.WriteLine(GreaterCount2(Method1(), 25));
        }
    }
}