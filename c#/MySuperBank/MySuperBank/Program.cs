namespace MySuperBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
     
            var account = new BankAccount("Kendra", 10000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance}");




            Console.WriteLine(account.GetAccountHistory());



            try
             {
                account.MakeWithdrawal(120, DateTime.Now, "Hammok");
             }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Error: " + e);
            }
        }
    }
}