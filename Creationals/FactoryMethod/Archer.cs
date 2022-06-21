﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creationals.FactoryMethod
{
    class Archer : IWarrior
    {
        public string Attack()
        {
            return "Attack with Arrows!!";
        }
    }
}