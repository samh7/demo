namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string greeting = Console.ReadLine();

            Console.WriteLine(GreetingAmount(greeting));
        }


        public static string GreetingAmount(string greeting)
        {
            if (greeting == "hello")
            {
                return "$0";
            }
            else if (greeting[0] == 'h')
            {
                return "$20";
            }
            else
            {
                return "$100";
            }
        }
    }
}