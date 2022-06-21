﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creationals.FactoryMethod
{
    class ArcherCreator : CreatorBase
    {
        protected override IWarrior CreateWarrior()
        {
            return new Archer();
        }
    }
}