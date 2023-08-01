namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount();
            Console.WriteLine("How much would you like to deposit?");

            var AmountToDeposit = double.Parse(Console.ReadLine());

            account.deposit(AmountToDeposit);

            Console.WriteLine($"Thank you! Your balance is currently {account.GetBalance()}");
        }
    }
}
