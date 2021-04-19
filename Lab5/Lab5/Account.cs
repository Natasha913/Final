using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Account
    {

        public string AccName { get; set; }
        public string AccNo { get; }
        public double Balance { get; set; }

        public Transactions[] transactions;
        public int totalNumberOfTransections;

        public Account()
        {
            transactions = new Transactions[10];
        }

        public Account(string accName, string accNo, double balance)
        {
            AccName = accName;
            AccNo = accNo;
            Balance = balance;
            transactions = new Transactions[10];
        }
        public void addTransaction(params Transactions[] transactions)

        {
            foreach (var a in transactions)
            {
                this.transactions[totalNumberOfTransections++] = a;
            }
        }

        public void showAllTransaction()
        {
            for (int i = 0; i < totalNumberOfTransections; i++)
            {
                transactions[i].ShowInfo();
            }
        }
        public void ShowInfo()
        {
            Console.WriteLine("Name: " + AccName);
            Console.WriteLine("Acc No: " + AccNo);
            Console.WriteLine("Balance: " + Balance);

        }


        public void Deposit(int amount)
        {
            Balance += amount;
            transactions[totalNumberOfTransections++] = new Transactions(this, this, amount, "self deposit");
        }
        virtual public void Withdraw(int amount)
        {
            if (amount < Balance)
            {
                Balance -= amount;
                Console.WriteLine("Balance now is {0}}:", Balance);
                transactions[totalNumberOfTransections++] = new Transactions(this, this, amount, "self Widhdraw");
            }
            else
            {
                Console.WriteLine("Not Enough Balance");
            }
        }


        virtual public void Transfer(Account a, int amount)
        {
            if (amount < Balance)
            {
                Balance -= amount;
                Console.WriteLine("Balance now is {0}}:", Balance);
                transactions[totalNumberOfTransections++] = new Transactions(this, a, amount, "Transfer");
            }
            else
            {
                Console.WriteLine("Not Enough Balance");
            }
        }


    }
}
