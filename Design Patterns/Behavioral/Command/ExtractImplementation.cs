using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral.Command
{
    class ExtractImplementation : Command
    {
        private Account _account;
        private double _amount;

        public ExtractImplementation(Account account, double amount)
        {
            _account = account;
            _amount = amount;
        }
        public void execute()
        {
            _account.Extract(_amount);
        }
    }
}
