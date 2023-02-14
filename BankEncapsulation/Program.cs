namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome to the Berny Madoff Family Bank!");
            Console.WriteLine();
            Console.WriteLine("Let's setup your account by creating a 4 digit PIN");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("What would you like your 4 digit Pin number to be?");

            int pinNumber = int.Parse(Console.ReadLine() );
            
            Console.WriteLine("1..........Balance Check");
            Console.WriteLine();
            Console.WriteLine("2..........Deposit");
            Console.WriteLine();
            Console.WriteLine("3..........Withdraw");
            {
                BankAccount checking = new BankAccount();

                Console.WriteLine("How much are you depositing?");
                double amountToDeposit = double.Parse(Console.ReadLine());

                checking.Deposit(amountToDeposit);
                double userBalance = checking.GetBalance();

                Console.WriteLine($"Your current balance is: {userBalance,0:c}");
            }
        }
    }
}
