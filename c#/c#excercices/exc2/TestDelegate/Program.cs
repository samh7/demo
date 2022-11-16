namespace TestDelegates

{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestDelegate testDelegate = new TestDelegate();
            NumChanger number = new NumChanger(TestDelegate.add);

            //sort like pointers to strings
            Console.WriteLine(number(11));
        }
    }
    //a delegate is a method that has  other methods(from types?) as parameters 
    public delegate int NumChanger(int x);
    class TestDelegate
    {
        public static int num1 = 20;
        public static int num2 = 40;
        
        public static int add(int x)
        {
            if (x < 10)
            {
                return 10;
            }

            else
            {
                return -10; 
            }
        }
  

    }
}