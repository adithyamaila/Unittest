using System;
using System.Collections.Generic;
using System.Linq;

namespace ScreeningSample
{
    public class AccountBl
    {
        private DataStore dataStore = new DataStore();

        public List<Account> GetInvestmentAccounts(int clientId, AccountType accountType, DataStore dataStore)
        {
            if (accountType == AccountType.Investment)
            {
                var accounts = dataStore.LoadAccounts(clientId);
                return accounts.Where(a => a.AccountType == AccountType.Investment).ToList();
            }
            throw new Exception("Invalid account type provided");
        }
    }
}