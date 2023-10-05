using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperBank
{
    class Transaction : TransactionBase

    {

        public double amount { get; }

        public string note { get; }

        public DateTime Date { get; }



        public Transaction(double amount, string note, DateTime date)
        {

            this.amount = amount;

            this.note = note;

            this.Date = date;

        }
    }
}
