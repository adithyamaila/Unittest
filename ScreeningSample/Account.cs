using System;

namespace ScreeningSample
{
    public class Account
    {
        //Mandatory
        public string AccountNumber { get; set; }
        //Mandatory
        public AccountType AccountType { get; set; }
        //Mandatory
        public int AccountOwner { get; set; }
    }
}