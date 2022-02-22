namespace classes;

public class InterestEarningAccount : BankAccount
{
    public InterestEarningAccount(string name, int initialBalance) : base(name, initialBalance)
    {
        
    }

    public override void PerformMonthEndTransactions()
    {
        if (Balance > 500m)
        {
            var interest = Balance * .05m;
            MakeDeposit(interest, DateTime.Now, "apply monthly interest");
        }
    }
}