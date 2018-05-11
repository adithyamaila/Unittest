using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScreeningSample;
using Moq;

namespace UnitTestProject1
{
    [TestClass]
    public class ScreeningSampleTest
    {
        [TestMethod]
        public void TestGetInvestmentAccounts()
        {
            List<Account> accounts = new List<Account>();
            Account newAc = new Account();
            newAc.AccountNumber = "25";
            newAc.AccountOwner = 25;
            newAc.AccountType = AccountType.Investment;
            accounts.Add(newAc);

            int vipClientId = 25;
            Mock<DataStore> objStore = new Mock<DataStore>();
            objStore.Setup(x => x.LoadAccounts(25)).Returns(accounts);
            AccountBl accountBl = new AccountBl();
            


            List<Account> mockAccounts = accountBl.GetInvestmentAccounts(vipClientId, AccountType.Investment, objStore.Object);
            Assert.AreEqual(mockAccounts[0].AccountOwner, 25);
        }
    }
}
