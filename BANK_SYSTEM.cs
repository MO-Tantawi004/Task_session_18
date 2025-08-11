using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANKWITH_FUND
{
    //base class
    public class BankAccount
    {
        public string AccountNumber { get; set; }
        public string AccountHolderName { get; set; }
        public decimal Balance { get; set; }

        public BankAccount(string accountNumber, string accountHolderName, decimal balance)
        {
            AccountNumber = accountNumber;
            AccountHolderName = accountHolderName;
            Balance = balance;
        }

        public virtual decimal CalculateInterest()
        {
            return 0; // Default: No interest
        }

        public virtual void ShowAccountDetails()
        {
            Console.WriteLine($"Account Number: {AccountNumber}");
            Console.WriteLine($"Account Holder: {AccountHolderName}");
            Console.WriteLine($"Balance: {Balance:C}");
        }
    }

    // Derived class - SavingAccount
    public class SavingAccount : BankAccount
    {
        public decimal InterestRate { get; set; }

        public SavingAccount(string accountNumber, string accountHolderName, decimal balance, decimal interestRate)
            : base(accountNumber, accountHolderName, balance)
        {
            InterestRate = interestRate;
        }

        public override decimal CalculateInterest()
        {
            return Balance * InterestRate / 100;
        }

        public override void ShowAccountDetails()
        {
            base.ShowAccountDetails();
            Console.WriteLine($"Interest Rate: {InterestRate}%");
        }
    }

    // Derived class - CurrentAccount
    public class CurrentAccount : BankAccount
    {
        public decimal OverdraftLimit { get; set; }

        public CurrentAccount(string accountNumber, string accountHolderName, decimal balance, decimal overdraftLimit)
            : base(accountNumber, accountHolderName, balance)
        {
            OverdraftLimit = overdraftLimit;
        }

        public override decimal CalculateInterest()
        {
            return 0; // Current accounts do not earn interest
        }

        public override void ShowAccountDetails()
        {
            base.ShowAccountDetails();
            Console.WriteLine($"Overdraft Limit: {OverdraftLimit:C}");
        }
    }

}

