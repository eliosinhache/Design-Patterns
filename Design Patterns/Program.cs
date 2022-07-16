using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Design_Patterns.PatternsRunners;

namespace Design_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //FactoryMethodRun factoryMethor = new FactoryMethodRun();
            //AbstractFactoryMethodRun factoryMethod = new AbstractFactoryMethodRun();
            //SingletonRun singleton = new SingletonRun();
            // FacadeRun facade = new FacadeRun();
            // AdapterRun adapter = new AdapterRun();
            // ObserverRun observer = new ObserverRun();
            //StrategyRun strategy = new StrategyRun();
            CommandRun command = new CommandRun();
            Console.ReadLine();
        }
    }
}
