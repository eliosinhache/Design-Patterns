using System;
using Design_Patterns.Behavioral.Strategy;

namespace Design_Patterns.PatternsRunners
{
    public class StrategyRun
    {
        public StrategyRun()
        {
            var context = new Context();
            
            Console.WriteLine("Client: Strategy is set to Normal Sorting");
            context.SetStrategy(new SpecificStrategyA());
            context.DoSomeBusinessLogic();
            
            Console.WriteLine();
            
            Console.WriteLine("Client: Strategy is set to Reverse Sorting");
            context.SetStrategy(new SpecificStrategyB());
            context.DoSomeBusinessLogic();
        }
    }
}