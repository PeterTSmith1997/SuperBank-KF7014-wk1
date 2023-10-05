using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SuperBank
{
    class BankAccount
    {
        public string name { get; set; }
        public int accountNum { get; set; }

        double balance_tmp = 0; // define a new variable to differenciate the initial balance from transactions

        public double balance
        {

            get
            {

                double balance = balance_tmp;

                foreach (var item in allTrans)

                {

                    balance = balance + item.amount; // we should use item.amount for balance

                }

                return balance;

            }

        }



        private static int seed = 1000202;

        public List<Transaction> allTrans = new List<Transaction>();

        public BankAccount(string name, double startBalance)
        {

            this.name = name;

            accountNum = seed;
            MakeDeposit(startBalance, DateTime.UtcNow, "start bal"); // this seems to make sense

//            balance_tmp = startBalance;  // initial balance



            seed++;
        }   
        public void MakeDeposit(double amount, DateTime date, string note)

        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "must be pos");
            }
            Transaction transactionToAdd = new Transaction(amount, note, date);
            allTrans.Add(transactionToAdd);

       

        }

        public void MakeWithdrawal(double amount, DateTime date, string note)

        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Must be more than 0");
            }
            if (balance - amount <0)
            {
                throw new InvalidOperationException("not enough money");
            }
            Transaction transactionToSub = new Transaction(-amount, note, date);
            allTrans.Add(transactionToSub);



        }

        public string listTrans() 
        {
            return allTrans.ToString();

        }
    }

}
