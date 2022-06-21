using Design_Patterns.AbstractFactoryMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns
{
    class AbstractFactoryMethodRun
    {
        public AbstractFactoryMethodRun()
        {
            ClientMethod(new ModernFurnitureFactory());
            Console.WriteLine();
            ClientMethod(new ClassicFurnitureFactory());
        }

        public void ClientMethod(IAbstractFactory factory)
        {
            var chair = factory.CreateChair();
            var table = factory.CreateTable();

            Console.WriteLine(chair.SitDown());
            Console.WriteLine(table.PutTheTable());
            Console.WriteLine(chair.GetCloser(table));
        }
    }

}
