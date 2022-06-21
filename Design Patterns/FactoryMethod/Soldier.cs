using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creationals.FactoryMethod
{
    class Soldier : IWarrior
    {
        public string Attack()
        {
            return "Attack with a Sword!";
        }
    }
}
