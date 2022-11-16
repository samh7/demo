using System.Collections.Concurrent;

namespace ToggleCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ddd = "ddd";
            var d = ddd[0];
            Console.WriteLine(d.ToUpper());
            Console.Write("Hello: ");
            string userIn = Console.ReadLine();
            var outUser = ""; 
            for (int i = 0; i < userIn.Length; i++)
            {
                if (i == 0)
                {
                    continue;
                }
                if (userIn[i].Equals("_"))
                {
                    var tmpUserIn = userIn[i+1];
                    outUser = tmpUserIn.ToUpper();
                }

            }
        }
    }
}