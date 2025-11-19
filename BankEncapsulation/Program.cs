namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
             double currentBalance = 0;
            
            
            BankAccount andy = new BankAccount();
            
            void GetCurrentBalance()
            {
                currentBalance = andy.GetBalance();
                Console.WriteLine($"Your current balance is ${currentBalance}.");
            }
            
            Console.WriteLine("Welcome! How much would you like to deposit today?");
            double amountToDeposit = double.Parse(Console.ReadLine());
            
            andy.Deposit(amountToDeposit);
            
            Console.WriteLine("If you would like to view your current balance, type \"YES\". Otherwise, type \"NO\".");
            string response = Console.ReadLine();

            if (response == "YES")
            {
                GetCurrentBalance(); 
            }
            else if (response == "NO")
            {
                Console.WriteLine("Thank you. Goodbye.");
            }
            else
            {
                Console.WriteLine("Invalid input, please try again.");
            }
            
            
            
            
        }
    }
}
