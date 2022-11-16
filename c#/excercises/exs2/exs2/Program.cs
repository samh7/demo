namespace exs2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            B b = new B();
            A a = new A();

            string[] listString = new string[] { "food", "housing", "water", "schooling", "human dignity"};
            foreach (var item in listString)
            {
                Console.WriteLine(item);
            }
        }
    }

    class B
    {
        public  void SM() 
        {
            Console.WriteLine("Hello from B.SM");
        }
        public virtual void VIM()
        {
            Console.WriteLine("Hello from B.VIM");
        }
        public void NIM()
        {
            Console.WriteLine("Hello from B.NIM");
        }
    }
    class A: B
    {
        public override void VIM()
        {
            Console.WriteLine("Hello from A.VIM");
        }

    }
}
