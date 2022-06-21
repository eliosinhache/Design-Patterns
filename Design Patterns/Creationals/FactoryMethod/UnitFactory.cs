using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Creationals.FactoryMethod
{
    class SoldierCreator : CreatorBase
    {
        protected override IWarrior CreateWarrior()
        {
            return new Soldier();
        }
    }
    class ArcherCreator : CreatorBase
    {
        protected override IWarrior CreateWarrior()
        {
            return new Archer();
        }
    }
}
