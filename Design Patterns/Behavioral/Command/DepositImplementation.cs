using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral.Command
{
    class DepositImplementation : Command
    {
        private Account _account;
        private double _amount;

        public DepositImplementation(Account account, double amount)
        {
            _account = account;
            _amount = amount;
        }

        public void execute()
        {
            _account.Deposit(_amount);
        }
    }
}
