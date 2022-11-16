using System.Diagnostics.CodeAnalysis;

namespace TestDelegate
{
    public delegate long TestDelegate(long x);
    class NumChanger
    {
        public static long multiply(long x)
        {
            return x * x;
        }
        public static long sum(long x)
        {
            return x + x;
        }


    }


    public delegate void IntAction(int y);


    internal class Program
    {
        static void Main(string[] args)
        {
            TestDelegate multiplyDelegate = new TestDelegate(NumChanger.multiply);
            //Console.WriteLine(multiplyDelegate(11));
            static void PrintInt(int a)
            {
                Console.WriteLine(a);
            }

            var numList = new int[]{ 1,2,4,5,6,65,43,132,6576,43,2,5,6,5342,3};
            static void Perform(IntAction act, params int[] a )
            {
                foreach(var item in a)
                {
                    act(item);
                }
            }
            IntAction act = new IntAction(PrintInt);
            Perform(act, 1,3,5,46,45,64);

           
        }
    }
}