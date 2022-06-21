using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Creationals.AbstractFactoryMethod
{
    class ModernFurnitureFactory : IAbstractFactory
    {
        public IAbstractChair CreateChair()
        {
            return new ModernChair();
        }

        public IAbstractTable CreateTable()
        {
            return new ModernTable();
        }
    }
    class ClassicFurnitureFactory : IAbstractFactory
    {
        public IAbstractChair CreateChair()
        {
            return new ClassicChair();
        }

        public IAbstractTable CreateTable()
        {
            return new ClassicTable();
        }
    }
}
