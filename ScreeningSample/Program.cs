namespace ScreeningSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var vipClientId = 25;
            var accountBl = new AccountBl();
            DataStore dataStore = new DataStore();
        accountBl.GetInvestmentAccounts(vipClientId, AccountType.Investment, dataStore);
        }
    }
}
