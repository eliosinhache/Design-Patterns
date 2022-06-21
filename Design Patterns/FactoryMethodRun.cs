using Creationals.FactoryMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
