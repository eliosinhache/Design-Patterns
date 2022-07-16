using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral.Command
{
    //Receiver/Request
    class Account
    {
        private int _id;
        private double _balance;

        public Account(int id, double balance)
        {
            _id = id;
            _balance = balance;
        }

        public void Extract(double amount)
        {
            _balance -= amount;
            Console.WriteLine($"Extract Commando - Balance id: {_id} with {_balance}");
        }

        public void Deposit(double amount)
        {
            _balance += amount;
            Console.WriteLine($"Deposit Command - Balance id: {_id} with {_balance}");
        }
    }
}
