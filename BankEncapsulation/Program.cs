namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var felixaccount = new BankAccount();
            Console.WriteLine("How much would you like to deposit?");

            var amountToDep = double.Parse(Console.ReadLine());

            felixaccount.Deposit(amountToDep);
            Console.WriteLine($"Thank you! your balance is now {felixaccount.GetBalance()}");
        }
    }
}
