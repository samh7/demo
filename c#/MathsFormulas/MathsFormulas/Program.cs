namespace MathsFormulas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("for an equation of the form aX^(n) : ");
            Console.Write("a: ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("\nn: ");
            float n = float.Parse(Console.ReadLine());

            var derivative = simpleDeriviate(a, n);
            Console.WriteLine(derivative);
        }

        public static string simpleDeriviate(float a, float n)
        {
            float k = a * n;
            n -= 1;
            return $"{k}X^({n})";
        }
    }
}