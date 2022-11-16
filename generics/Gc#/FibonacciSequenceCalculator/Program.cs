namespace FibonnaciSequenceCalculator
{
    public class Program{
        static void Main(string[] args){
            List<int> integers = new List<int>();
            integers.AddRange());
            integers.Add(5);
            integers.Add(5);
            integers.Add(5);
            integers.Add(5);
            var greaterThanFive = integers.Where(x=>(x >5));
            System.Console.WriteLine(greaterThanFive);

        }   
        static int fib(int i){
            if (i<=2) return 1;
            return fib(i-2 ) +  fib(i-1);
        }
        static void fib3(int j)
        {
            for(int i = 1; i <=j; i++){
             System.Console.Write($"{fib(i)}, ");   
            }
        }
        static void fib2(int i){
            int present = 1;
            int previous = 0;
            int tmp = 0;
            System.Console.Write("0, 1");
            for (int j = 1; j < i; j++)
            {
                tmp = previous;
                previous = present;
                present += tmp;
                System.Console.Write($" ,{present}");
            }
        }
    }
    
}