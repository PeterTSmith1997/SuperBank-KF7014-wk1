using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount bank = new  BankAccount("peter", 1.22);  
            Console.WriteLine("bank account for" + bank.name + " no."+bank.accountNum+" ammout "+bank.balance);
            bank.MakeDeposit(100, DateTime.Now, "100 in");
            Console.WriteLine( bank.balance);
            Console.WriteLine(bank.allTrans);
        }
    }
}
