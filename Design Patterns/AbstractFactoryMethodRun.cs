using Design_Patterns.Creationals.AbstractFactoryMethod;
using System;

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
