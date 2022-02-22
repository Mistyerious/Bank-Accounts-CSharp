namespace classes
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var account = new BankAccount("John Adams", 500);
            account.MakeWithdrawal(500, DateTime.Now, "Rent Payment");
            account.MakeDeposit(2000, DateTime.Now, "Paycheck");
            Console.WriteLine("Bank Account History:\n" + account.GetAccountHistory());

            var giftCardAccount = new GiftCardAccount("John Adams", 100, 50);
            giftCardAccount.MakeWithdrawal(20, DateTime.Now, "get expensive coffee");
            giftCardAccount.MakeWithdrawal(50, DateTime.Now, "getting groceries");
            giftCardAccount.PerformMonthEndTransactions();
            giftCardAccount.MakeDeposit(27.50m, DateTime.Now, "add some additional spending money");
            Console.WriteLine("Gift Card Account History: \n" + giftCardAccount.GetAccountHistory());

            var savings = new InterestEarningAccount("John Adams", 1000);
            savings.MakeDeposit(750, DateTime.Now, "save some money");
            savings.MakeDeposit(1250, DateTime.Now, "Add more savings");
            savings.MakeWithdrawal(250, DateTime.Now, "Needed to pay monthly bills");
            savings.PerformMonthEndTransactions();
            Console.WriteLine("Savings Account History: \n" + savings.GetAccountHistory());
            
            var lineOfCredit = new LineOfCreditAccount("line of credit", 0, 2000);
            // How much is too much to borrow?
            lineOfCredit.MakeWithdrawal(1000m, DateTime.Now, "Take out monthly advance");
            lineOfCredit.MakeDeposit(50m, DateTime.Now, "Pay back small amount");
            lineOfCredit.MakeWithdrawal(5000m, DateTime.Now, "Emergency funds for repairs");
            lineOfCredit.MakeDeposit(150m, DateTime.Now, "Partial restoration on repairs");
            lineOfCredit.PerformMonthEndTransactions();
            Console.WriteLine("Line Of Credit: \n" + lineOfCredit.GetAccountHistory());
        }
    }
}