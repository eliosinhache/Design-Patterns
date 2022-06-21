using Design_Patterns.Creationals.FactoryMethod;
using System;

namespace Design_Patterns
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
