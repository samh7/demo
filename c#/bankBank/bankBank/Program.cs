/* 
comments: multiline
*/

namespace bankBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            BankAccount NewBabkAccount = new BankAccount("Jason", 1000);
            NewBabkAccount.MakeDeposit(1200, DateTime.Now, "deposited money to bank");
            Console.WriteLine(NewBabkAccount.Balance);
            */


            var SNum = "23";
            const double PI = 22 / 7;

            var SSNum = Convert.ToInt32(SNum);


            SNum = Convert.ToString(SSNum) + "fref4f";

            //nullable types

            int? canBeNull = null;
            canBeNull++;



            //dynamic hello = 4;
            //Console.WriteLine(hello);
            //hello = "hello";
            //Console.WriteLine(hello+"\r" + "fergeg" + "\r" + "fre" + ""+ "hello" + "\r");


            Person person = new Person() {"MAS", "SAM", "re"};

        }

        public class Person
        {
            public List<string> Namea { get; set; }

            public Person(params )
            {
            }
        }

    }
}