namespace Sharp11
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Account account1 = new Account();
            Account account2 = new Account();
            Account account3 = new Account();

            account3.FillTypeAccount(TypeOfAccount.Credit);
            account1.FillBalance(100000);
            account2.FillNumber(4);

            account1.FullInfo();
            account2.FullInfo();
            account3.FullInfo();
        }
    }
}