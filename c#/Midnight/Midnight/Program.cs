
Console.Write("fewfewf\n");
await Task.Delay(3000);
Console.WriteLine("yaay!");

string? s = Console.ReadLine();
int integer = int.Parse(s ?? "-1");

Console.WriteLine(integer);

namespace Midnight
{
    public class Program
    {
        static async void Main(string[] args)
        {
           string value = integrate();

            //Console.WriteLine(value);
            //Fibonacci(8);
            List<string> mostWanted = new List<string>
            {
                "Kanye",
                "Elon",
               "Steffani",
                "Jason",
                "Margaret",
                "Kia",
               "Alice"
            };
            find(mostWanted, "alice");
            //if the cursor starts having issues first press insert 
            reverseString();
            Fibonacci(102);

        }
        
        static void Fibonacci(int number)
        {
            int present = 1;
            int prev = 0;
            int tmp = 0;
            Console.Write($" {prev}, {present}");
            for (int i = 1; i < number; i++)
            {
                tmp = present;
                present += prev;
                prev = tmp;
                Console.Write($", {present}");
                

            }
            return;
        }

        static void sumAll(int num) 
        {
            int sum = 0;
            for (int i = 0; i <= num; i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);
        }

        static void find(List<string> list, string name)
        {
            foreach(var item in list)
            {
                if (item.ToLower() == name.ToLower())
                {
                    Console.WriteLine("Found");
                    return;
                }
            }
            Console.WriteLine("Not Found");
            return;
        }
        static void reverseString()
        {
            string greeting = "hello, world";
            char[] charArray = greeting.ToCharArray();

            Array.Reverse(charArray);

            Console.WriteLine(charArray);
        }

        static string integrate()
        {
            //y = K(pow(x,t) + c
            Console.Write("K: ");
            float k = float.Parse(Console.ReadLine());

            
            Console.Write("t: ");
            float t = float.Parse(Console.ReadLine());

            
            Console.Write("C: ");
            float c = float.Parse(Console.ReadLine());

            t += 1;
            k /= t;

          return $"{k}x^({t}) + {c}x + C";
       
        } 
    }
}