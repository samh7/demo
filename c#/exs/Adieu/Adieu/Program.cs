namespace Adieu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var userIn = new List<string>();

            Console.Write("Enter the Number of Names: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num);
            int num1 = 0;
            while (num1 < num)
            {
                Console.Write("Nam2e: ");
                userIn.Add(Console.ReadLine());
                Console.WriteLine();
                num1++;
            }

            if (userIn.Count == 1)
            {
                Console.Write($"Adieu, adieu to {userIn[0]}");
            }
            else
            {
                Console.Write("Adieu, adieu to ");
                if (userIn.Count == 2)
                {
                    Console.WriteLine($"{userIn[0]} and {userIn[1]}");
                    return;
                }
                for (int i = 0; i < userIn.Count; i++)
                {
                    if (i == userIn.Count - 1)
                    {
                        Console.Write(" and ");
                        Console.WriteLine(userIn[i]);
                        break;
                    }
                    Console.Write(userIn[i]);
                    Console.Write(", ");
                }
            }
        }
    }
}