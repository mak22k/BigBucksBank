using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigBucksBank
{
    public class Customer
    {
        private string UserID, Password;
        private Account Checking, Savings;
        
        public string getUserID() { return UserID; }
        public void setUserID (string value) { UserID = value; }
        
        public string getPassword(){ return Password; }
        public void setPassword(string value) { Password = value; }
        
        public Account getChecking() { return Checking; }
        public void setChecking(Account value) { Checking = value; }
        
        public Account getSavings() { return Savings; }
        public void setSavings(Account value) { Savings = value; }
        

        public Customer(string userID, string password, string cAcctNum, decimal cAcctBal, string sAcctNum, decimal sAcctBal)
        {
            UserID = userID;
            Password = password;
            Checking = new Account(cAcctNum, cAcctBal, true); // bool is indicating it's checking acct
            Savings = new Account(sAcctNum, sAcctBal, false); // bool indicates it's a savings account
        }

        public Customer(string userID, string password, Account checking, Account savings)
        {
            UserID = userID;
            Password = password;
            Checking = checking;
            Savings = savings;
        }

        public void transfer(Account from, Account to, decimal amount)
        {
           // if(Validator.IsWithinRange(textBox, 0, from.getAcctBal()))
            if (from.getAcctBal() > amount)// extra validation
            {
                from.withdraw(amount);
                to.deposit(amount);
            }
            return;
        }

        public string getCheckingNum() { return this.Checking.getAcctNum(); }
        public string getSavingsNum() { return this.Savings.getAcctNum(); }
    }
}
