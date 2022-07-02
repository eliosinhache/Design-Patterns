using System;
using Design_Patterns.Creationals.FactoryMethod;

namespace Design_Patterns.PatternsRunners
{
    class FactoryMethodRun
    {
        public FactoryMethodRun()
        {
            SoldierCreator soldier = new SoldierCreator();
            Console.WriteLine(soldier.Attack());
            ArcherCreator archer = new ArcherCreator();
            Console.WriteLine(archer.Attack());
        }
    }
}
