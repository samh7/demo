namespace GenericTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //Pair<String, int>[] pair = new Pair<String, int>[4]
            //{
            //new Pair<string, int>("ofrew", 1),
            //new Pair<string, int>("tfrewf", 2),
            //new Pair<string, int>("thrfrewf", 3),, 
            //new Pair<string, int>("ffrewf", 4),
            //};
            //Console.WriteLine(pair[3].ToString());
            //Pair<string, int> appartmentDetails = new Pair<string, int>("Jarvis Appertments", 10);
            //Pair<Pair<string, int>, string> appartment = new Pair<Pair<string, int>, string>(appartmentDetails, "Jason");

            //typeof(what) finds the type of types/objects?? yes?, not variables? like int 
            //what.GetType() finds the type of what is stored in an object

            //var swapPair = Pair<Pair<string, int>, string>.swap(appartment);

            //Console.WriteLine(appartment.Snd);
            //Console.WriteLine(swapPair.Snd);

            //Lst<string> StringList = new Lst<string>(){ "hello", "ferf", "fref", "frfrefew" };
            //Console.WriteLine(StringList.GetType());
        }
    }





    public struct Lst<T>
    {
        public T[] snd = { };

        public Lst(params T[] k)
        {
            for (int i = 0; i < k.Count(); i++)
            {
                snd[i] = k[i];
            }

        }
    }

    public struct Pair<T, U>
    {
        public T Fst;
        public U Snd;
        public Pair(T fst, U snd)
        {
            Fst = fst;
            Snd = snd;
        }
        public override string ToString()
        {
            return "(" + Fst + ", " + Snd + ")";
        }
        public static Pair<U,T> swap(Pair<T, U> pair)
        {
            Pair<U, T> rtnPair = new Pair<U, T>(pair.Snd, pair.Fst);
            return rtnPair;
        }

    }
}