using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigBucksBank
{
    public class Account
    {
        private string acctNum;
        private decimal acctBal;
        private bool isChecking;
        
        public Account(string accountNum, decimal balance, bool isCheckingAcct)
        {
            acctNum = accountNum;
            acctBal = balance;
            isChecking = isCheckingAcct;
        }

        public void deposit(decimal amount)
        {
            acctBal += amount;
        }

        public void withdraw(decimal amount)
        {
            acctBal -= amount;
        }

        public string getAcctLast4()
        {
            return acctNum.Substring(4);
        }

        public string getAcctNum() { return acctNum; }
        public void setAcctNum(string val) { acctNum = val; }
        public decimal getAcctBal(){ return acctBal; }
        public void setAcctBal(decimal val) { acctBal = val; }
        public bool getIsChecking() { return isChecking; }
        public void setIsChecking(bool value) { isChecking = value; }
        
    }
}
