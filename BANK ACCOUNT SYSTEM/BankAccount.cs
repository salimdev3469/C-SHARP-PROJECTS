using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANK_ACCOUNT_SYSTEM
{
    abstract class BankAccount
    {
       public long AccountNo { get; set; }
        public string IBAN { get; set; }
        public int BranchCode { get; set; }
        public decimal Balance { get; set; }

        public virtual string Withdraw(decimal amount)
        {
            Balance -= amount;
            return amount + "$ withdrawed from your account. Initial balance: "+Balance;
        }

        public virtual string Deposit(decimal amount)
        {
            Balance += amount;
            return amount + "$ deposited to your account.Initial balance: "+Balance;
        }


    }


    class CurrentAccount : BankAccount
    {
        public override string Withdraw(decimal amount)
        {
            if (Balance < amount)
            {
                return "Insufficient Balance.";
            }
            if (amount%5 == 0){ //only 5 or multpiles of 5 are withdrawable.
                return base.Withdraw(amount);//when you call with base class, it goes to inherited/parent class
            }
            else
            {
                return "You can withdraw number of 5 or multiples of 5.";
            }
        }

    }

    class SavingsAccount : BankAccount
    {
        public DateTime SavingBeginTime { get; set; }
        public int numberOfSavingDays { get; set; }
        public DateTime SavingEndTime {
        get
            {
                return SavingBeginTime.AddDays(numberOfSavingDays);
            }
        }

        public override string Withdraw(decimal amount)
        {
            if (DateTime.Today != SavingEndTime.Date)
            {
                return "Wait for the savings end date.";
            }
            else if(Balance<amount) {
                return "Insufficient balance.";
            }
            else if(amount%5 != 0)
            {
                return "You can ";
            }
            else
            {
                return base.Withdraw(amount);
            }
        }

        public override string Deposit(decimal amount)
        {
            if (DateTime.Today.Date == SavingEndTime.Date)
            {
                return base.Deposit(amount);
            }
            else
            {
                return "Wait for the savings end date";
            }
        }


    }
}
