
namespace cSharp_OOP_Practices
{
    internal class BankAccount
    {
        public string AccountNumber { get; set; }  //get for read and set to assign a value
        public string OwnerName { get; set; } 
        public double Balance { get; private set;  } //private set is same as read-only fields. They can only be set in constructor.
        public BankAccount() {
            AccountNumber = "Unkown";
            OwnerName = "Unknow";
            Balance = 0;
        }
        public BankAccount(string accountNumber, string ownerName, double balance) // Constructor
        {
            AccountNumber = accountNumber;
            OwnerName = ownerName;
            Balance = balance;
        }
        public void Deposit(double amount)
        {
            // Check if the amount is positive
            if (amount > 0)
            {
                // Add the amount to the balance
                Balance += amount;
                // Print a confirmation message
                Console.WriteLine($"Deposited {amount} to {AccountNumber}. New balance is {Balance}.");
            }
            else
            {
                // Print an error message
                Console.WriteLine("Invalid amount. Deposit failed.");
            }
            
        }

        // Define a method to withdraw funds from the account
        public void Withdraw(double amount1)
        {
            // Check if the amount is positive and less than or equal to the balance
            if (amount1 > 0 && amount1 <= Balance)
            {
                // Subtract the amount from the balance
                Balance -= amount1;
                // Print a confirmation message
                Console.WriteLine($"Withdrew {amount1} from {AccountNumber}. New balance is {Balance}.");
            }
            else
            {
                // Print an error message
                Console.WriteLine("Invalid amount. Withdrawal failed.");
            }
        }
    }

}

