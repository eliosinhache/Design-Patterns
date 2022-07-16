using Design_Patterns.Behavioral.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.PatternsRunners
{
    class CommandRun
    {
        public CommandRun()
        {
            Account myAccount = new Account(3, 500);

            DepositImplementation commandDeposit = new DepositImplementation(myAccount, 150);
            ExtractImplementation commandExtract = new ExtractImplementation(myAccount, 200);

            Invoker invoker = new Invoker();
            invoker.AddCommand(commandDeposit);
            invoker.AddCommand(commandExtract);

            invoker.ExecuteCommands();
        }
    }
}
