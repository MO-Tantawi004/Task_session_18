namespace BANKWITH_FUND
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create objects
            SavingAccount savingAcc = new SavingAccount("SA123", "Ahmed Ali", 5000m, 5m);
            CurrentAccount currentAcc = new CurrentAccount("CA456", "Mona Hassan", 2000m, 1000m);

            // Add to list
            List<BankAccount> accounts = new List<BankAccount> { savingAcc, currentAcc };

            // Loop through accounts
            foreach (var acc in accounts)
            {
                acc.ShowAccountDetails();
                Console.WriteLine($"Calculated Interest: {acc.CalculateInterest():C}");
                Console.WriteLine(new string('-', 30));
            }
        }
    }
}

