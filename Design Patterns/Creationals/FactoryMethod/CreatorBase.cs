using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Creationals.FactoryMethod
{
    abstract class CreatorBase
    {
        protected abstract IWarrior CreateWarrior();

        public string Attack()
        {
            var warrior = CreateWarrior();
            var result = $"Attack Order receive and the warrior: {warrior.Attack()}";
            return result;
        }
    }

}
