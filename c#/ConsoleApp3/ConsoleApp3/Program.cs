using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("What's Your Name: ");
            //Console.Write("Name: ");
            //var name = Console.ReadLine();
            //var is_admin = (name == "admin") ? "admin" : "user";
            //Console.WriteLine(is_admin);
            //string[] names = new string[] { "Eddie", "Alex", "Michael" };
            ////var names2 = new List<string> { "Jason", "Solomon" };
            //foreach (var item  in names){
            //    Console.WriteLine(item);
            //}

            //string zig = "You can het what you want out of life" + 
            //    "If you help enough people get what they want";
            //char[] charArray = zig.ToCharArray();
            //Array.Reverse(charArray);
            //Console.WriteLine(charArray);
            //string hello;
            //hello = Console.ReadLine();
            //int.Parse(hello);
            //Console.WriteLine(hello);

            //2d arrays

            int[,] board = new int[3, 3];
            board[0, 0] = 1;

            Console.WriteLine(board[0, 0]);
            //3d arrays
            int[,,] board2 = new int[3, 3, 3];
            board2[0, 0, 0] = 1;
            Console.WriteLine(board2[0, 0, 0]);
            int x = 2;
            int y = 0;
            int b;
            try
            {
                b = x / y;
            }
             catch(DivideByZeroException e)
            {
                    Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("done");
            }
            //switch statements
            Console.Write("Number: ");
            int userin = int.Parse(Console.ReadLine());
            switch(userin)
            {
                case 1:
                    Console.WriteLine(1);
                    break;
                case 10:
                    Console.WriteLine(1120);
                    break;
                case 12:
                    Console.WriteLine(11221);
                    break;
                default:
                    Console.WriteLine("Hello");
                    break;

            }
        }
    }
}