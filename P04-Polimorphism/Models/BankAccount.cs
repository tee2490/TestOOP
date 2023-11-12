
namespace P04_Polimorphism.Models
{
    public class BankAccount
    {
        public string AccountHolder { get; }
        public decimal Balance { get; private set; }

        //overload Ctor
        public BankAccount() { }
        public BankAccount(string accountHolder, decimal balance = 0)
        {
            AccountHolder = accountHolder;
            Balance = balance;
        }

        public string Deposit(decimal amount)
        {
            Balance += amount;
            return $"Deposited ${amount}. New balance: ${Balance}";
        }

        public string Withdraw(decimal amount)
        {
            if (amount > Balance)
            {
                return "Insufficient funds";
            }

            Balance -= amount;
            return $"Withdrew ${amount}. New balance: ${Balance}";
        }


        //virtual อนุญาตให้นำไปเขียนโค้ดใหม่ได้
        public virtual string GetBalance()
        {
            return $"Current balance for {AccountHolder}: ${Balance}";
        }

      
    }

}
